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

    interface IResearchable : IData
    {

    }
}
