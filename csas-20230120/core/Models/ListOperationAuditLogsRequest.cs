// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListOperationAuditLogsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page for a paged query. Pages start from 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds. The value must be later than StartTime.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787550343</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The source type of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>console</b>: The event is triggered by a console call.</description></item>
        /// <item><description><b>sdk</b>: The event is triggered by an SDK call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The operation feature module. The value must be the English code of the feature module. If you specify other values, no records are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrivateAccess</b>: internal network access</description></item>
        /// <item><description><b>OfficeNetworkAccess</b>: office network access</description></item>
        /// <item><description><b>AppAcceleration</b>: application acceleration</description></item>
        /// <item><description><b>InternetAccess</b>: Internet access</description></item>
        /// <item><description><b>OfficeDataProtection</b>: office data protection</description></item>
        /// <item><description><b>IdentityAccessManagement</b>: identity and access management</description></item>
        /// <item><description><b>DeviceManagement</b>: endpoint management</description></item>
        /// <item><description><b>ApprovalCenter</b>: approval center</description></item>
        /// <item><description><b>SoftwareManagement</b>: software management</description></item>
        /// <item><description><b>LogAnalysis</b>: log analysis</description></item>
        /// <item><description><b>Setting</b>: settings</description></item>
        /// <item><description><b>DigitalWatermark</b>: digital watermarking</description></item>
        /// <item><description><b>DynamicDecision</b>: dynamic decision-making</description></item>
        /// <item><description><b>InternetBehaviorManagement</b>: Internet behavior management</description></item>
        /// <item><description><b>AgentOfficeSecurity</b>: agent office security</description></item>
        /// <item><description><b>NetworkAccess</b>: network access</description></item>
        /// <item><description><b>RiskManagement</b>: risk management</description></item>
        /// <item><description><b>EndpointProtection</b>: endpoint protection</description></item>
        /// <item><description><b>Overview</b>: overview page</description></item>
        /// <item><description><b>ITManagement</b>: IT management</description></item>
        /// <item><description><b>InstanceManagement</b>: instance management</description></item>
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
        /// <item><description><b>success</b>: The operation is successful. Equivalent values are true and Success.</description></item>
        /// <item><description><b>failure</b>: The operation fails. Equivalent values are fail, failed, false, and Failure.</description></item>
        /// </list>
        /// <para>If this parameter is not specified, only records of successful operations are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("OperationStatus")]
        [Validation(Required=false)]
        public string OperationStatus { get; set; }

        /// <summary>
        /// <para>The operation type. The value must be exactly the same as the original operation type recorded in the log. The OperationType in the returned result is localized based on the request language and may differ from this filter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Synchronize classification and grading rules</para>
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
        /// <para>The number of entries to return on each page for a paged query. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds. The value must be earlier than EndTime. The interval between StartTime and EndTime cannot exceed 30 days, and StartTime cannot be more than 31 days before the current time.</para>
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
