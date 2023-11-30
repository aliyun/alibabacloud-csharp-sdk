// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class DomainSeniorConfig : TeaModel {
        [NameInMap("client_download_enable")]
        [Validation(Required=false)]
        public bool? ClientDownloadEnable { get; set; }

        [NameInMap("csp_frame_ancestors")]
        [Validation(Required=false)]
        public string CspFrameAncestors { get; set; }

        [NameInMap("custom_login_appid")]
        [Validation(Required=false)]
        public string CustomLoginAppid { get; set; }

        [NameInMap("custom_login_url")]
        [Validation(Required=false)]
        public string CustomLoginUrl { get; set; }

        [NameInMap("custom_logout_url")]
        [Validation(Required=false)]
        public string CustomLogoutUrl { get; set; }

        [NameInMap("custom_side_link_list")]
        [Validation(Required=false)]
        public List<CustomSideLinkConfig> CustomSideLinkList { get; set; }

        [NameInMap("home_page_bg_image_url")]
        [Validation(Required=false)]
        public string HomePageBgImageUrl { get; set; }

        [NameInMap("home_page_footer")]
        [Validation(Required=false)]
        public string HomePageFooter { get; set; }

        [NameInMap("home_page_footer2")]
        [Validation(Required=false)]
        public string HomePageFooter2 { get; set; }

        [NameInMap("home_page_slogan")]
        [Validation(Required=false)]
        public string HomePageSlogan { get; set; }

        [NameInMap("referer_enable")]
        [Validation(Required=false)]
        public bool? RefererEnable { get; set; }

        [NameInMap("wx_txt_list")]
        [Validation(Required=false)]
        public WxTrustedDomainConfig WxTxtList { get; set; }

    }

}
