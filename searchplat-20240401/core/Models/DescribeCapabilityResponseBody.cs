// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class DescribeCapabilityResponseBody : TeaModel {
        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public long? HttpCode { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E3D5E2B-B63A-4445-B359-329CC07255EA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Response result</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeCapabilityResponseBodyResult Result { get; set; }
        public class DescribeCapabilityResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Timestamp of creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1745893195510</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public long? Created { get; set; }

            /// <summary>
            /// <para>Whether it is the default configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>Configuration category</para>
            /// 
            /// <b>Example:</b>
            /// <para>ai_search_agent</para>
            /// </summary>
            [NameInMap("itemCategory")]
            [Validation(Required=false)]
            public string ItemCategory { get; set; }

            /// <summary>
            /// <para>Configuration description</para>
            /// 
            /// <b>Example:</b>
            /// <para>描述</para>
            /// </summary>
            [NameInMap("itemDesc")]
            [Validation(Required=false)]
            public string ItemDesc { get; set; }

            /// <summary>
            /// <para>Configuration name</para>
            /// 
            /// <b>Example:</b>
            /// <para>es_knowledge_base</para>
            /// </summary>
            [NameInMap("itemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

            /// <summary>
            /// <para>An object containing information such as endpoint and function, which describes the detailed configuration of the knowledge base.</para>
            /// </summary>
            [NameInMap("itemValue")]
            [Validation(Required=false)]
            public Dictionary<string, object> ItemValue { get; set; }

            /// <summary>
            /// <para>Status</para>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Update timestamp</para>
            /// 
            /// <b>Example:</b>
            /// <para>1729665694</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public long? Updated { get; set; }

        }

        /// <summary>
        /// <para>Request status</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
