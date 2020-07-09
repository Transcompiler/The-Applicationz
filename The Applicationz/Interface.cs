namespace The_Statesman
{
    interface IRoot
    {

    }

    interface IMaps : IRoot
    {

    }

    interface IData : IRoot
    {

    }

    interface IBuildable : IData
    {

    }

    interface IConstructable : IData
    {

    }

    interface IResource : IData
    {

    }

    interface IRemovable : IResource
    {

    }

    interface IWonder : IBuildable
    {

    }

    interface IUnit : IData
    {
        void SpawnUnit()
        {
        }
    }

    interface IMilitaryUnit : IUnit
    {

    }

    interface INonMillUnit : IUnit
    {

    }

    interface IResearchable : IData
    {

    }
}
