// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDisposeStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the alert.</para>
        /// </summary>
        [NameInMap("AlertUuid")]
        [Validation(Required=false)]
        public string AlertUuid { get; set; }

        /// <summary>
        /// <para>The number of the current page. The value must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The status of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: invalid</description></item>
        /// <item><description>1: valid</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EffectiveStatus")]
        [Validation(Required=false)]
        public int? EffectiveStatus { get; set; }

        /// <summary>
        /// <para>The end time of the query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The identity value of the entity. You can use this parameter to perform a fuzzy search for response entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test22.php</para>
        /// </summary>
        [NameInMap("EntityIdentity")]
        [Validation(Required=false)]
        public string EntityIdentity { get; set; }

        /// <summary>
        /// <para>The type of the entity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ip: IP address</description></item>
        /// <item><description>process: process</description></item>
        /// <item><description>file: file</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The list of entity UUIDs.</para>
        /// </summary>
        [NameInMap("EntityUuidList")]
        [Validation(Required=false)]
        public List<string> EntityUuidList { get; set; }

        /// <summary>
        /// <para>The grouping dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Incident</para>
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        /// <summary>
        /// <para>The grouping key value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("GroupKey")]
        [Validation(Required=false)]
        public string GroupKey { get; set; }

        /// <summary>
        /// <para>The ID of the incident.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49670d3bbf7aa9556a2fff3dbaa9****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in a single query.</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to query the next page.</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order</description></item>
        /// <item><description>asc: ascending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModified: sort by update time</description></item>
        /// <item><description>GmtCreate: sort by creation time</description></item>
        /// <item><description>FinishTime: sort by policy end time</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModified</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique name of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WafBlockIP</para>
        /// </summary>
        [NameInMap("PlaybookName")]
        [Validation(Required=false)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// <para>The type of the playbook. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: manual response</description></item>
        /// <item><description>custom: event-triggered playbook</description></item>
        /// <item><description>custom_alert: alert-triggered playbook</description></item>
        /// <item><description>soar-manual: manually run playbook</description></item>
        /// <item><description>soar-mdr: MDR-run playbook</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("PlaybookTypes")]
        [Validation(Required=false)]
        public string PlaybookTypes { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_aliyun_clb_process_book</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The query mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Group</para>
        /// </summary>
        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Cloud Threat Detection and Response (CTDR) is located. You must select the region of the management center based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: assets reside in the Chinese mainland and Hong Kong (China)</description></item>
        /// <item><description>ap-southeast-1: assets reside in regions outside China</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the response rule.</para>
        /// </summary>
        [NameInMap("ResponseRuleId")]
        [Validation(Required=false)]
        public string ResponseRuleId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: view of the current Alibaba Cloud account</description></item>
        /// <item><description>1: view of all accounts in the enterprise</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The ID of the Security Orchestration, Automation, and Response (SOAR) response policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a50a49b7-6044-4593-ab15-2b46567c****</para>
        /// </summary>
        [NameInMap("SophonTaskId")]
        [Validation(Required=false)]
        public string SophonTaskId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the response policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The ID of the response policy.</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
