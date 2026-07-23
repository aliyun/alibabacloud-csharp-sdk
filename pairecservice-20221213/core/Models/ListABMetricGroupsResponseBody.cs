// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListABMetricGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The A/B metric groups.</para>
        /// </summary>
        [NameInMap("ABMetricGroups")]
        [Validation(Required=false)]
        public List<ListABMetricGroupsResponseBodyABMetricGroups> ABMetricGroups { get; set; }
        public class ListABMetricGroupsResponseBodyABMetricGroups : TeaModel {
            /// <summary>
            /// <para>The A/B metric group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ABMetricGroupId")]
            [Validation(Required=false)]
            public string ABMetricGroupId { get; set; }

            /// <summary>
            /// <para>The comma-separated IDs of the A/B metrics in the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2</para>
            /// </summary>
            [NameInMap("ABMetricIds")]
            [Validation(Required=false)]
            public string ABMetricIds { get; set; }

            /// <summary>
            /// <para>The comma-separated names of the A/B metrics in the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pv,uv</para>
            /// </summary>
            [NameInMap("ABMetricNames")]
            [Validation(Required=false)]
            public string ABMetricNames { get; set; }

            /// <summary>
            /// <para>The description of the A/B metric group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>访问量相关指标</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The A/B metric group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>visits</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2799614***</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>Indicates whether the A/B metric group is a real-time group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Realtime")]
            [Validation(Required=false)]
            public bool? Realtime { get; set; }

            /// <summary>
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E15A1443-7917-5BE0-AE70-25538ECF398D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of A/B metric groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
