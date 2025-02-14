// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateDataLimitRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the security audit feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically trigger a re-scan after a rule is modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// <remarks>
        /// <para>When a re-scan is triggered, DSC scans all data in your data asset.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoScan")]
        [Validation(Required=false)]
        public int? AutoScan { get; set; }

        /// <summary>
        /// <para>The permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadOnly</b>: read-only permissions</description></item>
        /// <item><description><b>ReadWrite</b>: read and write permissions</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ReadOnly</para>
        /// </summary>
        [NameInMap("CertificatePermission")]
        [Validation(Required=false)]
        public string CertificatePermission { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable sensitive data detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this is your first time to authorize DSC to access the data asset, the default value is 1. If this is not your first time to authorize DSC to access the data asset, the default value is the same as that used in the last authorization operation. Both 1 and 0 are possible.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The database engine that is run by the instance. Valid values:</para>
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
        /// <para>Specifies whether to enable anomalous event detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public int? EventStatus { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately scan the authorized asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InstantlyScan")]
        [Validation(Required=false)]
        public bool? InstantlyScan { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The retention period of raw logs after you enable the security audit feature. Unit: days. Valid values:</para>
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
        /// <para>Specifies whether to enable optical character recognition (OCR). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrStatus")]
        [Validation(Required=false)]
        public int? OcrStatus { get; set; }

        /// <summary>
        /// <para>The name of the asset. The value is a connection string. It consists of an instance ID and a database name, which are separated by a comma (,). This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-11**</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The password that is used to access the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>passwd</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The port that is used to connect to the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The type of service to which the data asset belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b> :MaxCompute</description></item>
        /// <item><description><b>2</b>: Object Storage Service (OSS)</description></item>
        /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
        /// <item><description><b>4</b> :Tablestore</description></item>
        /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// <para>The number of sensitive data samples that are collected after sensitive data detection is enabled. Valid values:</para>
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
        /// <para>The region in which the data asset resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: China (Beijing).</description></item>
        /// <item><description><b>cn-zhangjiakou</b>: China (Zhangjiakou)</description></item>
        /// <item><description><b>cn-huhehaote</b>: China (Hohhot)</description></item>
        /// <item><description><b>cn-hangzhou</b>: China (Hangzhou)</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai)</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen)</description></item>
        /// <item><description><b>cn-hongkong</b>: China (Hong Kong)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39.170.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The username that is used to access the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yhm</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
