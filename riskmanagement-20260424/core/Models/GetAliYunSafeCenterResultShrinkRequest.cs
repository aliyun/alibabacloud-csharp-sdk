// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAliYunSafeCenterResultShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Creates a node to query security alerting events triggered by the same rule or alerting type.</para>
        /// </summary>
        [NameInMap("CreateSimilarSecurityEventsQueryTaskRequest")]
        [Validation(Required=false)]
        public string CreateSimilarSecurityEventsQueryTaskRequestShrink { get; set; }

        /// <summary>
        /// <para>Queries the running status of ECS instances.</para>
        /// </summary>
        [NameInMap("DescribeInstancesFullStatusRequest")]
        [Validation(Required=false)]
        public string DescribeInstancesFullStatusRequestShrink { get; set; }

        /// <summary>
        /// <para>Queries whether the list of security alerting events that match the same IP rule or same alerting type as the alerting event to be handled is empty.</para>
        /// </summary>
        [NameInMap("DescribeSecurityEventOperationStatusRequest")]
        [Validation(Required=false)]
        public string DescribeSecurityEventOperationStatusRequestShrink { get; set; }

        /// <summary>
        /// <para>Queries identical security alert events in Security Center.</para>
        /// </summary>
        [NameInMap("DescribeSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public string DescribeSimilarSecurityEventsRequestShrink { get; set; }

        /// <summary>
        /// <para>The request parameters for querying the Security Center Agent status.</para>
        /// </summary>
        [NameInMap("GetAssetDetailByUuidRequest")]
        [Validation(Required=false)]
        public string GetAssetDetailByUuidRequestShrink { get; set; }

        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        [NameInMap("HandleSecurityEventsRequest")]
        [Validation(Required=false)]
        public string HandleSecurityEventsRequestShrink { get; set; }

        /// <summary>
        /// <para>Handles security alert events in batches based on the same IP rule or type.</para>
        /// </summary>
        [NameInMap("HandleSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public string HandleSimilarSecurityEventsRequestShrink { get; set; }

        /// <summary>
        /// <para>The code of the public API operation.</para>
        /// <list type="bullet">
        /// <item><description><para><b>GetAssetDetailByUuid</b>: Retrieves the Agent status. Request parameter: GetAssetDetailByUuidRequest.</para>
        /// </description></item>
        /// <item><description><para><b>DescribeSimilarSecurityEvents</b>: Retrieves the list of instance IDs for identical security alerting events. Request parameter: DescribeSimilarSecurityEventsRequest.</para>
        /// </description></item>
        /// <item><description><para><b>CreateSimilarSecurityEventsQueryTask</b>: Creates a node to query security alerting events triggered by the same rule or alerting type. Request parameter: CreateSimilarSecurityEventsQueryTaskRequest.</para>
        /// </description></item>
        /// <item><description><para><b>DescribeSecurityEventOperationStatus</b>: Queries whether the list of security alerting events that match the same IP rule or same alerting type as the alerting event to be handled is empty. Request parameter: DescribeSecurityEventOperationStatusRequest.</para>
        /// </description></item>
        /// <item><description><para><b>HandleSimilarSecurityEvents</b>: Handles security alerting events in batches based on the same IP rule or type. Request parameter: HandleSimilarSecurityEventsRequest.
        /// HandleSecurityEvents: Handles security alerting events. Request parameter: HandleSecurityEventsRequest.</para>
        /// </description></item>
        /// <item><description><para><b>DescribeInstancesFullStatus</b>: Queries the running status of ECS instances. Request parameter: DescribeInstancesFullStatusRequest.</para>
        /// </description></item>
        /// <item><description><para><b>ListInstances</b>: Queries the running status of simple application servers. Request parameter: ListInstancesRequest.</para>
        /// </description></item>
        /// <item><description><para><b>StartConfigRuleEvaluation</b>: Re-evaluates security check rules.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Each API operation name corresponds to its own request parameters.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ListInstanceStatus</para>
        /// </summary>
        [NameInMap("InterfaceCode")]
        [Validation(Required=false)]
        public string InterfaceCode { get; set; }

        /// <summary>
        /// <para>Queries the running status of simple application servers.</para>
        /// </summary>
        [NameInMap("ListInstancesRequest")]
        [Validation(Required=false)]
        public string ListInstancesRequestShrink { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-guangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
