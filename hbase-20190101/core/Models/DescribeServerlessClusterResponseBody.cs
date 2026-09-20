// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeServerlessClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// <item><description><b>false</b>: Auto-renewal is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cluster</b>: Cluster Edition.</description></item>
        /// <item><description><b>Single</b>: single-node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The time when the cluster was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-12T14:40:46</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The compute unit (CU) size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("CuSize")]
        [Validation(Required=false)]
        public string CuSize { get; set; }

        /// <summary>
        /// <para>The disk size of the node. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public string DiskSize { get; set; }

        /// <summary>
        /// <para>The expiration time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-10-12T14:40:46</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether high availability (HA) is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: HA is enabled.</description></item>
        /// <item><description><b>false</b>: HA is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HaType")]
        [Validation(Required=false)]
        public string HaType { get; set; }

        /// <summary>
        /// <para>Indicates whether the cluster has users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The cluster has users.</description></item>
        /// <item><description><b>false</b>: The cluster does not have users.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasUser")]
        [Validation(Required=false)]
        public string HasUser { get; set; }

        /// <summary>
        /// <para>The internal endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://sh-wz91452kg946i****-lindorm-serverless-in.lindorm.rds.aliyuncs.com:443">https://sh-wz91452kg946i****-lindorm-serverless-in.lindorm.rds.aliyuncs.com:443</a></para>
        /// </summary>
        [NameInMap("InnerEndpoint")]
        [Validation(Required=false)]
        public string InnerEndpoint { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hb-bp16f1441y6p2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDeletionProtection")]
        [Validation(Required=false)]
        public string IsDeletionProtection { get; set; }

        /// <summary>
        /// <para>The lock type of the cluster.</para>
        /// <remarks>
        /// <para>This parameter does not return a value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>过期</para>
        /// </summary>
        [NameInMap("LockMode")]
        [Validation(Required=false)]
        public string LockMode { get; set; }

        /// <summary>
        /// <para>The major version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.8</para>
        /// </summary>
        [NameInMap("MainVersion")]
        [Validation(Required=false)]
        public string MainVersion { get; set; }

        /// <summary>
        /// <para>The public endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://sh-wz91452kg946i****-lindorm-serverless.lindorm.rds.aliyuncs.com:443">https://sh-wz91452kg946i****-lindorm-serverless.lindorm.rds.aliyuncs.com:443</a></para>
        /// </summary>
        [NameInMap("OuterEndpoint")]
        [Validation(Required=false)]
        public string OuterEndpoint { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89F81C30-320B-4550-91DB-C37C81D2358F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The maximum reserved QPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ReserverMaxQpsNum")]
        [Validation(Required=false)]
        public string ReserverMaxQpsNum { get; set; }

        /// <summary>
        /// <para>The minimum reserved QPS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ReserverMinQpsNum")]
        [Validation(Required=false)]
        public string ReserverMinQpsNum { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-fjm2d4v7sf****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The current status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CREATING</b>: being created.</description></item>
        /// <item><description><b>ACTIVATION</b>: running.</description></item>
        /// <item><description><b>DELETING</b>: being deleted.</description></item>
        /// <item><description><b>RESTARTING</b>: being restarted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The minor version upgrade status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>YES</b>: An upgrade is available.</description></item>
        /// <item><description><b>NO</b>: No upgrade is available.</description></item>
        /// <item><description><b>PENDING</b>: An upgrade is in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NO</para>
        /// </summary>
        [NameInMap("UpdateStatus")]
        [Validation(Required=false)]
        public string UpdateStatus { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp191ipotqf****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp120k6ixs4eoghz****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
