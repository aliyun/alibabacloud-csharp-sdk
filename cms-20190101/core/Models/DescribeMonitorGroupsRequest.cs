// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the dynamic rule matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b882d9a-5117-42e2-9d0c-4749a0c6****</para>
        /// </summary>
        [NameInMap("DynamicTagRuleId")]
        [Validation(Required=false)]
        public string DynamicTagRuleId { get; set; }

        /// <summary>
        /// <para>The tag key used to create the application group by using dynamic rule matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GroupKey1</para>
        /// </summary>
        [NameInMap("GroupFounderTagKey")]
        [Validation(Required=false)]
        public string GroupFounderTagKey { get; set; }

        /// <summary>
        /// <para>The tag value used to create the application group by using dynamic rule matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GroupValue1</para>
        /// </summary>
        [NameInMap("GroupFounderTagValue")]
        [Validation(Required=false)]
        public string GroupFounderTagValue { get; set; }

        /// <summary>
        /// <para>The application group ID. Separate multiple application group IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>92****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The application group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testGroup124</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the history of alert templates that have been applied to the application group in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Include the history.</description></item>
        /// <item><description>false: Do not include the history.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeTemplateHistory")]
        [Validation(Required=false)]
        public bool? IncludeTemplateHistory { get; set; }

        /// <summary>
        /// <para>The resource instance ID. This parameter is used to query the application group to which the specified instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-abcdefgh12****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Minimum value: 1. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to include alert contact groups in the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Include alert contact groups.</description></item>
        /// <item><description>false: Do not include alert contact groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SelectContactGroups")]
        [Validation(Required=false)]
        public bool? SelectContactGroups { get; set; }

        /// <summary>
        /// <para>The tags of the application group.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeMonitorGroupsRequestTag> Tag { get; set; }
        public class DescribeMonitorGroupsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the application group. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagKey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the application group. Valid values of N: 1 to 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagValue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the application group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>custom: a custom application group.</description></item>
        /// <item><description>ehpc_cluster: an application group synchronized from an EHPC cluster.</description></item>
        /// <item><description>kubernetes: an application group synchronized from Container Service for Kubernetes.</description></item>
        /// <item><description>tag: an application group automatically created by using tags.</description></item>
        /// <item><description>resMgr: an application group created from a resource group.</description></item>
        /// <item><description>ess: an application group synchronized from Auto Scaling (ESS).</description></item>
        /// <item><description>aone_group: an application group synchronized from or associated with an Aone application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The type of the application group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>custom: a custom application group.</description></item>
        /// <item><description>ehpc_cluster: an application group synchronized from an EHPC cluster.</description></item>
        /// <item><description>kubernetes: an application group synchronized from Container Service for Kubernetes.</description></item>
        /// <item><description>tag: an application group automatically created by using tags.</description></item>
        /// <item><description>resMgr: an application group created from a resource group.</description></item>
        /// <item><description>ess: an application group synchronized from Auto Scaling (ESS).</description></item>
        /// <item><description>aone_group: an application group synchronized from or associated with an Aone application.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
