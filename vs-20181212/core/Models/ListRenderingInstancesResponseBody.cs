// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingInstancesResponseBody : TeaModel {
        [NameInMap("RenderingInstances")]
        [Validation(Required=false)]
        public List<ListRenderingInstancesResponseBodyRenderingInstances> RenderingInstances { get; set; }
        public class ListRenderingInstancesResponseBodyRenderingInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-11-17T02:18:04Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>crs.cp.l1</para>
            /// </summary>
            [NameInMap("RenderingSpec")]
            [Validation(Required=false)]
            public string RenderingSpec { get; set; }

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
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
