// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribePackageStateResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of issued certificates of the specified specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IssuedCount")]
        [Validation(Required=false)]
        public long? IssuedCount { get; set; }

        /// <summary>
        /// <para>The specifications of the certificate resource plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>digicert-free-1-free</b>: DigiCert single-domain DV certificate in a three-month free trial, available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>symantec-free-1-free</b>: DigiCert single-domain DV certificate in a one-year free trial, available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>symantec-dv-1-starter</b>: DigiCert wildcard DV certificate.</description></item>
        /// <item><description><b>symantec-ov-1-personal</b>: DigiCert single-domain OV certificate.</description></item>
        /// <item><description><b>symantec-ov-w-personal</b>: DigiCert wildcard OV certificate.</description></item>
        /// <item><description><b>geotrust-dv-1-starter</b>: GeoTrust single-domain DV certificate.</description></item>
        /// <item><description><b>geotrust-dv-w-starter</b>: GeoTrust wildcard DV certificate.</description></item>
        /// <item><description><b>geotrust-ov-1-personal</b>: GeoTrust single-domain OV certificate.</description></item>
        /// <item><description><b>geotrust-ov-w-personal</b>: GeoTrust wildcard OV certificate.</description></item>
        /// <item><description><b>globalsign-dv-1-personal</b>: GlobalSign single-domain DV certificate.</description></item>
        /// <item><description><b>globalsign-dv-w-advanced</b>: GlobalSign wildcard DV certificate.</description></item>
        /// <item><description><b>globalsign-ov-1-personal</b>: GlobalSign single-domain OV certificate.</description></item>
        /// <item><description><b>globalsign-ov-w-advanced</b>: GlobalSign wildcard OV certificate.</description></item>
        /// <item><description><b>cfca-ov-1-personal</b>: CFCA single-domain OV certificate, available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>cfca-ev-w-advanced</b>: CFCA wildcard OV certificate, available only on the China site (aliyun.com).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>symantec-free-1-free</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CFA380-1C58-45C7-8075-06215F3DB681</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of purchased certificate resource plans of the specified specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        /// <summary>
        /// <para>The number of certificate applications that you submitted for certificates of the specified specifications.</para>
        /// <remarks>
        /// <para>: A successful call of the <a href="https://help.aliyun.com/document_detail/204087.html">CreateCertificateForPackageRequest</a>, <a href="https://help.aliyun.com/document_detail/164105.html">CreateCertificateRequest</a>, or <a href="https://help.aliyun.com/document_detail/178732.html">CreateCertificateWithCsrRequest</a> operation is counted as one a certificate application, regardless of whether the certificate is issued.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UsedCount")]
        [Validation(Required=false)]
        public long? UsedCount { get; set; }

    }

}
