// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class CreateLlmAccessProfileRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>33014787-cc13-49d3-ab2f-a98aa8f15fbb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language model access configuration.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public CreateLlmAccessProfileRequestProfile Profile { get; set; }
        public class CreateLlmAccessProfileRequestProfile : TeaModel {
            /// <summary>
            /// <para>The API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-api-key</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The model service registration URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://adbpg-ai-gateway10-cn-beijing.opentrust.net/1383274970238153-193">https://adbpg-ai-gateway10-cn-beijing.opentrust.net/1383274970238153-193</a></para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sample configuration</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
