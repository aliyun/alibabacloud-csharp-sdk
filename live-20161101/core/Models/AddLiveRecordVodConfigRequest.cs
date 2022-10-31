// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveRecordVodConfigRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AutoCompose")]
        [Validation(Required=false)]
        public string AutoCompose { get; set; }

        [NameInMap("ComposeVodTranscodeGroupId")]
        [Validation(Required=false)]
        public string ComposeVodTranscodeGroupId { get; set; }

        [NameInMap("CycleDuration")]
        [Validation(Required=false)]
        public int? CycleDuration { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("VodTranscodeGroupId")]
        [Validation(Required=false)]
        public string VodTranscodeGroupId { get; set; }

    }

}
