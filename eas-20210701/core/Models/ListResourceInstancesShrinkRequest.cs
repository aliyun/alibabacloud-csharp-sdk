// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListResourceInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The keyword used to query instances. Instances can be queried by instance ID or instance IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.224.xx.xx</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The IP address of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.224.xx.xx</para>
        /// </summary>
        [NameInMap("InstanceIP")]
        [Validation(Required=false)]
        public string InstanceIP { get; set; }

        /// <summary>
        /// <para>The instance ID. For more information about how to query the instance ID, see <a href="https://help.aliyun.com/document_detail/412129.html">ListResourceInstances</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1jd6x3uotsv****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-xxxx***</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance state.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Ready-SchedulingDisabled</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>The instance is available but unschedulable</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>Ready</para>
        /// <!-- -->
        /// 
        /// <para>: The instance</para>
        /// <!-- -->
        /// 
        /// <para>is running</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>NotReady</para>
        /// <!-- -->
        /// 
        /// <para>: The instance is unready.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>Stopped</para>
        /// <!-- -->
        /// 
        /// <para>: The instance has stopped.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>NotReady-SchedulingDisabled</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>The instance is unavailable and unschedulable</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>Attaching</para>
        /// <!-- -->
        /// 
        /// <para>: The instance</para>
        /// <!-- -->
        /// 
        /// <para>is starting</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>Deleting</para>
        /// <!-- -->
        /// 
        /// <para>: The instance is being deleted.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CreateFailed: The instance failed to be created.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The tag.</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string LabelShrink { get; set; }

        /// <summary>
        /// <para>The sorting order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc: The instances are sorted in ascending order.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>desc</para>
        /// <!-- -->
        /// 
        /// <para>: The instances are sorted in descending order.</para>
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field that you use to sort the query results.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateTime</para>
        /// <!-- -->
        /// 
        /// <para>: The instances are sorted based on the time when the instances were created.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>MemoryUsed</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>The instances are sorted based on the memory usage of the instances</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>GpuUsed</para>
        /// <!-- -->
        /// 
        /// <para>: The instances are sorted based on the</para>
        /// <!-- -->
        /// 
        /// <para>GPU usage of the instances.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>ExpireTime: The instances are sorted based on the time when the instances expired.</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>CpuUsed</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>The instances are sorted based on the CPU utilization of the instances.</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
