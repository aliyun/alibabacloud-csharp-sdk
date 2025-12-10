// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class QueryExperimentVisualizationDataRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<QueryExperimentVisualizationDataRequestBody> Body { get; set; }
        public class QueryExperimentVisualizationDataRequestBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-30T12:51:33.028Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node-2dfd8xfjda</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-30T12:51:33.028Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("VisualizationDataIds")]
            [Validation(Required=false)]
            public List<string> VisualizationDataIds { get; set; }

        }

    }

}
