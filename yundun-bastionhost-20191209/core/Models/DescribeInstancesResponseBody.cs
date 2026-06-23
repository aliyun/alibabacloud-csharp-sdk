// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of Bastionhost instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The default bandwidth of the instance, in Mbit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60M</para>
            /// </summary>
            [NameInMap("BandWidth")]
            [Validation(Required=false)]
            public long? BandWidth { get; set; }

            /// <summary>
            /// <para>The custom description of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test API</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expiration time of the Bastionhost instance, specified as a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1578326400000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// <para>The image version of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2.41</para>
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <para>The ID of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bastionhost-cn-78v1gh****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the Bastionhost instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>PENDING</b>: Not initialized</para>
            /// </description></item>
            /// <item><description><para><b>CREATING</b>: The instance is being created.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: The instance is running.</para>
            /// </description></item>
            /// <item><description><para><b>EXPIRED</b>: The instance has expired.</para>
            /// </description></item>
            /// <item><description><para><b>CREATE_FAILED</b>: Instance creation failed.</para>
            /// </description></item>
            /// <item><description><para><b>UPGRADING</b>: The instance is being upgraded.</para>
            /// </description></item>
            /// <item><description><para><b>UPGRADE_FAILED</b>: Instance upgrade failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The public domain name of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>******lwb-public.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("InternetEndpoint")]
            [Validation(Required=false)]
            public string InternetEndpoint { get; set; }

            /// <summary>
            /// <para>The private domain name of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>******lwb.bastionhost.aliyuncs.com</para>
            /// </summary>
            [NameInMap("IntranetEndpoint")]
            [Validation(Required=false)]
            public string IntranetEndpoint { get; set; }

            /// <summary>
            /// <para>Indicates whether the Bastionhost instance is a legacy instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The instance is of the V2 or V3.1 series.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The instance is of the V3.2 series.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Legacy")]
            [Validation(Required=false)]
            public bool? Legacy { get; set; }

            /// <summary>
            /// <para>The license code of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bhah_ent_50_asset</para>
            /// </summary>
            [NameInMap("LicenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

            /// <summary>
            /// <para>The edition of the Bastionhost instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>cloudbastion</b>: Basic Edition</para>
            /// </description></item>
            /// <item><description><para><b>cloudbastion_ha</b>: Enterprise Edition</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloudbastion_ha</para>
            /// </summary>
            [NameInMap("PlanCode")]
            [Validation(Required=false)]
            public string PlanCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the Bastionhost instance is accessible over the Internet. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The instance is accessible over the Internet.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The instance is not accessible over the Internet.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PublicNetworkAccess")]
            [Validation(Required=false)]
            public bool? PublicNetworkAccess { get; set; }

            /// <summary>
            /// <para>The region ID of the Bastionhost instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the Bastionhost instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-acfm26ougi****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the standby vSwitch to which the Bastionhost instance is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6j0u49poi8qr****</para>
            /// </summary>
            [NameInMap("SlaveVswitchId")]
            [Validation(Required=false)]
            public string SlaveVswitchId { get; set; }

            /// <summary>
            /// <para>The purchase or renewal time of the Bastionhost instance, specified as a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1577681345000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the Bastionhost instance is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1c85tzgqu1bf5b****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the Bastionhost instance is attached.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1xfwzzfti0kjbf****</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates this unique ID for troubleshooting purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61D36C55-AAFC-4678-8FAD-34FEF9E7182E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of Bastionhost instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
