// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateDataLimitRequest : TeaModel {
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
        /// The permissions. Valid values:
        /// 
        /// *   **ReadOnly**: read-only permissions
        /// *   **ReadWrite**: read and write permissions
        /// </summary>
        [NameInMap("CertificatePermission")]
        [Validation(Required=false)]
        public string CertificatePermission { get; set; }

        /// <summary>
        /// Specifies whether to enable sensitive data detection. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// 
        /// > If this is your first time to authorize DSC to access the data asset, the default value is 1. If this is not your first time to authorize DSC to access the data asset, the default value is the same as that used in the last authorization operation. Both 1 and 0 are possible.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

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
        /// Specifies whether to enable anomalous event detection. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes (default)
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public int? EventStatus { get; set; }

        /// <summary>
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh_cn**. Valid values:
        /// 
        /// *   **zh_cn**: Chinese
        /// *   **en_us**: English
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
        /// Specifies whether to enable optical character recognition (OCR). Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("OcrStatus")]
        [Validation(Required=false)]
        public int? OcrStatus { get; set; }

        /// <summary>
        /// The name of the data asset.
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// The password that is used to access the database.
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
        /// The type of service to which the data asset belongs. Valid values:
        /// 
        /// *   **1** :MaxCompute
        /// *   **2**: Object Storage Service (OSS)
        /// *   **3**: AnalyticDB for MySQL
        /// *   **4** :Tablestore
        /// *   **5**: ApsaraDB RDS
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// The number of sensitive data samples that are collected after sensitive data detection is enabled. Valid values:
        /// 
        /// *   **0**
        /// *   **5**
        /// *   **10**
        /// </summary>
        [NameInMap("SamplingSize")]
        [Validation(Required=false)]
        public int? SamplingSize { get; set; }

        /// <summary>
        /// The region in which the data asset resides. Valid values:
        /// 
        /// *   **cn-beijing**: China (Beijing).
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
        /// This parameter is deprecated.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The username that is used to access the database.
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
