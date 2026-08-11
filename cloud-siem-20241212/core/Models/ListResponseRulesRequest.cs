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
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of data records to read in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that marks the current reading position. Leave this parameter empty to read from the beginning.</para>
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
        /// <para>The region where the threat analysis data management center resides. Select the management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets belong to the Chinese mainland or Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: Your assets belong to regions outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The action type of the automatic response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>doPlaybook: execute a playbook</description></item>
        /// <item><description>changeEventStatus: update event status</description></item>
        /// <item><description>changeThreatLevel: update event threat level</description></item>
        /// <item><description>addEventTag: add an event label</description></item>
        /// <item><description>deleteEventTag: delete an event label</description></item>
        /// <item><description>alertWhitelist: add alert to whitelist</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>doPlaybook</para>
        /// </summary>
        [NameInMap("ResponseActionType")]
        [Validation(Required=false)]
        public string ResponseActionType { get; set; }

        /// <summary>
        /// <para>The name of the automatic response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Send Notification When Generating Urgent Incident</para>
        /// </summary>
        [NameInMap("ResponseRuleName")]
        [Validation(Required=false)]
        public string ResponseRuleName { get; set; }

        /// <summary>
        /// <para>The status of the automatic response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disabled</description></item>
        /// <item><description>100: enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ResponseRuleStatus")]
        [Validation(Required=false)]
        public int? ResponseRuleStatus { get; set; }

        /// <summary>
        /// <para>The type of the response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>preset: predefined</description></item>
        /// <item><description>custom: custom</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ResponseRuleType")]
        [Validation(Required=false)]
        public string ResponseRuleType { get; set; }

        /// <summary>
        /// <para>The trigger type of the automatic response rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>event: event occurred</description></item>
        /// <item><description>event_update: event updated</description></item>
        /// <item><description>alert: alert occurred</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("ResponseTriggerType")]
        [Validation(Required=false)]
        public string ResponseTriggerType { get; set; }

        /// <summary>
        /// <para>The user ID that the administrator switches to when viewing from another member\&quot;s perspective.</para>
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
        /// <item><description>0: the current Alibaba Cloud account view.</description></item>
        /// <item><description>1: the view of all accounts in the enterprise.</description></item>
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
