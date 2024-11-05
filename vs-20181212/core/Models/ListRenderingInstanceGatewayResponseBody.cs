// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ListRenderingInstanceGatewayResponseBody : TeaModel {
        [NameInMap("GatewayConfigurationInfos")]
        [Validation(Required=false)]
        public List<ListRenderingInstanceGatewayResponseBodyGatewayConfigurationInfos> GatewayConfigurationInfos { get; set; }
        public class ListRenderingInstanceGatewayResponseBodyGatewayConfigurationInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-15 10:19:13</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>render-xxx</para>
            /// </summary>
            [NameInMap("GatewayInstanceId")]
            [Validation(Required=false)]
            public string GatewayInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>render-342012a227dc4ddf91f024639e43051a</para>
            /// </summary>
            [NameInMap("RenderingInstanceId")]
            [Validation(Required=false)]
            public string RenderingInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-11-02 12:08:26</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

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
        public string TotalCount { get; set; }

    }

}
