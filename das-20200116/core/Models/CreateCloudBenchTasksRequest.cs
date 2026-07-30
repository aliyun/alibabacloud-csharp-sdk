// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateCloudBenchTasksRequest : TeaModel {
        /// <summary>
        /// <para>The total number of stress testing tasks to create. Valid values: <b>0</b> to <b>30</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>The ID of the backup set. You can call the <a href="https://help.aliyun.com/document_detail/26273.html">DescribeBackups</a> operation to query the backup list and obtain the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>229132</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The time of the backup. Format: yyyy-MM-ddTHH:mm:ssZ (UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-23T13:22:14Z</para>
        /// </summary>
        [NameInMap("BackupTime")]
        [Validation(Required=false)]
        public string BackupTime { get; set; }

        /// <summary>
        /// <para>The type of stress testing machine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ECS</b>: You need to prepare a <a href="https://help.aliyun.com/document_detail/64905.html">Database Gateway</a> yourself.</para>
        /// </description></item>
        /// <item><description><para><b>DAS_ECS</b>: An ECS instance that is automatically purchased and deployed by DAS.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// <para>The description of the stress testing task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-das-bench-0501</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The connection address of the target instance. Only RDS MySQL and PolarDB MySQL instances are supported.</para>
        /// <remarks>
        /// <para>This parameter takes effect when <b>DstType</b> is set to <b>ConnectionString</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-de21209****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DstConnectionString")]
        [Validation(Required=false)]
        public string DstConnectionString { get; set; }

        /// <summary>
        /// <para>The ID of the target instance. Only RDS MySQL and PolarDB MySQL instances are supported. You can call the <a href="https://help.aliyun.com/document_detail/202857.html">GetInstanceInspections</a> operation to obtain the ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DstType</b> is set to <b>Instance</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("DstInstanceId")]
        [Validation(Required=false)]
        public string DstInstanceId { get; set; }

        /// <summary>
        /// <para>The port of the target instance.</para>
        /// <remarks>
        /// <para>This parameter takes effect when <b>DstType</b> is set to <b>ConnectionString</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public string DstPort { get; set; }

        /// <summary>
        /// <para>The privileged account of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("DstSuperAccount")]
        [Validation(Required=false)]
        public string DstSuperAccount { get; set; }

        /// <summary>
        /// <para>The password of the privileged account of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("DstSuperPassword")]
        [Validation(Required=false)]
        public string DstSuperPassword { get; set; }

        /// <summary>
        /// <para>The type of the target instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b> (default): instance ID.</para>
        /// </description></item>
        /// <item><description><para><b>ConnectionString</b>: connection address of the instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("DstType")]
        [Validation(Required=false)]
        public string DstType { get; set; }

        /// <summary>
        /// <para>The specification of the DTS migration task. You can call the <a href="https://help.aliyun.com/document_detail/230669.html">DescribeCloudbenchTask</a> operation to obtain the specification.</para>
        /// <remarks>
        /// <para>The stress testing task needs to migrate the baseline data from the source instance to the target instance. This parameter is required when you create a new DTS task.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("DtsJobClass")]
        [Validation(Required=false)]
        public string DtsJobClass { get; set; }

        /// <summary>
        /// <para>The ID of the DTS migration task. You can call the <a href="https://help.aliyun.com/document_detail/208399.html">ConfigureDtsJob</a> operation to obtain the ID.</para>
        /// <remarks>
        /// <para>This parameter is required when a DTS task has been created in the DTS console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23127</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The status after the stress testing task ends. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>WAIT_TARGET</b>: Prepare the target instance for stress testing.</para>
        /// </description></item>
        /// <item><description><para><b>WAIT_DBGATEWAY</b>: Prepare the stress testing deployment.</para>
        /// </description></item>
        /// <item><description><para><b>WAIT_SQL</b>: Prepare the full SQL statements.</para>
        /// </description></item>
        /// <item><description><para><b>WAIT_LOGIC</b>: Prepare to start replaying the traffic.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When the stress testing task completes the status set by EndState, the task directly reaches the completed status.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WAIT_TARGET</para>
        /// </summary>
        [NameInMap("EndState")]
        [Validation(Required=false)]
        public string EndState { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) ID of the Database Gateway.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>ClientType</b> is set to <b>ECS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4nsnwvpbc1h76ja4****</para>
        /// </summary>
        [NameInMap("GatewayVpcId")]
        [Validation(Required=false)]
        public string GatewayVpcId { get; set; }

        /// <summary>
        /// <para>The IP address or domain name of the Database Gateway.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>ClientType</b> is set to <b>ECS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.30.XX.XX</para>
        /// </summary>
        [NameInMap("GatewayVpcIp")]
        [Validation(Required=false)]
        public string GatewayVpcIp { get; set; }

        /// <summary>
        /// <para>The replay speed of the source instance traffic on the target instance. The replay speed must be a positive integer. Valid values: <b>1</b> to <b>30</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rate")]
        [Validation(Required=false)]
        public string Rate { get; set; }

        /// <summary>
        /// <para>The duration of the stress testing task. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("RequestDuration")]
        [Validation(Required=false)]
        public string RequestDuration { get; set; }

        /// <summary>
        /// <para>The end time of the stress testing task. The time is in the UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296001</para>
        /// </summary>
        [NameInMap("RequestEndTime")]
        [Validation(Required=false)]
        public string RequestEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the stress testing task. The time is in the UNIX timestamp format. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296000</para>
        /// </summary>
        [NameInMap("RequestStartTime")]
        [Validation(Required=false)]
        public string RequestStartTime { get; set; }

        /// <summary>
        /// <para>The duration of the generated stress testing. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>TaskType</b> is set to <b>smart pressure test</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("SmartPressureTime")]
        [Validation(Required=false)]
        public string SmartPressureTime { get; set; }

        /// <summary>
        /// <para>The ID of the source instance. Only RDS MySQL and PolarDB MySQL instances are supported. You can call the <a href="https://help.aliyun.com/document_detail/202857.html">GetInstanceInspections</a> operation to obtain the ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DstType</b> is set to <b>Instance</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("SrcInstanceId")]
        [Validation(Required=false)]
        public string SrcInstanceId { get; set; }

        /// <summary>
        /// <para>Reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("SrcPublicIp")]
        [Validation(Required=false)]
        public string SrcPublicIp { get; set; }

        /// <summary>
        /// <para>The privileged account of the source instance. Value: <b>admin</b>.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DstType</b> is set to <b>Instance</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("SrcSuperAccount")]
        [Validation(Required=false)]
        public string SrcSuperAccount { get; set; }

        /// <summary>
        /// <para>The password of the privileged account of the source instance.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DstType</b> is set to <b>Instance</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("SrcSuperPassword")]
        [Validation(Required=false)]
        public string SrcSuperPassword { get; set; }

        /// <summary>
        /// <para>The type of stress testing task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>pressure test</b> (default): Intelligent stress testing, which replays the traffic captured from the source instance on the target instance at the maximum speed supported by the target instance type.</para>
        /// </description></item>
        /// <item><description><para><b>smart pressure test</b>: Generated stress testing, which analyzes and learns from the traffic captured from the source instance in a short period of time, generates traffic that is consistent with the business model and traffic distribution of the original traffic for continuous stress testing, reduces the time for collecting data from the source instance, and reduces storage costs and performance overhead.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pressure test</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>The temporary directory generated by the stress testing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/tmp/bench/</para>
        /// </summary>
        [NameInMap("WorkDir")]
        [Validation(Required=false)]
        public string WorkDir { get; set; }

    }

}
