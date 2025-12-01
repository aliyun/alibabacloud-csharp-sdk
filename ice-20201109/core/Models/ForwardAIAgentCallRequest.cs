// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ForwardAIAgentCallRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>13**********</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        [NameInMap("ErrorPrompt")]
        [Validation(Required=false)]
        public string ErrorPrompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>call_instance_202******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("TransferPrompt")]
        [Validation(Required=false)]
        public string TransferPrompt { get; set; }

    }

}
