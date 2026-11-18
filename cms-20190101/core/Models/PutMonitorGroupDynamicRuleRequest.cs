// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutMonitorGroupDynamicRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6868E9A1-56E6-5FD7-9684-E2963BBAFB5F</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: sends a check request. No security group is associated with the instance. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the check fails, an error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. If the check succeeds, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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
            /// <para>The type of Alibaba Cloud service for the dynamic alert rule. Valid values of N: 1 to 3. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ecs: Elastic Compute Service server.</para>
            /// </description></item>
            /// <item><description><para>rds: relational database.</para>
            /// </description></item>
            /// <item><description><para>slb: load balancing.</para>
            /// </description></item>
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
            /// <para>The combination condition for dynamic matching rules. Valid values of N: 1 to 3. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>and: Only instances that meet all matching rules are automatically added to the application group.</para>
            /// </description></item>
            /// <item><description><para>or: Instances that meet any matching rule are automatically added to the application group.</para>
            /// </description></item>
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
                /// <para>The filter condition for instances. Valid values of N: 1 to 3. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>contains: Includes.</description></item>
                /// <item><description>notContains: Does not include.</description></item>
                /// <item><description>startWith: Prefix.</description></item>
                /// <item><description>endWith: Suffix.</description></item>
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
                /// <para>The field name for instance matching. Valid values of N: 1 to 3.</para>
                /// <para>Currently, only the hostname is supported, such as hostName.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hostName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value that meets the matching condition. Valid values of N: 1 to 3.</para>
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
        /// <para>The mode for creating the dynamic matching rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Asynchronous creation.</description></item>
        /// <item><description>false (default): Synchronous creation.</description></item>
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
