// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddCasterEpisodeGroupRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("RepeatNum")]
        [Validation(Required=false)]
        public int? RepeatNum { get; set; }

        [NameInMap("SideOutputUrl")]
        [Validation(Required=false)]
        public string SideOutputUrl { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("Item")]
        [Validation(Required=false)]
        public List<AddCasterEpisodeGroupRequestItem> Item { get; set; }
        public class AddCasterEpisodeGroupRequestItem : TeaModel {
            [NameInMap("ItemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            [NameInMap("VodUrl")]
            [Validation(Required=false)]
            public string VodUrl { get; set; }

        }

    }

}
