// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ModifyTTSConfigRequest : TeaModel {
        [NameInMap("AliCustomizedVoice")]
        [Validation(Required=false)]
        public string AliCustomizedVoice { get; set; }

        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("EngineXunfei")]
        [Validation(Required=false)]
        public string EngineXunfei { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

        [NameInMap("SpeechRate")]
        [Validation(Required=false)]
        public string SpeechRate { get; set; }

        [NameInMap("Voice")]
        [Validation(Required=false)]
        public string Voice { get; set; }

        [NameInMap("Volume")]
        [Validation(Required=false)]
        public string Volume { get; set; }

    }

}
