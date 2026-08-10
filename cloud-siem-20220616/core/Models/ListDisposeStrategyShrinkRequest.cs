// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDisposeStrategyShrinkRequest : TeaModel {
        [NameInMap("AlertUuid")]
        [Validation(Required=false)]
        public string AlertUuid { get; set; }

        /// <summary>
        /// <para>The current page number of the list. The value must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The policy status. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EffectiveStatus")]
        [Validation(Required=false)]
        public int? EffectiveStatus { get; set; }

        /// <summary>
        /// <para>The query end time, in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The entity characteristic value. You can perform a fuzzy search on disposal entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test22.php</para>
        /// </summary>
        [NameInMap("EntityIdentity")]
        [Validation(Required=false)]
        public string EntityIdentity { get; set; }

        /// <summary>
        /// <para>The entity type. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("EntityUuidList")]
        [Validation(Required=false)]
        public string EntityUuidListShrink { get; set; }

        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        [NameInMap("GroupKey")]
        [Validation(Required=false)]
        public string GroupKey { get; set; }

        /// <summary>
        /// <para>The incident ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49670d3bbf7aa9556a2fff3dbaa9****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field used to sort the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtModified: sorts by update time</description></item>
        /// <item><description>GmtCreate: sorts by creation time</description></item>
        /// <item><description>FinishTime: sorts by policy end time</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModified</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

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
        /// <para>The unique identifier name of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WafBlockIP</para>
        /// </summary>
        [NameInMap("PlaybookName")]
        [Validation(Required=false)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// <para>The playbook type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: manual handling</description></item>
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
        /// <para>The playbook UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_aliyun_clb_process_book</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>The China (Hangzhou) region or China (Singapore) region where the China (Hangzhou) region or China (Singapore) region where the data management center of Cloud Threat Detection and Response (CTDR) resides. Specify the management center based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Chinese mainland and Hong Kong (China).</description></item>
        /// <item><description>ap-southeast-1: outside China.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResponseRuleId")]
        [Validation(Required=false)]
        public string ResponseRuleId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The SOAR disposal policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a50a49b7-6044-4593-ab15-2b46567c****</para>
        /// </summary>
        [NameInMap("SophonTaskId")]
        [Validation(Required=false)]
        public string SophonTaskId { get; set; }

        /// <summary>
        /// <para>The query start time, in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The disposal policy status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
