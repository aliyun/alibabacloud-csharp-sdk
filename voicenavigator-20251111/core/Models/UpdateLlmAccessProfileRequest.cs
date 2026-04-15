// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class UpdateLlmAccessProfileRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66b</para>
        /// </summary>
        [NameInMap("AccessProfileId")]
        [Validation(Required=false)]
        public string AccessProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>d74d6290-7cbe-4436-b5d7-014ebb0f4060</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public UpdateLlmAccessProfileRequestProfile Profile { get; set; }
        public class UpdateLlmAccessProfileRequestProfile : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>akm-091e4c2c-9938-4a0d-ade2-b9c477fbcbdb</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>api.llm.enpoint.example.com</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
