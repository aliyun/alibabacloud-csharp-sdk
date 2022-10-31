// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetCasterConfigRequest : TeaModel {
        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("CasterName")]
        [Validation(Required=false)]
        public string CasterName { get; set; }

        [NameInMap("ChannelEnable")]
        [Validation(Required=false)]
        public int? ChannelEnable { get; set; }

        [NameInMap("Delay")]
        [Validation(Required=false)]
        public float? Delay { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProgramEffect")]
        [Validation(Required=false)]
        public int? ProgramEffect { get; set; }

        [NameInMap("ProgramName")]
        [Validation(Required=false)]
        public string ProgramName { get; set; }

        [NameInMap("RecordConfig")]
        [Validation(Required=false)]
        public string RecordConfig { get; set; }

        [NameInMap("SideOutputUrl")]
        [Validation(Required=false)]
        public string SideOutputUrl { get; set; }

        [NameInMap("SideOutputUrlList")]
        [Validation(Required=false)]
        public string SideOutputUrlList { get; set; }

        [NameInMap("SyncGroupsConfig")]
        [Validation(Required=false)]
        public string SyncGroupsConfig { get; set; }

        [NameInMap("TranscodeConfig")]
        [Validation(Required=false)]
        public string TranscodeConfig { get; set; }

        [NameInMap("UrgentLiveStreamUrl")]
        [Validation(Required=false)]
        public string UrgentLiveStreamUrl { get; set; }

        [NameInMap("UrgentMaterialId")]
        [Validation(Required=false)]
        public string UrgentMaterialId { get; set; }

    }

}
