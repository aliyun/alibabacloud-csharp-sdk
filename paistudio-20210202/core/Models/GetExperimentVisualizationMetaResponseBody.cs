// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetExperimentVisualizationMetaResponseBody : TeaModel {
        [NameInMap("VisualizationMeta")]
        [Validation(Required=false)]
        public List<GetExperimentVisualizationMetaResponseBodyVisualizationMeta> VisualizationMeta { get; set; }
        public class GetExperimentVisualizationMetaResponseBodyVisualizationMeta : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;locations&quot;: [{
            ///         &quot;id&quot;: &quot;result_table&quot;,
            ///         &quot;location&quot;: {
            ///             &quot;project&quot;: &quot;mulan_test_pre_1&quot;,
            ///             &quot;endpoint&quot;: &quot;<a href="http://service.cn.maxcompute.aliyun-inc.com/api">http://service.cn.maxcompute.aliyun-inc.com/api</a>&quot;,
            ///             &quot;table&quot;: &quot;pai_temp_flow_qzkkjqic95olnrel1w_node_7hc1rdsa99gy2msbvc_visualizationTable&quot;
            ///         },
            ///         &quot;locationType&quot;: &quot;MaxComputeTable&quot;
            ///     }],
            ///     &quot;components&quot;: [{
            ///         &quot;id&quot;: &quot;histogram-chart&quot;,
            ///         &quot;dataId&quot;: &quot;histogram_result&quot;
            ///     }],
            ///     &quot;dataInfos&quot;: [{
            ///         &quot;id&quot;: &quot;histogram_result&quot;,
            ///         &quot;locationId&quot;: &quot;result_table&quot;,
            ///         &quot;dataType&quot;: &quot;json&quot;
            ///     }]
            /// }</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_id1</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A84A1282-D3E7-5198-9E8E-2AD09C78C6C1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
