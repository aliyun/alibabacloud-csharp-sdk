// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingProjectInstancesResponseBody : TeaModel {
        [NameInMap("RenderingInstances")]
        [Validation(Required=false)]
        public List<ListRenderingProjectInstancesResponseBodyRenderingInstances> RenderingInstances { get; set; }
        public class ListRenderingProjectInstancesResponseBodyRenderingInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-09-11T18:19:04+08:00</para>
            /// </summary>
            [NameInMap("AssociationTime")]
            [Validation(Required=false)]
            public string AssociationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            [NameInMap("StateInfo")]
            [Validation(Required=false)]
            public ListRenderingProjectInstancesResponseBodyRenderingInstancesStateInfo StateInfo { get; set; }
            public class ListRenderingProjectInstancesResponseBodyRenderingInstancesStateInfo : TeaModel {
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-11-11T18:19:04+08:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
