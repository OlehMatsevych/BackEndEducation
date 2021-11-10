using System;

namespace Patterns
{
    public interface IApartmentFactory
    {
        IPresidentApartment CreatePresidentApartment();
        IStandardApartment CreateStandardApartment();
    }

    public class ApartmentWithReservation : IApartmentFactory
    {
        public IPresidentApartment CreatePresidentApartment()
        {
            throw new NotImplementedException();
        }

        public IStandardApartment CreateStandardApartment()
        {
            throw new NotImplementedException();
        }
    }

    public class ApartmentWithoutReservation : IApartmentFactory
    {
        public IPresidentApartment CreatePresidentApartment()
        {
            throw new NotImplementedException();
        }

        public IStandardApartment CreateStandardApartment()
        {
            throw new NotImplementedException();
        }
    }

    //********************************************************************

    public interface IPresidentApartment
    {
        object GetManager();
    }
    public class PresidentApartmentWithReservation : IPresidentApartment
    {
        public object GetManager()
        {
            throw new System.NotImplementedException();
        }
    }
    public class PresidentApartmentWithoutReservation : IPresidentApartment
    {
        public object GetManager()
        {
            throw new System.NotImplementedException();
        }
    }


    public interface IStandardApartment
    {
        object GetManager();
    }
    public class StandardApartmentWithReservation : IStandardApartment
    {
        public object GetManager()
        {
            throw new System.NotImplementedException();
        }
    }
    public class StandardApartmentWithoutReservation : IStandardApartment
    {
        public object GetManager()
        {
            throw new System.NotImplementedException();
        }
    }
}
