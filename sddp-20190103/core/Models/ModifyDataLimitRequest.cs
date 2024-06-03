// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyDataLimitRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable the security audit feature. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// Specifies whether to automatically trigger a re-scan after a rule is modified. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// 
        /// > When a re-scan is triggered, DSC scans all data in your data asset.
        /// </summary>
        [NameInMap("AutoScan")]
        [Validation(Required=false)]
        public int? AutoScan { get; set; }

        /// <summary>
        /// The database engine that is run by the instance. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **SQLServer**
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// The unique ID of the data asset for which you want to modify configuration items.
        /// 
        /// > You can call the [DescribeDataLimits](~~DescribeDataLimits~~) operation to query the ID of the data asset.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese (default)
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The retention period of raw logs after you enable the security audit feature. Unit: days. Valid values:
        /// 
        /// *   **30**
        /// *   **90**
        /// *   **180**
        /// *   **365**
        /// </summary>
        [NameInMap("LogStoreDay")]
        [Validation(Required=false)]
        public int? LogStoreDay { get; set; }

        /// <summary>
        /// Specifies whether to change the username and password that are used to log on to the ApsaraDB RDS database. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("ModifyPassword")]
        [Validation(Required=false)]
        public bool? ModifyPassword { get; set; }

        /// <summary>
        /// The password used to log on to the ApsaraDB RDS database that you authorize DSC to access.
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// The port that is used to connect to the database.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// The name of the service to which the data asset belongs. Valid values:
        /// 
        /// *   **1**: MaxCompute
        /// *   **2**: Object Storage Service (OSS)
        /// *   **3**: AnalyticDB for MySQL
        /// *   **4**: Tablestore
        /// *   **5**: ApsaraDB RDS
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// The number of sensitive data samples tht are collected after sensitive data detection is enabled. Valid values:
        /// 
        /// *   **0**
        /// *   **5**
        /// *   **10**
        /// </summary>
        [NameInMap("SamplingSize")]
        [Validation(Required=false)]
        public int? SamplingSize { get; set; }

        /// <summary>
        /// The security group that is used by PrivateLink when you install the DSC agent.
        /// </summary>
        [NameInMap("SecurityGroupIdList")]
        [Validation(Required=false)]
        public List<string> SecurityGroupIdList { get; set; }

        /// <summary>
        /// The region in which the data asset resides. Valid values:
        /// 
        /// *   **cn-beijing**: China (Beijing)
        /// *   **cn-zhangjiakou**: China (Zhangjiakou)
        /// *   **cn-huhehaote**: China (Hohhot)
        /// *   **cn-hangzhou**: China (Hangzhou)
        /// *   **cn-shanghai**: China (Shanghai)
        /// *   **cn-shenzhen**: China (Shenzhen)
        /// *   **cn-hongkong**: China (Hong Kong)
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// The username used to log on to the ApsaraDB RDS database that you authorize DSC to access.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The vSwitch that is used by PrivateLink when you install the DSC agent.
        /// </summary>
        [NameInMap("VSwitchIdList")]
        [Validation(Required=false)]
        public List<string> VSwitchIdList { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the data asset belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
