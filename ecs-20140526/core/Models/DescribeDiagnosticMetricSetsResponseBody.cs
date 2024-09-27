// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDiagnosticMetricSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>A collection of diagnostic metrics.</para>
        /// </summary>
        [NameInMap("MetricSets")]
        [Validation(Required=false)]
        public List<DescribeDiagnosticMetricSetsResponseBodyMetricSets> MetricSets { get; set; }
        public class DescribeDiagnosticMetricSetsResponseBodyMetricSets : TeaModel {
            /// <summary>
            /// <para>The description of the diagnostic metric set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connection issue diagnostics</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IDs of the diagnostic metrics.</para>
            /// </summary>
            [NameInMap("MetricIds")]
            [Validation(Required=false)]
            public List<string> MetricIds { get; set; }

            /// <summary>
            /// <para>The ID of the diagnostic metric set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dms-bp17p0qwtr72zmu*****</para>
            /// </summary>
            [NameInMap("MetricSetId")]
            [Validation(Required=false)]
            public string MetricSetId { get; set; }

            /// <summary>
            /// <para>The name of the diagnostic metric set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>connection issue diagnostics</para>
            /// </summary>
            [NameInMap("MetricSetName")]
            [Validation(Required=false)]
            public string MetricSetName { get; set; }

            /// <summary>
            /// <para>The resource type supported by the diagnostic metric set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The type of the diagnostic metric set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>User: user-defined diagnostic metric set</description></item>
            /// <item><description>Common: common diagnostic metric set</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>User</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The query token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
