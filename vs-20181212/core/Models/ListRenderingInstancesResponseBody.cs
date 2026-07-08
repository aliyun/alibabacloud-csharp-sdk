// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>List of cloud application service instances</para>
        /// </summary>
        [NameInMap("RenderingInstances")]
        [Validation(Required=false)]
        public List<ListRenderingInstancesResponseBodyRenderingInstances> RenderingInstances { get; set; }
        public class ListRenderingInstancesResponseBodyRenderingInstances : TeaModel {
            /// <summary>
            /// <para>Creation time of the cloud application service instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-11-17T02:18:04Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>ID of the cloud application service instance</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <para>Instance type of the cloud application service</para>
            /// 
            /// <b>Example:</b>
            /// <para>crs.cp.l1</para>
            /// </summary>
            [NameInMap("RenderingSpec")]
            [Validation(Required=false)]
            public string RenderingSpec { get; set; }

            /// <summary>
            /// <para>Storage capacity, in GB</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("StorageSize")]
            [Validation(Required=false)]
            public int? StorageSize { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of cloud application service instances</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
