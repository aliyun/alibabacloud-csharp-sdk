// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAutomateResponseConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the handling action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>doPlaybook</b>: executes a playbook.</para>
        /// </description></item>
        /// <item><description><para><b>changeEventStatus</b>: changes the status of an event.</para>
        /// </description></item>
        /// <item><description><para><b>changeThreatLevel</b>: changes the threat level of an event.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>doPlaybook</para>
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        /// <summary>
        /// <para>The type of the automated response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>event</b></para>
        /// </description></item>
        /// <item><description><para><b>alert</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("AutoResponseType")]
        [Validation(Required=false)]
        public string AutoResponseType { get; set; }

        /// <summary>
        /// <para>The page number. The value must be 1 or greater.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the automated response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The maximum value is 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_aliyun_aegis_kill_quara_book</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The region of the Data Management center. Select a region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: your assets are in a region outside China.</para>
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
        /// <para>The type of the response rule.</para>
        /// <list type="bullet">
        /// <item><description><para>preset: predefined</para>
        /// </description></item>
        /// <item><description><para>custom: custom</para>
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
        /// <para>The ID of the member to which the administrator switches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: the view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: the view of all accounts that belong to the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The name of the automated response rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw kill quara book</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: disabled</para>
        /// </description></item>
        /// <item><description><para><b>100</b>: enabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17108579417****</para>
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public long? SubUserId { get; set; }

    }

}
