// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class CreateDataLimitRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auditing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Auditing is disabled.</description></item>
        /// <item><description><b>1</b>: Auditing is enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public int? AuditStatus { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically trigger a rescan when rules are changed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Automatic rescan is not triggered.</description></item>
        /// <item><description><b>1</b>: Automatic rescan is triggered.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When a rule change triggers an automatic rescan, a full scan is performed on all data in the data source.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoScan")]
        [Validation(Required=false)]
        public int? AutoScan { get; set; }

        /// <summary>
        /// <para>The credential permission. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReadOnly</b>: read-only permission.</description></item>
        /// <item><description><b>ReadWrite</b>: read and write permission.</description></item>
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
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the asset is authorized for the first time, the default value is 1. If the asset has been previously authorized, the value from the last authorization is used, which may be 0 or 1. To perform sensitive data detection on the asset, set this parameter to 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The type of the database. Valid values:</para>
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
        /// <para>The anomalous activity detection status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled (default).</description></item>
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
        /// <item><description><b>false</b>: The asset is not immediately scanned.</description></item>
        /// <item><description><b>true</b>: The asset is immediately scanned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InstantlyScan")]
        [Validation(Required=false)]
        public bool? InstantlyScan { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese.</description></item>
        /// <item><description><b>en_us</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
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
        /// <para>The OCR status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrStatus")]
        [Validation(Required=false)]
        public int? OcrStatus { get; set; }

        /// <summary>
        /// <para>Required. The name of the asset, which consists of the instance ID and the database connection string separated by a period (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-****34.******name</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The password used to access the database asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p****d</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The database connection port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The type of the service to which the asset to be scanned belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute.</description></item>
        /// <item><description><b>2</b>: OSS.</description></item>
        /// <item><description><b>3</b>: ADS.</description></item>
        /// <item><description><b>4</b>: OTS.</description></item>
        /// <item><description><b>5</b>: RDS.</description></item>
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
        /// <para>The number of sample entries for sensitive data detection after data detection is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b></description></item>
        /// <item><description><b>5</b></description></item>
        /// <item><description><b>10</b><remarks>
        /// <para>Default value: 10.</para>
        /// </remarks>
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
        /// <para>Required. The region in which the asset resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-beijing</b>: China (Beijing).</description></item>
        /// <item><description><b>cn-zhangjiakou</b>: China (Zhangjiakou).</description></item>
        /// <item><description><b>cn-huhehaote</b>: China (Hohhot).</description></item>
        /// <item><description><b>cn-hangzhou</b>: China (Hangzhou).</description></item>
        /// <item><description><b>cn-shanghai</b>: China (Shanghai).</description></item>
        /// <item><description><b>cn-shenzhen</b>: China (Shenzhen).</description></item>
        /// <item><description><b>cn-hongkong</b>: Hong Kong (China).</description></item>
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
        /// <para>106.11.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The username of the database asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>y*****m</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
