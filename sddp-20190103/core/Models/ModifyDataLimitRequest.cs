// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyDataLimitRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auditing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disable auditing.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enable auditing.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically trigger a rescan when a rule is changed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Do not automatically trigger a rescan.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Automatically trigger a rescan.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If a rescan is automatically triggered, a full scan is performed on the data asset.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoScan")]
        [Validation(Required=false)]
        public int? AutoScan { get; set; }

        /// <summary>
        /// <para>The type of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>SQLServer</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The unique ID of the data asset.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeDataLimits~~">DescribeDataLimits</a> operation to query the ID of the data asset.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese (default)</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The retention period of raw logs after auditing is enabled. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>90</b></para>
        /// </description></item>
        /// <item><description><para><b>180</b></para>
        /// </description></item>
        /// <item><description><para><b>365</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LogStoreDay")]
        [Validation(Required=false)]
        public int? LogStoreDay { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the username and password that are used to connect to the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Modify the username and password.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Do not modify the username and password.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ModifyPassword")]
        [Validation(Required=false)]
        public bool? ModifyPassword { get; set; }

        /// <summary>
        /// <para>The password for the ApsaraDB RDS database.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port used to connect to the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The service to which the data asset belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: OSS</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: ADS</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: OTS</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// <para>The number of sensitive data samples to return. This parameter takes effect only after data detection is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b></para>
        /// </description></item>
        /// <item><description><para><b>5</b></para>
        /// </description></item>
        /// <item><description><para><b>10</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SamplingSize")]
        [Validation(Required=false)]
        public int? SamplingSize { get; set; }

        /// <summary>
        /// <para>The security groups for agent-based auditing that uses PrivateLink.</para>
        /// </summary>
        [NameInMap("SecurityGroupIdList")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIdList { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the data asset is located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-beijing</b>: China (Beijing)</para>
        /// </description></item>
        /// <item><description><para><b>cn-zhangjiakou</b>: China (Zhangjiakou)</para>
        /// </description></item>
        /// <item><description><para><b>cn-huhehaote</b>: China (Hohhot)</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou</b>: China (Hangzhou)</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai</b>: China (Shanghai)</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen</b>: China (Shenzhen)</para>
        /// </description></item>
        /// <item><description><para><b>cn-hongkong</b>: China (Hong Kong)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The username for the ApsaraDB RDS database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User01</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The vSwitches for agent-based auditing that uses PrivateLink.</para>
        /// </summary>
        [NameInMap("VSwitchIdList")]
        [Validation(Required=false)]
        public List<string> VSwitchIdList { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the data asset belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zevcqke6hh09c41****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
