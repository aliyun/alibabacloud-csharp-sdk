// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class ListClientRuleStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of policies.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListClientRuleStrategyResponseBodyList> List { get; set; }
        public class ListClientRuleStrategyResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The policy action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Monitor mode.</description></item>
            /// <item><description><b>1</b>: Block startup.</description></item>
            /// <item><description><b>2</b>: Block mode.</description></item>
            /// </list>
            /// <para>Valid values for custom rules of proactive defense (PolicyType=2):</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Allow.</description></item>
            /// <item><description><b>1</b>: Block.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public int? ActionType { get; set; }

            /// <summary>
            /// <para>Specifies whether the policy applies to all user groups. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No.</description></item>
            /// <item><description><b>1</b>: Yes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AllGroup")]
            [Validation(Required=false)]
            public int? AllGroup { get; set; }

            /// <summary>
            /// <para>The instance ID of the approval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>approval-3f9bcedb9643b956</para>
            /// </summary>
            [NameInMap("ApprovalId")]
            [Validation(Required=false)]
            public string ApprovalId { get; set; }

            /// <summary>
            /// <para>The timestamp when the policy was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792627200000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of usernames to which the policy does not apply.</para>
            /// </summary>
            [NameInMap("ExcludeUserNameList")]
            [Validation(Required=false)]
            public List<string> ExcludeUserNameList { get; set; }

            /// <summary>
            /// <para>The ID of the policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1938</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The switch for inbound network traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("InSwitch")]
            [Validation(Required=false)]
            public bool? InSwitch { get; set; }

            /// <summary>
            /// <para>The list of targets in the effective scope.</para>
            /// </summary>
            [NameInMap("IncludeGroupIdList")]
            [Validation(Required=false)]
            public List<string> IncludeGroupIdList { get; set; }

            /// <summary>
            /// <para>The text of the primary button in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MainButtonTextCh")]
            [Validation(Required=false)]
            public string MainButtonTextCh { get; set; }

            /// <summary>
            /// <para>The text of the primary button in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MainButtonTextEn")]
            [Validation(Required=false)]
            public string MainButtonTextEn { get; set; }

            /// <summary>
            /// <para>The effective scope mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: All user groups.</description></item>
            /// <item><description><b>UserGroupNormal</b>: Specified user groups.</description></item>
            /// <item><description><b>DeviceGroupNormal</b>: Specified device groups.</description></item>
            /// <item><description><b>DevTagNormal</b>: Specified device tags.</description></item>
            /// </list>
            /// <para>The meaning of MatchTargetIds is determined by this field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <para>The list of targets in the effective scope. UserGroupNormal corresponds to user group IDs, DeviceGroupNormal corresponds to device group IDs, and DevTagNormal corresponds to device tags. If MatchMode is set to UserGroupAll, you do not need to specify targets.</para>
            /// </summary>
            [NameInMap("MatchTargetIds")]
            [Validation(Required=false)]
            public List<string> MatchTargetIds { get; set; }

            /// <summary>
            /// <para>The text of the secondary button in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MinorButtonTextCh")]
            [Validation(Required=false)]
            public string MinorButtonTextCh { get; set; }

            /// <summary>
            /// <para>The text of the secondary button in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("MinorButtonTextEn")]
            [Validation(Required=false)]
            public string MinorButtonTextEn { get; set; }

            /// <summary>
            /// <para>The Policy Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The switch for outbound network traffic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OutSwitch")]
            [Validation(Required=false)]
            public bool? OutSwitch { get; set; }

            /// <summary>
            /// <para>The policy type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Software hardening.</description></item>
            /// <item><description><b>1</b>: Firewall.</description></item>
            /// <item><description><b>2</b>: Proactive defense.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public int? PolicyType { get; set; }

            /// <summary>
            /// <para>The list of enabled ports.</para>
            /// </summary>
            [NameInMap("PortOnList")]
            [Validation(Required=false)]
            public List<string> PortOnList { get; set; }

            /// <summary>
            /// <para>The policy priority. A smaller value indicates a higher priority. Valid values: greater than 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The association key of the policy configuration, which is used to associate the policy with its process or switch configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a8d64565-ab8b-41a6-bd3d-14d0fc639285</para>
            /// </summary>
            [NameInMap("SelectionKey")]
            [Validation(Required=false)]
            public string SelectionKey { get; set; }

            /// <summary>
            /// <para>The list of main process names of the software for which integrity check is enabled. The elements correspond to the Process field returned by GetSwitchInfoListByType.</para>
            /// </summary>
            [NameInMap("SoftWareOnList")]
            [Validation(Required=false)]
            public List<string> SoftWareOnList { get; set; }

            /// <summary>
            /// <para>The status of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The source of the rule for proactive defense (PolicyType=2). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SYSTEM</b>: System rule.</description></item>
            /// <item><description><b>CUSTOM</b>: Custom rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("StrategySourceType")]
            [Validation(Required=false)]
            public string StrategySourceType { get; set; }

            /// <summary>
            /// <para>Specifies whether reporting and approval are supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Not supported.</description></item>
            /// <item><description><b>1</b>: Supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportsApproval")]
            [Validation(Required=false)]
            public int? SupportsApproval { get; set; }

            /// <summary>
            /// <para>The content of the pop-up prompt in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UsContent")]
            [Validation(Required=false)]
            public string UsContent { get; set; }

            /// <summary>
            /// <para>The title of the pop-up prompt in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("UsTitle")]
            [Validation(Required=false)]
            public string UsTitle { get; set; }

            /// <summary>
            /// <para>The content of the pop-up prompt in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ZhContent")]
            [Validation(Required=false)]
            public string ZhContent { get; set; }

            /// <summary>
            /// <para>The title of the pop-up prompt in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ZhTitle")]
            [Validation(Required=false)]
            public string ZhTitle { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListClientRuleStrategyResponseBodyPageInfo PageInfo { get; set; }
        public class ListClientRuleStrategyResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number of the current page for the paged query with paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page for the paged query with paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45B2D3AF-0E5F-5D67-944C-2AD5E354B5C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
