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
        /// <item><description><b>0</b>: Disable auditing.</description></item>
        /// <item><description><b>1</b>: Enable auditing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically trigger a rescan when rules change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Do not trigger an automatic scan.</description></item>
        /// <item><description><b>1</b>: Trigger an automatic scan.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When a rule change triggers an automatic scan, a full scan is performed on all data in the data source.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoScan")]
        [Validation(Required=false)]
        public int? AutoScan { get; set; }

        /// <summary>
        /// <para>The database type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
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
        /// <para>The unique ID of the data asset that belongs to the product associated with the DSC connection authorization configuration item.</para>
        /// <remarks>
        /// <para>To modify a DSC connection authorization configuration item, you must provide the unique ID of the data asset that belongs to the associated product. You can call the <a href="~~DescribeDataLimits~~">DescribeDataLimits</a> operation to obtain the ID.</para>
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
        /// <para>The language of the request and response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
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
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>90</b></description></item>
        /// <item><description><b>180</b></description></item>
        /// <item><description><b>365</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LogStoreDay")]
        [Validation(Required=false)]
        public int? LogStoreDay { get; set; }

        /// <summary>
        /// <para>Specifies whether to modify the username and password for connecting to the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Modify.</description></item>
        /// <item><description><b>false</b>: Do not modify.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ModifyPassword")]
        [Validation(Required=false)]
        public bool? ModifyPassword { get; set; }

        /// <summary>
        /// <para>The password used for the DSC connection authorization to the RDS database.</para>
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
        /// <para>The name of the product to which the data of the DSC connection authorization configuration item belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute</description></item>
        /// <item><description><b>2</b>: OSS</description></item>
        /// <item><description><b>3</b>: ADS</description></item>
        /// <item><description><b>4</b>: OTS</description></item>
        /// <item><description><b>5</b>: RDS</description></item>
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
        /// <para>The number of sample entries for sensitive data detection after data detection is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b></description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>10</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SamplingSize")]
        [Validation(Required=false)]
        public int? SamplingSize { get; set; }

        /// <summary>
        /// <para>The security groups used by PrivateLink in agent-based auditing.</para>
        /// </summary>
        [NameInMap("SecurityGroupIdList")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIdList { get; set; }

        /// <summary>
        /// <para>The region where the asset resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: China (Beijing)</description></item>
        /// <item><description><b>cn-zhangjiakou</b>: China (Zhangjiakou)</description></item>
        /// <item><description><b>cn-huhehaote</b>: China (Hohhot)</description></item>
        /// <item><description><b>cn-hangzhou</b>: China (Hangzhou)</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen)</description></item>
        /// <item><description><b>cn-hongkong</b>: Hong Kong (China)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The username used for the DSC connection authorization to the RDS database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User01</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The vSwitches used by PrivateLink in agent-based auditing.</para>
        /// </summary>
        [NameInMap("VSwitchIdList")]
        [Validation(Required=false)]
        public List<string> VSwitchIdList { get; set; }

        /// <summary>
        /// <para>The VPC ID to which the data asset belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2zevcqke6hh09c41****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
