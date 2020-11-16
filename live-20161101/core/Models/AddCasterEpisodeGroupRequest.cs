// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("Item")]
        [Validation(Required=true)]
        public List<AddCasterEpisodeGroupRequestItem> Item { get; set; }
        public class AddCasterEpisodeGroupRequestItem : TeaModel {
            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("VodUrl")]
            [Validation(Required=false)]
            public string VodUrl { get; set; }

        }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("RepeatNum")]
        [Validation(Required=true)]
        public int? RepeatNum { get; set; }

        [NameInMap("SideOutputUrl")]
        [Validation(Required=true)]
        public string SideOutputUrl { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=true)]
        public string CallbackUrl { get; set; }

    }

}
