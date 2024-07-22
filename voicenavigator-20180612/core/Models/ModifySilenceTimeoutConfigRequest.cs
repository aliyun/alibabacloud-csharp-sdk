// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ModifySilenceTimeoutConfigRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FinalAction")]
        [Validation(Required=false)]
        public string FinalAction { get; set; }

        [NameInMap("FinalActionParams")]
        [Validation(Required=false)]
        public string FinalActionParams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("FinalPrompt")]
        [Validation(Required=false)]
        public string FinalPrompt { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentTrigger")]
        [Validation(Required=false)]
        public string IntentTrigger { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public int? Threshold { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
