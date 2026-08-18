// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetAliYunSafeCenterResultRequest : TeaModel {
        /// <summary>
        /// <para>Creates a node to query security alerting events triggered by the same rule or alerting type.</para>
        /// </summary>
        [NameInMap("CreateSimilarSecurityEventsQueryTaskRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestCreateSimilarSecurityEventsQueryTaskRequest CreateSimilarSecurityEventsQueryTaskRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestCreateSimilarSecurityEventsQueryTaskRequest : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the security alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>629755508</para>
            /// </summary>
            [NameInMap("SecurityEventId")]
            [Validation(Required=false)]
            public long? SecurityEventId { get; set; }

            /// <summary>
            /// <para>The code of the alerting event that has the same type or rule hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SimilarEventScenarioCode")]
            [Validation(Required=false)]
            public string SimilarEventScenarioCode { get; set; }

        }

        /// <summary>
        /// <para>Queries the running status of ECS instances.</para>
        /// </summary>
        [NameInMap("DescribeInstancesFullStatusRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestDescribeInstancesFullStatusRequest DescribeInstancesFullStatusRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestDescribeInstancesFullStatusRequest : TeaModel {
            /// <summary>
            /// <para>The list of instance IDs.</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>Queries whether the list of security alerting events that match the same IP rule or same alerting type as the alerting event to be handled is empty.</para>
        /// </summary>
        [NameInMap("DescribeSecurityEventOperationStatusRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestDescribeSecurityEventOperationStatusRequest DescribeSecurityEventOperationStatusRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestDescribeSecurityEventOperationStatusRequest : TeaModel {
            /// <summary>
            /// <para>The region ID. Example: ap-southeast-1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of security alert event IDs.</para>
            /// <remarks>
            /// <para>You must specify either TaskId or SecurityEventIds.N. At least one of these parameters is required for a successful call.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public List<string> SecurityEventIds { get; set; }

            /// <summary>
            /// <para>The ID of the task for handling security alert events.</para>
            /// <remarks>
            /// <para>You must specify either TaskId or SecurityEventIds. At least one of these parameters is required for a successful call.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0BC3B4E600002A9F000048BCDCE7E710</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>Queries identical security alert events in Security Center.</para>
        /// </summary>
        [NameInMap("DescribeSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestDescribeSimilarSecurityEventsRequest DescribeSimilarSecurityEventsRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestDescribeSimilarSecurityEventsRequest : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the query task. You can call the CreateSimilarSecurityEventsQueryTask operation to obtain this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1689135</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <para>The request parameters for querying the Security Center Agent status.</para>
        /// </summary>
        [NameInMap("GetAssetDetailByUuidRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestGetAssetDetailByUuidRequest GetAssetDetailByUuidRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestGetAssetDetailByUuidRequest : TeaModel {
            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The UUID of the asset to query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9A75F21D3993C0A2B094A4AB132890B2</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>Handles security alert events.</para>
        /// </summary>
        [NameInMap("HandleSecurityEventsRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestHandleSecurityEventsRequest HandleSecurityEventsRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestHandleSecurityEventsRequest : TeaModel {
            /// <summary>
            /// <para>The alert rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fbbb90731fbb6df57c933173182d01a5</para>
            /// </summary>
            [NameInMap("FileMd5")]
            [Validation(Required=false)]
            public string FileMd5 { get; set; }

            /// <summary>
            /// <para>The path of the sensitive file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flyfish-lfp-wy.release</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-shared-vpc-002</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The user IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.56.127.180</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Specifies whether to add to the whitelist in batches.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MarkBatch")]
            [Validation(Required=false)]
            public string MarkBatch { get; set; }

            /// <summary>
            /// <para>The whitelist rule configuration. The value is in JSON format and contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>field</b>: The whitelist field.</description></item>
            /// <item><description><b>operate</b>: The whitelist method. Valid values:<list type="bullet">
            /// <item><description><b>notContains</b>: Does not contain.</description></item>
            /// <item><description><b>contains</b>: Contains.</description></item>
            /// <item><description><b>regex</b>: Regular expression match.</description></item>
            /// <item><description><b>strEqual</b>: Equals.</description></item>
            /// <item><description><b>strNotEqual</b>: Does not equal.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><b>fieldValue</b>: The match value.</description></item>
            /// <item><description><b>uuid</b>: The scope of the whitelist rule. Valid values:<list type="bullet">
            /// <item><description><b>part</b>: Only the current asset.</description></item>
            /// <item><description><b>ALL</b>: All assets.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Call the DescribeSecurityEventOperations operation to obtain the field whitelist field.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;uuid&quot;:&quot;part&quot;,&quot;field&quot;:&quot;gmtModified&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;asd&quot;},{&quot;uuid&quot;:&quot;part&quot;,&quot;field&quot;:&quot;loginUser&quot;,&quot;operate&quot;:&quot;contains&quot;,&quot;fieldValue&quot;:&quot;vff&quot;}]</para>
            /// </summary>
            [NameInMap("MarkMissParam")]
            [Validation(Required=false)]
            public string MarkMissParam { get; set; }

            /// <summary>
            /// <para>The method for handling the security alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>block_ip</b>: Block.</description></item>
            /// <item><description><b>advance_mark_mis_info</b>: Add to whitelist.</description></item>
            /// <item><description><b>ignore</b>: Ignore.</description></item>
            /// <item><description><b>manual_handled</b>: Manually handled.</description></item>
            /// <item><description><b>kill_process</b>: Terminate process.</description></item>
            /// <item><description><b>cleanup</b>: Deep scan and cleanup.</description></item>
            /// <item><description><b>kill_and_quara</b>: Virus scan and quarantine.</description></item>
            /// <item><description><b>disable_malicious_defense</b>: Disable malicious behavior defense.</description></item>
            /// <item><description><b>client_problem_check</b>: Troubleshoot.</description></item>
            /// <item><description><b>quara</b>: Quarantine.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block_ip</para>
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// <para>The configuration of the sub-operation for handling security alert events.</para>
            /// <para>When OperationCode is set to kill_and_quara, specify the parameter type &quot;subOperation&quot;:${code}.
            /// Valid code values:</para>
            /// <list type="bullet">
            /// <item><description>Quarantined file: quaraFileByMd5andPath</description></item>
            /// <item><description>Kill process and quarantined file by process ID and path: killAndQuaraFileByPidAndMd5andPath</description></item>
            /// <item><description>Kill process only: killByMd5andPath</description></item>
            /// <item><description>Kill process and quarantined file: killAndQuaraFileByMd5andPath</description></item>
            /// <item><description>Kill container process by process ID and path: killProcessByPidandPathandCmdline</description></item>
            /// <item><description>Kill container process by file MD5 and path: killContainerProcessByMd5AndPath</description></item>
            /// </list>
            /// <para>When OperationCode is set to block_ip, the parameter is:</para>
            /// <list type="bullet">
            /// <item><description>Expiration time: expireTime:${timestamp}<remarks>
            /// <para>This parameter is required only when OperationCode is set to <c>kill_and_quara</c> or <c>block_ip</c>. For other values of OperationCode, this parameter can be left empty. ${timestamp} indicates the timestamp of the deadline for blocking this IP address.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;expireTime\&quot;:1719588943551,\&quot;subOperation\&quot;:\&quot;killAndQuaraFileByMd5andPath\&quot;}</para>
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The collection of IDs of the security alert events to handle.</para>
            /// <para>Example:</para>
            /// </summary>
            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public List<string> SecurityEventIds { get; set; }

        }

        /// <summary>
        /// <para>Handles security alert events in batches based on the same IP rule or type.</para>
        /// </summary>
        [NameInMap("HandleSimilarSecurityEventsRequest")]
        [Validation(Required=false)]
        public GetAliYunSafeCenterResultRequestHandleSimilarSecurityEventsRequest HandleSimilarSecurityEventsRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestHandleSimilarSecurityEventsRequest : TeaModel {
            /// <summary>
            /// <para>The alerting type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cfw_elasticity_public_cn-g4t3nkh3i00b</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.10*.44.71</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The operation type for batch handling similar security alert events.</para>
            /// <remarks>
            /// <para>You can call the DescribeSecurityEventOperations operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>offline_handled</para>
            /// </summary>
            [NameInMap("OperationCode")]
            [Validation(Required=false)]
            public string OperationCode { get; set; }

            /// <summary>
            /// <para>The configuration of the sub-operation for handling alerting events. The value is in JSON format.</para>
            /// <remarks>
            /// <para>This parameter is required only when <b>OperationCode</b> is set to <b>kill_and_quara</b>, <b>block_ip</b>, or <b>virus_quara</b>. For other values of <b>OperationCode</b>, this parameter can be left empty.</para>
            /// </remarks>
            /// <remarks>
            /// <para>When <b>OperationCode</b> is set to <b>block_ip</b>, the following field is included:</para>
            /// <list type="bullet">
            /// <item><description><b>expireTime</b>: The lock expiration time. Unit: milliseconds.</description></item>
            /// </list>
            /// <para>When <b>OperationCode</b> is set to <b>kill_and_quara</b>, the following field is included:</para>
            /// <list type="bullet">
            /// <item><description><b>subOperation</b>: The method for killing and quarantining. Valid values:<list type="bullet">
            /// <item><description><b>killAndQuaraFileByMd5andPath</b>: Terminates the process and quarantines the file.</description></item>
            /// <item><description><b>killByMd5andPath</b>: Terminates the running process.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <para>When <b>OperationCode</b> is set to <b>virus_quara</b>, the following field is included:</para>
            /// <list type="bullet">
            /// <item><description><b>subOperation</b>: The method for killing and quarantining. Valid values:<list type="bullet">
            /// <item><description><b>quaraFileByMd5andPath</b>: Quarantines the source file of the process.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;expireTime\&quot;:1767687685917}</para>
            /// </summary>
            [NameInMap("OperationParams")]
            [Validation(Required=false)]
            public string OperationParams { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The IP address of the access source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>220.2*3.155.93</para>
            /// </summary>
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            /// <summary>
            /// <para>The ID of the task for batch handling all security alert events of the same type.</para>
            /// <remarks>
            /// <para>You can call the CreateSimilarSecurityEventsQueryTask operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>12221</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

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
        public GetAliYunSafeCenterResultRequestListInstancesRequest ListInstancesRequest { get; set; }
        public class GetAliYunSafeCenterResultRequestListInstancesRequest : TeaModel {
            /// <summary>
            /// <para>The instance IDs of simple application servers. The value is a JSON array that can contain up to 100 IDs. Separate multiple IDs with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;2ad1ae67295445f598017499dc****&quot;, &quot;2ad1ae67295445f598017123dc****&quot;]</para>
            /// </summary>
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public string InstanceIds { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

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
