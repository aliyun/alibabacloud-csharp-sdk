// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListResponseRulesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. If you leave this parameter empty, the first page of results is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAASLVeIxed4466E0LVmGkzwS6hJKd9DGVGMDRM6Lu****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region of the data management center for threat analysis. Select the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cn-hangzhou</c>: Your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para><c>ap-southeast-1</c>: Your assets are in international regions.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The action of the automated response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>doPlaybook</c>: Executes a playbook.</para>
        /// </description></item>
        /// <item><description><para><c>changeEventStatus</c>: Updates the status of an event.</para>
        /// </description></item>
        /// <item><description><para><c>changeThreatLevel</c>: Updates the threat level of an event.</para>
        /// </description></item>
        /// <item><description><para><c>addEventTag</c>: Adds a tag to an event.</para>
        /// </description></item>
        /// <item><description><para><c>deleteEventTag</c>: Removes a tag from an event.</para>
        /// </description></item>
        /// <item><description><para><c>alertWhitelist</c>: Adds an alert to the allowlist.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>doPlaybook</para>
        /// </summary>
        [NameInMap("ResponseActionType")]
        [Validation(Required=false)]
        public string ResponseActionType { get; set; }

        /// <summary>
        /// <para>The name of the automated response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Send Notification When Generating Urgent Incident</para>
        /// </summary>
        [NameInMap("ResponseRuleName")]
        [Validation(Required=false)]
        public string ResponseRuleName { get; set; }

        /// <summary>
        /// <para>The status of the automated response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: disabled</para>
        /// </description></item>
        /// <item><description><para><c>100</c>: enabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ResponseRuleStatus")]
        [Validation(Required=false)]
        public int? ResponseRuleStatus { get; set; }

        /// <summary>
        /// <para>The type of the automated response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>preset</c>: A preset rule.</para>
        /// </description></item>
        /// <item><description><para><c>custom</c>: A custom rule.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ResponseRuleType")]
        [Validation(Required=false)]
        public string ResponseRuleType { get; set; }

        /// <summary>
        /// <para>The trigger type of the automated response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>event</c>: An event is generated.</para>
        /// </description></item>
        /// <item><description><para><c>event_update</c>: An event is updated.</para>
        /// </description></item>
        /// <item><description><para><c>alert</c>: An alert is generated.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("ResponseTriggerType")]
        [Validation(Required=false)]
        public string ResponseTriggerType { get; set; }

        /// <summary>
        /// <para>The ID of a member. An administrator can use this parameter to view data as the specified member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>173326*******</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: Displays data from the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: Displays data from all accounts in the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
