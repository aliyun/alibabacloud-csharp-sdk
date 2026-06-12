// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceInstanceLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The logs of the service instance.</para>
        /// </summary>
        [NameInMap("ServiceInstancesLogs")]
        [Validation(Required=false)]
        public List<ListServiceInstanceLogsResponseBodyServiceInstancesLogs> ServiceInstancesLogs { get; set; }
        public class ListServiceInstanceLogsResponseBodyServiceInstancesLogs : TeaModel {
            /// <summary>
            /// <para>The threat type from the compliance package. This parameter is returned only when Source is set to compliancePack. For example, VpcDataRisk indicates a data security check within a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VpcDataRisk</para>
            /// </summary>
            [NameInMap("CompliancePackType")]
            [Validation(Required=false)]
            public string CompliancePackType { get; set; }

            /// <summary>
            /// <para>The name of the threat rule from the compliance package. This parameter is returned only when Source is set to compliancePack. For example, vpc-ecs-move-out-vpc indicates that an ECS instance was moved out of a VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-ecs-move-out-vpc</para>
            /// </summary>
            [NameInMap("ComplianceRuleName")]
            [Validation(Required=false)]
            public string ComplianceRuleName { get; set; }

            /// <summary>
            /// <para>The content of the log entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Start creating service instance</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The log type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>serviceInstance: Logs at the service instance level.</para>
            /// </description></item>
            /// <item><description><para>resource: Logs at the ROS resource level.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>serviceInstance</para>
            /// </summary>
            [NameInMap("LogType")]
            [Validation(Required=false)]
            public string LogType { get; set; }

            /// <summary>
            /// <para>The ID of the associated resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-5c6525c0589545c3****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROS.Stack</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The source of the log. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ros: Logs from ROS.</para>
            /// </description></item>
            /// <item><description><para>computeNest: Logs from Compute Nest.</para>
            /// </description></item>
            /// <item><description><para>application: Logs from the application in the instance.</para>
            /// </description></item>
            /// <item><description><para>compliancePack: Logs from the compliance package of the instance.</para>
            /// </description></item>
            /// <item><description><para>actionTrail: Logs from ActionTrail.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>computeNest</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The status of the event that the log records. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Creating: The instance is being created.</para>
            /// </description></item>
            /// <item><description><para>Created: The instance is created.</para>
            /// </description></item>
            /// <item><description><para>Deploying: The instance is being deployed.</para>
            /// </description></item>
            /// <item><description><para>Deployed: The instance is deployed.</para>
            /// </description></item>
            /// <item><description><para>DeployedFailed: The instance failed to be deployed.</para>
            /// </description></item>
            /// <item><description><para>Expired: The instance has expired.</para>
            /// </description></item>
            /// <item><description><para>ExtendSuccess: The instance is successfully renewed.</para>
            /// </description></item>
            /// <item><description><para>Upgrading: The instance is being upgraded.</para>
            /// </description></item>
            /// <item><description><para>UpgradeSuccess: The instance is successfully upgraded.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deployed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The timestamp of the log entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-21T00:00:00Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

        }

    }

}
