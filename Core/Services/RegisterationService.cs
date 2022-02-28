using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Contracts;
using Core.DTOs;
using Models;

namespace Core.Services
{
    public class RegisterationService  : IRegisteration
    {
        private readonly IVoterRepository _voterRepo;

        public RegisterationService(IVoterRepository voterRepository)
        {
            _voterRepo = voterRepository;
        }

        public Voter RegisterNewVoter(VoterRegDTO model)
        {

            Voter newVoter = new Voter()
            {
                DateOfBirth = model.DateOfBirth,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                PollingUnit = new Polling("ABS")
            };

            try
            {
                return _voterRepo.Add(newVoter);
            }catch (Exception)
            {

            }
            return null;
        }
    }
}
