// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListNamespacesResponseBody : TeaModel {
        /// <summary>
        /// <para>Return results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListNamespacesResponseBodyData Data { get; set; }
        public class ListNamespacesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Result page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Return results.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListNamespacesResponseBodyDataResult> Result { get; set; }
            public class ListNamespacesResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>Number of applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AppCount")]
                [Validation(Required=false)]
                public int? AppCount { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-02T09:49:48.000+0000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Namespace description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace 1 for testing</para>
                /// </summary>
                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// <para>Number of online nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public long? InstanceCount { get; set; }

                /// <summary>
                /// <para>Namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myNamespace</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>Region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>Alibaba Cloud tags.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;1&quot;:&quot;1&quot;,&quot;2&quot;:&quot;2&quot;}</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public Dictionary<string, object> Tags { get; set; }

                /// <summary>
                /// <para>Update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-02T09:49:48.000+0000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>User ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>178*******</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Version. Basic Edition 0, Professional Edition 1, Enterprise Edition 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>Result set.</para>
            /// </summary>
            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ListNamespacesResponseBodyDataResults> Results { get; set; }
            public class ListNamespacesResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>Number of applications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AppCount")]
                [Validation(Required=false)]
                public int? AppCount { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-02T09:49:48.000+0000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Namespace description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace 1 for testing</para>
                /// </summary>
                [NameInMap("Describe")]
                [Validation(Required=false)]
                public string Describe { get; set; }

                /// <summary>
                /// <para>Number of online nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("InstanceCount")]
                [Validation(Required=false)]
                public long? InstanceCount { get; set; }

                /// <summary>
                /// <para>Namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myNamespace</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>Region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>Update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-09-02T09:49:48.000+0000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// <para>User ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>178*******</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Version. Basic Edition 0, Professional Edition 1, Enterprise Edition 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>Total number of query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D1F1A6F3-7E03-5EAD-B3F1-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
