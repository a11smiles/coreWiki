using CoreWiki.Entities;

namespace CoreWiki.Providers.Data {
    public interface IPages
    {
        Page GetPage(bool isHome);
        Page AddPage(Page page);
        Page UpdatePage(Page page);
        Page DeletePage(long id);
    }

}