// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class QueryMetricMetaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0CCE0AF0-053C-4B13-A583-DC9A85785D49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public QueryMetricMetaResponseBodyResources Resources { get; set; }
        public class QueryMetricMetaResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<QueryMetricMetaResponseBodyResourcesResource> Resource { get; set; }
            public class QueryMetricMetaResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ECS.CPUUtilization</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>instanceId</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;name\&quot;:\&quot;alertUnit\&quot;,\&quot;value\&quot;:\&quot;%\&quot;},{\&quot;name\&quot;:\&quot;alertDefault\&quot;,\&quot;value\&quot;:\&quot;80\&quot;},{\&quot;name\&quot;:\&quot;minAlertPeriod\&quot;,\&quot;value\&quot;:\&quot;60\&quot;},{\&quot;name\&quot;:\&quot;metricCategory\&quot;,\&quot;value\&quot;:\&quot;instanceId\&quot;},{\&quot;name\&quot;:\&quot;is_alarm\&quot;,\&quot;value\&quot;:\&quot;true\&quot;}]&quot;</para>
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CPUUtilization</para>
                /// </summary>
                [NameInMap("Metric")]
                [Validation(Required=false)]
                public string Metric { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60,300</para>
                /// </summary>
                [NameInMap("Periods")]
                [Validation(Required=false)]
                public string Periods { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs_ecs_dashboard</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Average,Minimum,Maximum</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>%</para>
                /// </summary>
                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
