// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetClusterDataInformationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetClusterDataInformationResponseBodyResult Result { get; set; }
        public class GetClusterDataInformationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether the cluster is connectable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("connectable")]
            [Validation(Required=false)]
            public bool? Connectable { get; set; }

            /// <summary>
            /// <para>The metadata information of the cluster.</para>
            /// </summary>
            [NameInMap("metaInfo")]
            [Validation(Required=false)]
            public GetClusterDataInformationResponseBodyResultMetaInfo MetaInfo { get; set; }
            public class GetClusterDataInformationResponseBodyResultMetaInfo : TeaModel {
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<string> Fields { get; set; }

                [NameInMap("indices")]
                [Validation(Required=false)]
                public List<string> Indices { get; set; }

                /// <summary>
                /// <para>The mapping configuration of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;_doc\&quot;:{\&quot;properties\&quot;:{\&quot;user\&quot;:{\&quot;properties\&quot;:{\&quot;last\&quot;:{\&quot;type\&quot;:\&quot;text\&quot;,...}}}}}}</para>
                /// </summary>
                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }

                /// <summary>
                /// <para>The settings configuration of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\n  \&quot;index\&quot;: {\n    \&quot;replication\&quot;: {\n}.....}}</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                [NameInMap("typeName")]
                [Validation(Required=false)]
                public List<string> TypeName { get; set; }

            }

        }

    }

}
