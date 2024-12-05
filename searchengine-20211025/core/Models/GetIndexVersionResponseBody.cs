// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetIndexVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7B7D598-B080-5C8E-AA35-D43EC0D5F886</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The clusters.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetIndexVersionResponseBodyResult Result { get; set; }
        public class GetIndexVersionResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The cluster name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ayoss-cn-zhangjiakou-b</para>
            /// </summary>
            [NameInMap("cluster")]
            [Validation(Required=false)]
            public string Cluster { get; set; }

            /// <summary>
            /// <para>The index versions.</para>
            /// </summary>
            [NameInMap("indexVersions")]
            [Validation(Required=false)]
            public List<GetIndexVersionResponseBodyResultIndexVersions> IndexVersions { get; set; }
            public class GetIndexVersionResponseBodyResultIndexVersions : TeaModel {
                /// <summary>
                /// <para>The ID of the offline deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot; &quot;</para>
                /// </summary>
                [NameInMap("buildDeployId")]
                [Validation(Required=false)]
                public string BuildDeployId { get; set; }

                /// <summary>
                /// <para>The current online version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("currentVersion")]
                [Validation(Required=false)]
                public long? CurrentVersion { get; set; }

                /// <summary>
                /// <para>The name of the index table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>table4</para>
                /// </summary>
                [NameInMap("indexName")]
                [Validation(Required=false)]
                public string IndexName { get; set; }

                /// <summary>
                /// <para>The index versions.</para>
                /// </summary>
                [NameInMap("versions")]
                [Validation(Required=false)]
                public List<long?> Versions { get; set; }

            }

        }

    }

}
