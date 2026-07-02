// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKmsInstanceQuotaInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the KMS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-hzz6****</para>
        /// </summary>
        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

        /// <summary>
        /// <para>An array of quota details for the instance.</para>
        /// </summary>
        [NameInMap("KmsInstanceQuotaInfos")]
        [Validation(Required=false)]
        public List<GetKmsInstanceQuotaInfosResponseBodyKmsInstanceQuotaInfos> KmsInstanceQuotaInfos { get; set; }
        public class GetKmsInstanceQuotaInfosResponseBodyKmsInstanceQuotaInfos : TeaModel {
            /// <summary>
            /// <para>The quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("ResourceQuota")]
            [Validation(Required=false)]
            public long? ResourceQuota { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The quota usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("UsedQuantity")]
            [Validation(Required=false)]
            public long? UsedQuantity { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1fdfa9d-bd49-418b-942f-8f3e3ec00a4f</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
