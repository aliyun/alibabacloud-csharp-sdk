// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class UnmuteAudioAllRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("ConferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

        [NameInMap("ParticipantId")]
        [Validation(Required=false)]
        public string ParticipantId { get; set; }

    }

}
