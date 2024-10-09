// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeMonitorDataRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>token</b> can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 January 1, 1970.</description></item>
        /// <item><description>Time format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The interval between the start time and the end time is less than or equal to 31 days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-08T08:04:44Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the simple application server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ad1ae67295445f598017499dc****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 1440.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// <para>The name of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MEMORY_ACTUALUSEDSPACE: the memory usage. Unit: bytes.</description></item>
        /// <item><description>DISKUSAGE_USED: the disk usage. Unit: bytes.</description></item>
        /// <item><description>CPU_UTILIZATION: the CPU usage, in percentage.</description></item>
        /// <item><description>VPC_PUBLICIP_INTERNETOUT_RATE: the outbound bandwidth. Unit: bits/s.</description></item>
        /// <item><description>VPC_PUBLICIP_INTERNETIN_RATE: the inbound bandwidth. Unit: bits/s.</description></item>
        /// <item><description>DISK_READ_IOPS: the read IOPS of the disk. Unit: count/s.</description></item>
        /// <item><description>DISK_WRITE_IOPS: the write IOPS of the disk. Unit: count/s.</description></item>
        /// <item><description>FLOW_USED: the traffic usage. Unit: bytes.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DISKUSAGE_USED</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nOc1nj4M9UaAZ/I8db***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The interval at which the monitoring data is queried. Valid values: 60, 300, and 900. Unit: seconds.</para>
        /// <remarks>
        /// </remarks>
        /// <para>If MetricName is set to FLOW_USED, Period is set to 3600 (one hour). In other cases, set Period based on your business requirements.</para>
        /// <para>**</para>
        /// <hr>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the simple application server. You can call the <a href="https://help.aliyun.com/document_detail/189315.html">ListRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 January 1, 1970.</description></item>
        /// <item><description>Time format: YYYY-MM-DDThh:mm:ssZ.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The specified time range includes the end time and excludes the start time. The start time must be earlier than the end time.</para>
        /// </remarks>
        /// <para>The interval between the start time and the end time is less than or equal to 31 days.</para>
        /// <para>**</para>
        /// <hr>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-07T04:04:44Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
