// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveRecordVodConfigRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=true)]
        public string AppName { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("VodTranscodeGroupId")]
        [Validation(Required=true)]
        public string VodTranscodeGroupId { get; set; }

        [NameInMap("CycleDuration")]
        [Validation(Required=false)]
        public int? CycleDuration { get; set; }

        [NameInMap("AutoCompose")]
        [Validation(Required=false)]
        public string AutoCompose { get; set; }

        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

        [NameInMap("ComposeVodTranscodeGroupId")]
        [Validation(Required=false)]
        public string ComposeVodTranscodeGroupId { get; set; }

    }

}
