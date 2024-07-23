// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListABMetricsResponseBody : TeaModel {
        [NameInMap("ABMetrics")]
        [Validation(Required=false)]
        public List<ListABMetricsResponseBodyABMetrics> ABMetrics { get; set; }
        public class ListABMetricsResponseBodyABMetrics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ABMetricId")]
            [Validation(Required=false)]
            public string ABMetricId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sum(click_cnt)</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LeftMetricId")]
            [Validation(Required=false)]
            public string LeftMetricId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pv</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Division</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Realtime")]
            [Validation(Required=false)]
            public string Realtime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ResultResourceId")]
            [Validation(Required=false)]
            public string ResultResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResultTableMetaId")]
            [Validation(Required=false)]
            public string ResultTableMetaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RightMetricId")]
            [Validation(Required=false)]
            public string RightMetricId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>home_feed</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("StatisticsCycle")]
            [Validation(Required=false)]
            public int? StatisticsCycle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TableMetaId")]
            [Validation(Required=false)]
            public string TableMetaId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Single</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F7AC05FF-EDE7-5C2B-B9AE-33D6DF4178BA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
