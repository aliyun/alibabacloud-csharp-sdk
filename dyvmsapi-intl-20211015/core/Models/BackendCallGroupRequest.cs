/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class BackendCallGroupRequest : TeaModel {
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public List<string> CalledNumber { get; set; }

        [NameInMap("CallerIdNumber")]
        [Validation(Required=false)]
        public string CallerIdNumber { get; set; }

        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SendType")]
        [Validation(Required=false)]
        public long? SendType { get; set; }

        [NameInMap("Speed")]
        [Validation(Required=false)]
        public long? Speed { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        [NameInMap("TimingStart")]
        [Validation(Required=false)]
        public string TimingStart { get; set; }

        [NameInMap("TtsCode")]
        [Validation(Required=false)]
        public string TtsCode { get; set; }

        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public long? Volume { get; set; }

    }

}
