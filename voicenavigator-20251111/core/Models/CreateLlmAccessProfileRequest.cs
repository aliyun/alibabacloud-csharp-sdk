// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class CreateLlmAccessProfileRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public CreateLlmAccessProfileRequestProfile Profile { get; set; }
        public class CreateLlmAccessProfileRequestProfile : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>70tKleNtMGaaIem7us7Miw-Tf3kPzE6l</para>
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
