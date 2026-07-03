// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDisposeStrategyRequest : TeaModel {
        /// <summary>
        /// <para>Current page number. Must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Strategy status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: disabled</para>
        /// </description></item>
        /// <item><description><para>1: enabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EffectiveStatus")]
        [Validation(Required=false)]
        public int? EffectiveStatus { get; set; }

        /// <summary>
        /// <para>End time of the query, in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Entity feature value. Use this to perform a fuzzy search on entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test22.php</para>
        /// </summary>
        [NameInMap("EntityIdentity")]
        [Validation(Required=false)]
        public string EntityIdentity { get; set; }

        /// <summary>
        /// <para>Entity type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ip</para>
        /// </description></item>
        /// <item><description><para>process</para>
        /// </description></item>
        /// <item><description><para>file</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>Event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49670d3bbf7aa9556a2fff3dbaa9****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>Sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>desc: descending</para>
        /// </description></item>
        /// <item><description><para>asc: ascending</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>Sort field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtModified: sort by last modified time</para>
        /// </description></item>
        /// <item><description><para>GmtCreate: sort by creation time</para>
        /// </description></item>
        /// <item><description><para>FinishTime: sort by strategy end time</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModified</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>Number of entries per page. Maximum value is 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Unique name of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WafBlockIP</para>
        /// </summary>
        [NameInMap("PlaybookName")]
        [Validation(Required=false)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// <para>Playbook type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>system: manual disposal</para>
        /// </description></item>
        /// <item><description><para>custom: event-triggered playbook</para>
        /// </description></item>
        /// <item><description><para>custom_alert: alert-triggered playbook</para>
        /// </description></item>
        /// <item><description><para>soar-manual: manually run playbook</para>
        /// </description></item>
        /// <item><description><para>soar-mdr: MDR-run playbook</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("PlaybookTypes")]
        [Validation(Required=false)]
        public string PlaybookTypes { get; set; }

        /// <summary>
        /// <para>UUID of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_aliyun_clb_process_book</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>Location of the Data Management center for Threat Analysis and Response. Select the location based on where your assets are deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: assets in the Chinese mainland or Hong Kong (China)</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: assets outside China</para>
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
        /// <para>Alibaba Cloud account ID when an administrator switches to another member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>View type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: view for the current Alibaba Cloud account</para>
        /// </description></item>
        /// <item><description><para>1: view for all accounts under the enterprise</para>
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
        /// <para>ID of the security orchestration and automated response disposal strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a50a49b7-6044-4593-ab15-2b46567c****</para>
        /// </summary>
        [NameInMap("SophonTaskId")]
        [Validation(Required=false)]
        public string SophonTaskId { get; set; }

        /// <summary>
        /// <para>Start time of the query, in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Disposal strategy status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
