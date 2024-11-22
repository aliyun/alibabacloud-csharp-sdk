// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribePackageStateRequest : TeaModel {
        /// <summary>
        /// <para>The specifications of the certificate resource plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>digicert-free-1-free</b> (default): DigiCert single-domain domain validated (DV) certificate in a three-month free trial, available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>symantec-free-1-free</b>: DigiCert single-domain DV certificate in a one-year free trial, available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>symantec-dv-1-starter</b>: DigiCert wildcard DV certificate.</description></item>
        /// <item><description><b>symantec-ov-1-personal</b>: DigiCert single-domain organization validated (OV) certificate.</description></item>
        /// <item><description><b>symantec-ov-w-personal</b>: DigiCert wildcard OV certificate.</description></item>
        /// <item><description><b>geotrust-dv-1-starter</b>: GeoTrust single-domain DV certificate.</description></item>
        /// <item><description><b>geotrust-dv-w-starter</b>: GeoTrust wildcard DV certificate.</description></item>
        /// <item><description><b>geotrust-ov-1-personal</b>: GeoTrust single-domain OV certificate.</description></item>
        /// <item><description><b>geotrust-ov-w-personal</b>: GeoTrust wildcard OV certificate.</description></item>
        /// <item><description><b>globalsign-dv-1-personal</b>: GlobalSign single-domain DV certificate.</description></item>
        /// <item><description><b>globalsign-dv-w-advanced</b>: GlobalSign wildcard DV certificate.</description></item>
        /// <item><description><b>globalsign-ov-1-personal</b>: GlobalSign single-domain OV certificate.</description></item>
        /// <item><description><b>globalsign-ov-w-advanced</b>: GlobalSign wildcard OV certificate.</description></item>
        /// <item><description><b>cfca-ov-1-personal</b>: China Financial Certification Authority (CFCA) single-domain OV certificate, available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>cfca-ev-w-advanced</b>: CFCA wildcard OV certificate, available only on the China site (aliyun.com).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>symantec-free-1-free</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
