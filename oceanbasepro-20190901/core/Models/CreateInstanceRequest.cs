// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic renewal.<br>This parameter is valid only when the ChargeType parameter is set to PrePaid. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>true: enables automatic renewal for the instance.   </description></item>
        /// <item><description>false: disables automatic renewal for the instance. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The automatic renewal period of the instance. This parameter is required when the AutoRenew parameter is set to true. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>If the PeriodUnit parameter is set to Year: &quot;1&quot;, &quot;2&quot;, and &quot;3&quot;.   </description></item>
        /// <item><description>If the PeriodUnit parameter is set to Month: &quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;6&quot;, and &quot;12&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public long? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>PrePay: the subscription billing method. You must ensure that the remaining balance or credit balance of your account can cover the cost of the subscription. Otherwise, you will receive an InvalidPayMethod error. </description></item>
        /// <item><description>PostPay: the pay-as-you-go billing method. This is the default value. By default, fees are charged on an hourly basis.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePay</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>x86</para>
        /// </summary>
        [NameInMap("CpuArch")]
        [Validation(Required=false)]
        public string CpuArch { get; set; }

        /// <summary>
        /// <para>The size of the storage space,in GB.<br>The limits on the storage space vary with the cluster specifications:   </para>
        /// <list type="bullet">
        /// <item><description>8C32GB: 100 GB to 10000 GB   </description></item>
        /// <item><description>14C70GB: 200 GB to 10000 GB   </description></item>
        /// <item><description>30C180GB: 400 GB to 10000 GB   </description></item>
        /// <item><description>62C400GB: 800 GB to 10000 GB<br>The preceding minimum storage space sizes are the default storage space sizes of the corresponding cluster specification plans.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public long? DiskSize { get; set; }

        /// <summary>
        /// <para>The type of the storage disk where the cluster is deployed. This parameter takes effect only for Standard Cluster Edition (Cloud Disk).
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_essd_pl1: ESSD PL1.</description></item>
        /// <item><description>cloud_essd_pl0: ESSD PL0. Default value: cloud_essd_pl1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd_pl1</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run for the request. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only a dry-run request is sent and the instance is not created. If the dry run succeeds, DryRunResult=true is returned. If the dry run fails, an error code is returned.</description></item>
        /// <item><description>false: The actual request is sent and no dry run is performed. The instance is created if the requirements are met. By default, the DryRunResult parameter returns false if you set DryRun to false.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The specifications of the cluster.<br>You can specify one of the following four plans:   </para>
        /// <list type="bullet">
        /// <item><description>8C32GB: indicates 8 CPU cores and 32 GB of memory.    </description></item>
        /// <item><description>14C70GB: indicates 14 CPU cores and 70 GB of memory. This is the default value.</description></item>
        /// <item><description>30C180GB: indicates 30 CPU cores and 180 GB of memory.     </description></item>
        /// <item><description>62C400GB: indicates 62 CPU cores and 400 GB of memory.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14C70GB</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the OceanBase cluster.<br>It must be 1 to 20 characters in length.<br>If this parameter is not specified, the value is the instance ID of the cluster by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amap_aos_tx_ob</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the control group feature.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsolationOptimization")]
        [Validation(Required=false)]
        public string IsolationOptimization { get; set; }

        /// <summary>
        /// <para>OceanBase Server version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.2.77</para>
        /// </summary>
        [NameInMap("ObVersion")]
        [Validation(Required=false)]
        public string ObVersion { get; set; }

        /// <summary>
        /// <para>The valid duration of the purchased resources. The unit is specified by the PeriodUnit parameter.<br>This parameter is valid and required only when the InstanceChargeType parameter is set to PrePaid.<br>Valid values:     </para>
        /// <list type="bullet">
        /// <item><description>When the PeriodUnit parameter is set to Month: &quot;1&quot;, &quot;2&quot;, &quot;3&quot;, &quot;4&quot;, &quot;5&quot;, &quot;6&quot;, &quot;7&quot;, &quot;8&quot;, &quot;9&quot;. </description></item>
        /// <item><description>When the PeriodUnit parameter is set to Year: &quot;1&quot;, &quot;2&quot;, &quot;3&quot;.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// <para>The unit of the valid duration of the purchased resources.<br>Valid value for subscription: Month or Year.
        /// Default value: Month for subscription, and Hour for pay-as-you-go.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>Primary instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ob3h8ytroxxxxx</para>
        /// </summary>
        [NameInMap("PrimaryInstance")]
        [Validation(Required=false)]
        public string PrimaryInstance { get; set; }

        /// <summary>
        /// <para>Primary instance region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("PrimaryRegion")]
        [Validation(Required=false)]
        public string PrimaryRegion { get; set; }

        /// <summary>
        /// <para>The number of full-featured replicas.</para>
        /// <list type="bullet">
        /// <item><description>3F: three full-featured replicas.</description></item>
        /// <item><description>2F1L: two full-featured replicas and one log replica.</description></item>
        /// <item><description>2F1A: two full-featured replicas and one arbitration service.</description></item>
        /// <item><description>ApsaraDB for OceanBase earlier than V4.1 supports 3F and 2F1L.</description></item>
        /// <item><description>ApsaraDB for OceanBase V4.1 or later supports 3F and 2F1A.</description></item>
        /// <item><description>An ApsaraDB for OceanBase instance deployed across three zones supports only 3F.</description></item>
        /// <item><description>An ApsaraDB for OceanBase instance deployed across two zones supports 2F1A or 2F1L, depending on the version.</description></item>
        /// <item><description>An ApsaraDB for OceanBase instance deployed in a single zone supports 3F, 2F1A, or 2F1L, depending on the version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3F</para>
        /// </summary>
        [NameInMap("ReplicaMode")]
        [Validation(Required=false)]
        public string ReplicaMode { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The series of the OceanBase cluster. Valid values:    </para>
        /// <list type="bullet">
        /// <item><description>normal: Standard Cluster Edition (Cloud Disk). This is the default value.</description></item>
        /// <item><description>normal_ssd: Standard Cluster Edition (Local Disk).</description></item>
        /// <item><description>history: History Database Cluster Edition.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Series")]
        [Validation(Required=false)]
        public string Series { get; set; }

        /// <summary>
        /// <para>The ID of the zone to which the instance belongs.<br>For more information about how to obtain the list of zones, see <a href="https://help.aliyun.com/document_detail/25610.html">DescribeZones</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h,cn-hangzhou-i,cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("Zones")]
        [Validation(Required=false)]
        public string Zones { get; set; }

    }

}
