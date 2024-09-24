// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMonitorGroupDynamicRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>None.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GroupRules")]
        [Validation(Required=false)]
        public List<PutMonitorGroupDynamicRuleRequestGroupRules> GroupRules { get; set; }
        public class PutMonitorGroupDynamicRuleRequestGroupRules : TeaModel {
            /// <summary>
            /// <para>The cloud service to which the alert rule is applied. Valid values of N: 1 to 3. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ecs: Elastic Compute Service (ECS)</description></item>
            /// <item><description>rds: ApsaraDB RDS</description></item>
            /// <item><description>slb: Server Load Balancer (SLB)</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The logical operator used between conditional expressions in the alert rule. Valid values of N: 1 to 3. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>and: The instances that meet all the conditional expressions are automatically added to the application group.</description></item>
            /// <item><description>or: The instances that meet one of the conditional expressions are automatically added to the application group.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>and</para>
            /// </summary>
            [NameInMap("FilterRelation")]
            [Validation(Required=false)]
            public string FilterRelation { get; set; }

            /// <summary>
            /// <para>None.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public List<PutMonitorGroupDynamicRuleRequestGroupRulesFilters> Filters { get; set; }
            public class PutMonitorGroupDynamicRuleRequestGroupRulesFilters : TeaModel {
                /// <summary>
                /// <para>The method that is used to filter instances. Valid values of N: 1 to 3. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>contains: contains</description></item>
                /// <item><description>notContains: does not contain</description></item>
                /// <item><description>startWith: starts with a prefix</description></item>
                /// <item><description>endWith: ends with a suffix</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>contains</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The name of the field based on which instances are filtered. Valid values of N: 1 to 3.</para>
                /// <para>Only hostnames are supported. Example: hostName.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hostName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value to be matched with the specified field. Valid values of N: 1 to 3.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nginx</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The mode for creating the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: creates asynchronously</description></item>
        /// <item><description>false (default): creates synchronously</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsAsync")]
        [Validation(Required=false)]
        public bool? IsAsync { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
