// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterModelEnhancementResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the model enhancement feature was enabled, in the ISO 8601 UTC format (YYYY-MM-DDThh:mm:ssZ).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The number of API keys for model enhancement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModelEnhancementKeyNumber")]
        [Validation(Required=false)]
        public int? ModelEnhancementKeyNumber { get; set; }

        /// <summary>
        /// <para>The list of API keys for model enhancement.</para>
        /// </summary>
        [NameInMap("ModelEnhancementKeys")]
        [Validation(Required=false)]
        public List<DescribeDBClusterModelEnhancementResponseBodyModelEnhancementKeys> ModelEnhancementKeys { get; set; }
        public class DescribeDBClusterModelEnhancementResponseBodyModelEnhancementKeys : TeaModel {
            /// <summary>
            /// <para>The value of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak-12345</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The ID of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-001</para>
            /// </summary>
            [NameInMap("ApiKeyId")]
            [Validation(Required=false)]
            public string ApiKeyId { get; set; }

            /// <summary>
            /// <para>The time when the API key was created, in the ISO 8601 UTC format (YYYY-MM-DDThh:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Model enhancement key</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expiration time of the API key, in the ISO 8601 UTC format (YYYY-MM-DDThh:mm:ssZ).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-31T23:59:59Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

        }

        /// <summary>
        /// <para>The status of the model enhancement feature. A value of ON indicates that the feature is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("ModelEnhancementStatus")]
        [Validation(Required=false)]
        public string ModelEnhancementStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
