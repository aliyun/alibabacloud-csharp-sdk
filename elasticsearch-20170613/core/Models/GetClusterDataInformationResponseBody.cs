// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetClusterDataInformationResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5FFD9ED4-C2EC-4E89-B22B-1ACB6FE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The return results.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetClusterDataInformationResponseBodyResult Result { get; set; }
        public class GetClusterDataInformationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Whether it is connectable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("connectable")]
            [Validation(Required=false)]
            public bool? Connectable { get; set; }

            /// <summary>
            /// <para>The metadata of the cluster.</para>
            /// </summary>
            [NameInMap("metaInfo")]
            [Validation(Required=false)]
            public GetClusterDataInformationResponseBodyResultMetaInfo MetaInfo { get; set; }
            public class GetClusterDataInformationResponseBodyResultMetaInfo : TeaModel {
                /// <summary>
                /// <para>The fields in the Mapping for the index.</para>
                /// </summary>
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<string> Fields { get; set; }

                /// <summary>
                /// <para>The index list of the cluster.</para>
                /// </summary>
                [NameInMap("indices")]
                [Validation(Required=false)]
                public List<string> Indices { get; set; }

                /// <summary>
                /// <para>The Mapping configuration of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;_doc\&quot;:{\&quot;properties\&quot;:{\&quot;user\&quot;:{\&quot;properties\&quot;:{\&quot;last\&quot;:{\&quot;type\&quot;:\&quot;text\&quot;,...}}}}}}</para>
                /// </summary>
                [NameInMap("mapping")]
                [Validation(Required=false)]
                public string Mapping { get; set; }

                /// <summary>
                /// <para>The Settings of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\n  \&quot;index\&quot;: {\n    \&quot;replication\&quot;: {\n}.....}}</para>
                /// </summary>
                [NameInMap("settings")]
                [Validation(Required=false)]
                public string Settings { get; set; }

                /// <summary>
                /// <para>Specifies the type of the index.</para>
                /// </summary>
                [NameInMap("typeName")]
                [Validation(Required=false)]
                public List<string> TypeName { get; set; }

            }

        }

    }

}
