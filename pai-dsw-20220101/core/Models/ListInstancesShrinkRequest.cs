// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class ListInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The accelerator type.</para>
        /// <list type="bullet">
        /// <item><description>CPU: Only CPU computing is used.</description></item>
        /// <item><description>GPU: GPUs are used to accelerate computing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The accessibility. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE (default): The instances are accessible only to you and the administrator of the workspace.</description></item>
        /// <item><description>PUBLIC: The instances are accessible only to all members in the workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The UID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345*****67890</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NVIDIA A10</para>
        /// </summary>
        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <para>The image name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modelscope:1.9.4-pytorch2.0.1tensorflow2.13.0-cpu-py38-ubuntu20.04</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/470439.html">ListInstances</a> to obtain the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsw-730xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>training_data</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The labels. A maximum of four labels are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;key1&quot;: &quot;value1&quot;,
        ///   &quot;key2&quot;: &quot;value2&quot;,
        ///   &quot;key3&quot;: &quot;value3&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string LabelsShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of CPUs. Unit: 0.001 CPU. The value 1000 indicates one CPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000</para>
        /// </summary>
        [NameInMap("MaxCpu")]
        [Validation(Required=false)]
        public string MaxCpu { get; set; }

        /// <summary>
        /// <para>The maximum number of GPUs. Unit: 0.001 GPU. The value 1000 indicates one GPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("MaxGpu")]
        [Validation(Required=false)]
        public string MaxGpu { get; set; }

        /// <summary>
        /// <para>The maximum memory size per GPU card. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("MaxGpuMemory")]
        [Validation(Required=false)]
        public string MaxGpuMemory { get; set; }

        /// <summary>
        /// <para>The maximum memory size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("MaxMemory")]
        [Validation(Required=false)]
        public string MaxMemory { get; set; }

        /// <summary>
        /// <para>The minimum number of CPUs. Unit: 0.001 CPU. The value 1000 indicates one CPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("MinCpu")]
        [Validation(Required=false)]
        public string MinCpu { get; set; }

        /// <summary>
        /// <para>The minimum number of GPUs. Unit: 0.001 GPU. The value 1000 indicates one GPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MinGpu")]
        [Validation(Required=false)]
        public string MinGpu { get; set; }

        /// <summary>
        /// <para>The minimum memory size per GPU card. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("MinGpuMemory")]
        [Validation(Required=false)]
        public string MinGpuMemory { get; set; }

        /// <summary>
        /// <para>The minimum memory size. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MinMemory")]
        [Validation(Required=false)]
        public string MinMemory { get; set; }

        /// <summary>
        /// <para>The order that you use to sort the query results.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC</description></item>
        /// <item><description>DESC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OversoldInfo")]
        [Validation(Required=false)]
        public string OversoldInfo { get; set; }

        [NameInMap("OversoldType")]
        [Validation(Required=false)]
        public string OversoldType { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PayAsYouGo</description></item>
        /// <item><description>Subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The resource group ID. If you leave this parameter empty, the instances in the pay-as-you-go resource group are queried. If you set this parameter to ALL, all instances are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123456789</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The field that you use to sort the query results.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Priority</description></item>
        /// <item><description>GmtCreateTime</description></item>
        /// <item><description>GmtModifiedTime</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gmtCreate</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The instance status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>SaveFailed</description></item>
        /// <item><description>Stopped</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>ResourceAllocating</description></item>
        /// <item><description>Stopping</description></item>
        /// <item><description>Updating</description></item>
        /// <item><description>Saving</description></item>
        /// <item><description>Queuing</description></item>
        /// <item><description>Recovering</description></item>
        /// <item><description>Starting</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Saved</description></item>
        /// <item><description>Deleting</description></item>
        /// <item><description>EnvPreparing</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40823</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
