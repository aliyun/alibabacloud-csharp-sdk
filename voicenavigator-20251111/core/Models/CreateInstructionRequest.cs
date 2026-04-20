// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateInstructionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Transfer00</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;providerId&quot;: &quot;xxxxxxxxx&quot;,
        ///     &quot;transferMethod&quot;: &quot;BYE&quot;,
        ///     &quot;transferType&quot;: &quot;External&quot;,
        ///     &quot;transferTarget&quot;: &quot;152******&quot;,
        ///     &quot;transferor&quot;: &quot;01*****&quot;,
        ///     &quot;timeoutSeconds&quot;: &quot;10&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TRANSFER</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
