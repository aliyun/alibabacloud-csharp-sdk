// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class QueryExperimentVisualizationDataResponseBody : TeaModel {
        [NameInMap("VisualizationData")]
        [Validation(Required=false)]
        public List<QueryExperimentVisualizationDataResponseBodyVisualizationData> VisualizationData { get; set; }
        public class QueryExperimentVisualizationDataResponseBodyVisualizationData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-30T12:51:33.028Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1,2,3,4,5</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dataId1</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node-ux55ier8axzo2xelcc</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFB1D4B4-B253-540A-9B3B-AA711C48A1B7</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
