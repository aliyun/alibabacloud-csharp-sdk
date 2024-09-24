// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupDynamicRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The responses code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2170B94A-1576-4D65-900E-2093037CDAF3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources that are associated with the application group.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public DescribeMonitorGroupDynamicRulesResponseBodyResource Resource { get; set; }
        public class DescribeMonitorGroupDynamicRulesResponseBodyResource : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupDynamicRulesResponseBodyResourceResource> Resource { get; set; }
            public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResource : TeaModel {
                /// <summary>
                /// <para>The type of the cloud service to which the dynamic rule belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ecs: Elastic Compute Service (ECS)</description></item>
                /// <item><description>rds: ApsaraDB RDS</description></item>
                /// <item><description>slb: Server Load Balancer (SLB)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The filter condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>and: queries the instances that meet all alert rules.</description></item>
                /// <item><description>or: queries the instances that meet any alert rule.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>and</para>
                /// </summary>
                [NameInMap("FilterRelation")]
                [Validation(Required=false)]
                public string FilterRelation { get; set; }

                /// <summary>
                /// <para>The dynamic rules of the application group.</para>
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFilters Filters { get; set; }
                public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFilters : TeaModel {
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFiltersFilter> Filter { get; set; }
                    public class DescribeMonitorGroupDynamicRulesResponseBodyResourceResourceFiltersFilter : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to filter the instances. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>contains: contains</description></item>
                        /// <item><description>startWith: starts with a prefix</description></item>
                        /// <item><description>endWith: ends with a suffix</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>contains</para>
                        /// </summary>
                        [NameInMap("Function")]
                        [Validation(Required=false)]
                        public string Function { get; set; }

                        /// <summary>
                        /// <para>The instance name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>hostName</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The value of the dynamic rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
