// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingInstanceGatewayResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of custom gateway information.</para>
        /// </summary>
        [NameInMap("GatewayConfigurationInfos")]
        [Validation(Required=false)]
        public List<ListRenderingInstanceGatewayResponseBodyGatewayConfigurationInfos> GatewayConfigurationInfos { get; set; }
        public class ListRenderingInstanceGatewayResponseBodyGatewayConfigurationInfos : TeaModel {
            /// <summary>
            /// <para>The time when the cloud application service instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-15 10:19:13</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the custom gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-xxx</para>
            /// </summary>
            [NameInMap("GatewayInstanceId")]
            [Validation(Required=false)]
            public string GatewayInstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the cloud application service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>render-342012a227dc4ddf91f024639e43051a</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <para>The status of the custom gateway. Valid values:</para>
            /// <ol>
            /// <item><description><para>Transitional states: creating, deleting</para>
            /// </description></item>
            /// <item><description><para>Desired states: available, failed</para>
            /// </description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the information was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-02 12:08:26</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The page number of the query results list</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
