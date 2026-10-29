// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingProjectInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud application service instances.</para>
        /// </summary>
        [NameInMap("RenderingInstances")]
        [Validation(Required=false)]
        public List<ListRenderingProjectInstancesResponseBodyRenderingInstances> RenderingInstances { get; set; }
        public class ListRenderingProjectInstancesResponseBodyRenderingInstances : TeaModel {
            /// <summary>
            /// <para>The association time. The time is in the ISO 8601 standard and includes a time zone offset. The format is YYYY-MM-DDTHH:mm:ss+HH:mm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-11T18:19:04+08:00</para>
            /// </summary>
            [NameInMap("AssociationTime")]
            [Validation(Required=false)]
            public string AssociationTime { get; set; }

            /// <summary>
            /// <para>The ID of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-9f8c57355d224ad7beaf95e145f22111</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <para>The project instance status information.</para>
            /// </summary>
            [NameInMap("StateInfo")]
            [Validation(Required=false)]
            public ListRenderingProjectInstancesResponseBodyRenderingInstancesStateInfo StateInfo { get; set; }
            public class ListRenderingProjectInstancesResponseBodyRenderingInstancesStateInfo : TeaModel {
                /// <summary>
                /// <para>The status description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>In a session</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The project instance status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InUse</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The latest update time of the status. The time is in the ISO 8601 standard and includes a time zone offset. The format is YYYY-MM-DDTHH:mm:ss+HH:mm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-11T18:19:04+08:00</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of cloud application service instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
