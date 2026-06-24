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
        /// <item><description><para><b>0</b>: Do not enable auditing.</para>
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
        /// <para>Specifies whether to automatically trigger a rescan when a rule changes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Do not trigger an automatic scan.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Trigger an automatic scan.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you enable this feature, a rule change triggers a full scan of all data in the data source.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoScan")]
        [Validation(Required=false)]
        public int? AutoScan { get; set; }

        /// <summary>
        /// <para>The permission level of the credential. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ReadOnly</b>: Read-only permissions.</para>
        /// </description></item>
        /// <item><description><para><b>ReadWrite</b>: Read and write permissions.</para>
        /// </description></item>
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
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is 1 for the first authorization. For later authorizations, the value from the previous authorization is used. Set this parameter to 1 to detect sensitive data.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values:</para>
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
        /// <para>Specifies whether to enable anomalous activity detection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enabled. This is the default value.</para>
        /// </description></item>
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
        /// <para>Specifies whether to immediately scan the authorized data asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: Do not scan immediately.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Scan immediately.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InstantlyScan")]
        [Validation(Required=false)]
        public bool? InstantlyScan { get; set; }

        /// <summary>
        /// <para>The language of the content that is returned in the response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The retention period of raw logs after you enable auditing. Unit: days. Valid values:</para>
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
        /// <para>Specifies whether to enable Optical Character Recognition (OCR). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OcrStatus")]
        [Validation(Required=false)]
        public int? OcrStatus { get; set; }

        /// <summary>
        /// <para>The name of the data asset. The name consists of the instance ID and the database name, separated by a period (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-****34.******name</para>
        /// </summary>
        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// <para>The password to access the database.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public int? ResourceType { get; set; }

        /// <summary>
        /// <para>The number of sensitive data samples to return after a scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b></para>
        /// </description></item>
        /// <item><description><para><b>5</b></para>
        /// </description></item>
        /// <item><description><para><b>10</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is 10.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SamplingSize")]
        [Validation(Required=false)]
        public int? SamplingSize { get; set; }

        /// <summary>
        /// <para>The region where the data asset is located. Valid values:</para>
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
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106.11.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The username for the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>y*****m</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
