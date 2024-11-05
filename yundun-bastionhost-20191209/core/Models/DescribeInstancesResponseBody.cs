// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the bastion hosts returned.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The remarks of the bastion host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test API</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The timestamp when the bastion host expires. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578326400000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The image version of the bastion host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.0.0</para>
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <para>The bastion host ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bastionhost-cn-78v1gh****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the bastion host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PENDING</b>: The bastion host is not initialized.</description></item>
            /// <item><description><b>CREATING</b>: The bastion host is being created.</description></item>
            /// <item><description><b>RUNNING</b>: The bastion host is running.</description></item>
            /// <item><description><b>EXPIRED</b>: The bastion host expired.</description></item>
            /// <item><description><b>CREATE_FAILED</b>: The bastion host fails to be created.</description></item>
            /// <item><description><b>UPGRADING</b>: The configurations of the bastion host are being changed.</description></item>
            /// <item><description><b>UPGRADE_FAILED</b>: The configurations of the bastion host fail to be changed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The public O\&amp;M address of the bastion host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drawvxalwb-public.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// <para>The private O\&amp;M address of the bastion host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drawvxalwb.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// <para>Indicates whether the bastion host runs an earlier version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The bastion host runs V2 or V3.1.</description></item>
            /// <item><description><b>false</b>: The bastion host runs V3.2.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Legacy")]
            [Validation(Required=false)]
            public bool? Legacy { get; set; }

            /// <summary>
            /// <para>The license code of the bastion host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bhah_ent_50_asset</para>
            /// </summary>
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            /// <summary>
            /// <para>The edition of the bastion host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>cloudbastion</b>: Basic Edition.</description></item>
            /// <item><description><b>cloudbastion_ha</b>: Enterprise Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloudbastion_ha</para>
            /// </summary>
            [NameInMap("PlanCode")]
            [Validation(Required=false)]
            public string PlanCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the bastion host can be accessed from the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// <para>The region ID of the bastion host.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the bastion host belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-acfm26ougi****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The timestamp when the bastion host is purchased or renewed. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1577681345000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The ID of the virtual private cloud (VPC) to which the bastion host belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1c85tzgqu1bf5b****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the bastion host belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1xfwzzfti0kjbf****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61D36C55-AAFC-4678-8FAD-34FEF9E7182E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of bastion hosts that are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
