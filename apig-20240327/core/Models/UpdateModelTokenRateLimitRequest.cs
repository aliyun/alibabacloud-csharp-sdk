// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateModelTokenRateLimitRequest : TeaModel {
        /// <summary>
        /// <para>The complete list of consumer limits. Pass an empty array to clear the consumer limits for the model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;consumerId&quot;:&quot;cs-example01&quot;,&quot;tpm&quot;:300}]</para>
        /// </summary>
        [NameInMap("consumers")]
        [Validation(Required=false)]
        public List<UpdateModelTokenRateLimitRequestConsumers> Consumers { get; set; }
        public class UpdateModelTokenRateLimitRequestConsumers : TeaModel {
            /// <summary>
            /// <para>The ID of the consumer.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-example01</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>The tokens per minute (TPM) limit for the consumer using this model.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("tpm")]
            [Validation(Required=false)]
            public long? Tpm { get; set; }

        }

        /// <summary>
        /// <para>The revision returned by the last query. Set this parameter to 0 for the first configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("expectedRevision")]
        [Validation(Required=false)]
        public long? ExpectedRevision { get; set; }

        /// <summary>
        /// <para>The global tokens per minute (TPM) limit for the model within the instance. If this parameter is omitted, the global limit is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("globalTpm")]
        [Validation(Required=false)]
        public long? GlobalTpm { get; set; }

    }

}
