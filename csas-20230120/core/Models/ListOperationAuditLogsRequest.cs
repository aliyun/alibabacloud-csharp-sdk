// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListOperationAuditLogsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in paging. The value starts from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query. This value is a UNIX timestamp in seconds. The value must be later than StartTime.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787550343</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>console</b>: console call.</description></item>
        /// <item><description><b>sdk</b>: SDK call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The operation function module. The value is the English code of the function module. If other values are specified, no records are returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrivateAccess</b>: private access.</description></item>
        /// <item><description><b>OfficeNetworkAccess</b>: office network access.</description></item>
        /// <item><description><b>AppAcceleration</b>: application acceleration.</description></item>
        /// <item><description><b>InternetAccess</b>: Internet access.</description></item>
        /// <item><description><b>OfficeDataProtection</b>: office data protection.</description></item>
        /// <item><description><b>IdentityAccessManagement</b>: identity and access management.</description></item>
        /// <item><description><b>DeviceManagement</b>: device management.</description></item>
        /// <item><description><b>ApprovalCenter</b>: approval center.</description></item>
        /// <item><description><b>SoftwareManagement</b>: software management.</description></item>
        /// <item><description><b>LogAnalysis</b>: log analysis.</description></item>
        /// <item><description><b>Setting</b>: settings.</description></item>
        /// <item><description><b>DigitalWatermark</b>: digital watermarking.</description></item>
        /// <item><description><b>DynamicDecision</b>: dynamic decision.</description></item>
        /// <item><description><b>InternetBehaviorManagement</b>: Internet behavior management.</description></item>
        /// <item><description><b>AgentOfficeSecurity</b>: Agent office security.</description></item>
        /// <item><description><b>NetworkAccess</b>: network access.</description></item>
        /// <item><description><b>RiskManagement</b>: risk management.</description></item>
        /// <item><description><b>EndpointProtection</b>: endpoint protection.</description></item>
        /// <item><description><b>Overview</b>: overview page.</description></item>
        /// <item><description><b>ITManagement</b>: IT management.</description></item>
        /// <item><description><b>InstanceManagement</b>: instance management.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OfficeDataProtection</para>
        /// </summary>
        [NameInMap("OperationFunc")]
        [Validation(Required=false)]
        public string OperationFunc { get; set; }

        /// <summary>
        /// <para>The operation status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: The operation succeeded. Equivalent values: true, 成功.</description></item>
        /// <item><description><b>failure</b>: The operation failed. Equivalent values: fail, failed, false, 失败.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, only successful operation records are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("OperationStatus")]
        [Validation(Required=false)]
        public string OperationStatus { get; set; }

        /// <summary>
        /// <para>The operation type. The value must exactly match the original operation type recorded in the log. The OperationType value in the response is localized based on the request language and may differ from this filter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sync classification rules</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID (AliUid) of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234****</para>
        /// </summary>
        [NameInMap("OperatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Settings: 1 to 100. Used in paging.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query. This value is a UNIX timestamp in seconds. The value must be earlier than EndTime. The interval between StartTime and EndTime cannot exceed 30 days, and StartTime cannot be more than 31 days before the current time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1786945543</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
