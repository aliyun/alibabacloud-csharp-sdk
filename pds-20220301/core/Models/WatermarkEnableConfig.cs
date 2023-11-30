// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class WatermarkEnableConfig : TeaModel {
        [NameInMap("display_access_user_name")]
        [Validation(Required=false)]
        public bool? DisplayAccessUserName { get; set; }

        [NameInMap("display_custom_text")]
        [Validation(Required=false)]
        public string DisplayCustomText { get; set; }

        [NameInMap("display_shareLink_creator_name")]
        [Validation(Required=false)]
        public bool? DisplayShareLinkCreatorName { get; set; }

        [NameInMap("enable_doc_preview")]
        [Validation(Required=false)]
        public bool? EnableDocPreview { get; set; }

    }

}
