// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateCloudBenchTasksRequest : TeaModel {
        /// <summary>
        /// <para>The total number of stress testing tasks that you want to create. Valid values: <b>0</b> to <b>30</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        /// <summary>
        /// <para>The ID of the backup set. You can call the <a href="https://help.aliyun.com/document_detail/26273.html">DescribeBackups</a> operation to query the ID of the backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>229132</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The time when the backup starts. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-04-23T13:22:14Z</para>
        /// </summary>
        [NameInMap("BackupTime")]
        [Validation(Required=false)]
        public string BackupTime { get; set; }

        /// <summary>
        /// <para>The type of the stress testing client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS</b>: indicates that you must create the <a href="https://help.aliyun.com/document_detail/64905.html">DBGateway</a>.</description></item>
        /// <item><description><b>DAS_ECS</b>: indicates that DAS automatically purchases and deploys an Elastic Compute Service (ECS) instance for stress testing.</description></item>
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
        /// <para>The endpoint of the destination instance. The specified endpoint must be the endpoint of an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if you set <b>DstType</b> to <b>ConnectionString</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-de21209****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DstConnectionString")]
        [Validation(Required=false)]
        public string DstConnectionString { get; set; }

        /// <summary>
        /// <para>The ID of the destination instance. The instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance. You can call the <a href="https://help.aliyun.com/document_detail/202857.html">GetInstanceInspections</a> operation to query the ID.</para>
        /// <remarks>
        /// <para> This parameter must be specified if you set <b>DstType</b> to <b>Instance</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("DstInstanceId")]
        [Validation(Required=false)]
        public string DstInstanceId { get; set; }

        /// <summary>
        /// <para>The port number of the instance that you want to access.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if you set <b>DstType</b> to <b>ConnectionString</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public string DstPort { get; set; }

        /// <summary>
        /// <para>The name of the privileged account for the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("DstSuperAccount")]
        [Validation(Required=false)]
        public string DstSuperAccount { get; set; }

        /// <summary>
        /// <para>The password of the privileged account for the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("DstSuperPassword")]
        [Validation(Required=false)]
        public string DstSuperPassword { get; set; }

        /// <summary>
        /// <para>The type of the identifier that is used to indicate the destination instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: the instance ID. This is the default value.</description></item>
        /// <item><description><b>ConnectionString</b>: the endpoint of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("DstType")]
        [Validation(Required=false)]
        public string DstType { get; set; }

        /// <summary>
        /// <para>The specification of the Data Transmission Service (DTS) migration task. You can call the <a href="https://help.aliyun.com/document_detail/230669.html">DescribeCloudbenchTask</a> operation to query the specification.</para>
        /// <remarks>
        /// <para> You must migrate the basic data in the source instance to the destination instance before you start a stress testing task. When you create a DTS migration task, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("DtsJobClass")]
        [Validation(Required=false)]
        public string DtsJobClass { get; set; }

        /// <summary>
        /// <para>The ID of the DTS migration task. You can call the <a href="https://help.aliyun.com/document_detail/208399.html">ConfigureDtsJob</a> operation to query the ID.</para>
        /// <remarks>
        /// <para> After a DTS migration task is created in the DTS console, you must specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23127</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The state that specifies the last operation that is performed for the stress testing task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>WAIT_TARGET</b>: prepares the destination instance</description></item>
        /// <item><description><b>WAIT_DBGATEWAY</b>: prepares the DBGateway</description></item>
        /// <item><description><b>WAIT_SQL</b>: prepares the full SQL statistics</description></item>
        /// <item><description><b>WAIT_LOGIC</b>: prepares to replay the traffic</description></item>
        /// </list>
        /// <remarks>
        /// <para> When the state of a stress testing task changes to the state that is specified by the EndState parameter, the stress testing task becomes completed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WAIT_TARGET</para>
        /// </summary>
        [NameInMap("EndState")]
        [Validation(Required=false)]
        public string EndState { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) in which the database gateway (DBGateway) is deployed.</para>
        /// <remarks>
        /// <para> This parameter must be specified if you set <b>ClientType</b> to <b>ECS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4nsnwvpbc1h76ja4****</para>
        /// </summary>
        [NameInMap("GatewayVpcId")]
        [Validation(Required=false)]
        public string GatewayVpcId { get; set; }

        /// <summary>
        /// <para>The IP address or domain name of the DBGateway.</para>
        /// <remarks>
        /// <para> This parameter must be specified if you set <b>ClientType</b> to <b>ECS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.30.XX.XX</para>
        /// </summary>
        [NameInMap("GatewayVpcIp")]
        [Validation(Required=false)]
        public string GatewayVpcIp { get; set; }

        /// <summary>
        /// <para>The rate at which the traffic captured from the source instance is replayed on the destination instance. The value must be a positive integer. Valid values: <b>1</b> to <b>30</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Rate")]
        [Validation(Required=false)]
        public string Rate { get; set; }

        /// <summary>
        /// <para>The duration of the stress testing task for which the traffic is captured from the source instance. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("RequestDuration")]
        [Validation(Required=false)]
        public string RequestDuration { get; set; }

        /// <summary>
        /// <para>The time when the stress testing task ends. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296001</para>
        /// </summary>
        [NameInMap("RequestEndTime")]
        [Validation(Required=false)]
        public string RequestEndTime { get; set; }

        /// <summary>
        /// <para>The time when the stress testing task starts. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296000</para>
        /// </summary>
        [NameInMap("RequestStartTime")]
        [Validation(Required=false)]
        public string RequestStartTime { get; set; }

        /// <summary>
        /// <para>The duration within which the traffic generation stressing test takes effect. Unit: milliseconds.</para>
        /// <remarks>
        /// <para> This parameter must be specified if you set <b>TaskType</b> to <b>smart pressure test</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>86400000</para>
        /// </summary>
        [NameInMap("SmartPressureTime")]
        [Validation(Required=false)]
        public string SmartPressureTime { get; set; }

        /// <summary>
        /// <para>The ID of the source instance. The instance must be an ApsaraDB RDS for MySQL instance or a PolarDB for MySQL instance. You can call the <a href="https://help.aliyun.com/document_detail/202857.html">GetInstanceInspections</a> operation to query the ID.</para>
        /// <remarks>
        /// <para> This parameter must be specified if you set <b>DstType</b> to <b>Instance</b>.</para>
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
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("SrcPublicIp")]
        [Validation(Required=false)]
        public string SrcPublicIp { get; set; }

        /// <summary>
        /// <para>The name of the privileged account for the source instance. Set the value to <b>admin</b>.</para>
        /// <remarks>
        /// <para> This parameter must be specified if you set <b>DstType</b> to <b>Instance</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("SrcSuperAccount")]
        [Validation(Required=false)]
        public string SrcSuperAccount { get; set; }

        /// <summary>
        /// <para>The password of the privileged account for the source instance.</para>
        /// <remarks>
        /// <para> This parameter must be specified if you set <b>DstType</b> to <b>Instance</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("SrcSuperPassword")]
        [Validation(Required=false)]
        public string SrcSuperPassword { get; set; }

        /// <summary>
        /// <para>The type of the stress testing task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pressure test</b> (default): A task of this type replays the traffic that is captured from the source instance on the destination instance at the maximum playback rate that is supported by the destination instance.</description></item>
        /// <item><description><b>smart pressure test</b>: A task of this type analyzes the traffic that is captured from the source instance over a short period of time and generates traffic on the destination instance for continuous stress testing. The business model based on which the traffic is generated on the destination instance and the traffic distribution are consistent with those on the source instance. Stress testing tasks of this type can help you reduce the amount of time that is consumed to collect data from the source instance and reduce storage costs and performance overheads.</description></item>
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
        /// <para>The temporary directory generated for stress testing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/tmp/bench/</para>
        /// </summary>
        [NameInMap("WorkDir")]
        [Validation(Required=false)]
        public string WorkDir { get; set; }

    }

}
