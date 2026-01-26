// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCustomHostnameResponseBody : TeaModel {
        [NameInMap("CustomHostnameModel")]
        [Validation(Required=false)]
        public GetCustomHostnameResponseBodyCustomHostnameModel CustomHostnameModel { get; set; }
        public class GetCustomHostnameResponseBodyCustomHostnameModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30000478</para>
            /// </summary>
            [NameInMap("CasId")]
            [Validation(Required=false)]
            public long? CasId { get; set; }

            /// <summary>
            /// <para>免费证书申请错误码</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CertApplyCode")]
            [Validation(Required=false)]
            public long? CertApplyCode { get; set; }

            /// <summary>
            /// <para>免费证书申请错误说明</para>
            /// 
            /// <b>Example:</b>
            /// <para>canceled</para>
            /// </summary>
            [NameInMap("CertApplyMessage")]
            [Validation(Required=false)]
            public string CertApplyMessage { get; set; }

            /// <summary>
            /// <para>证书校验HTTP名称</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://custom.site.com/.well-known/acme-challenge/jLmMHlEaZ3jb352Qo3ciaSoAC8KZ5Hk0F-4_1xLQtgc">http://custom.site.com/.well-known/acme-challenge/jLmMHlEaZ3jb352Qo3ciaSoAC8KZ5Hk0F-4_1xLQtgc</a></para>
            /// </summary>
            [NameInMap("CertHttpKey")]
            [Validation(Required=false)]
            public string CertHttpKey { get; set; }

            /// <summary>
            /// <para>证书校验HTTP内容</para>
            /// 
            /// <b>Example:</b>
            /// <para>jLmMHlEaZ3jb352Qo3ciaSoAC8KZ5Hk0F-4_1xLQtgc.GridYdfJJB5PgFEL-t89XfaFvMPB4f2-I9fwLpKl6e0</para>
            /// </summary>
            [NameInMap("CertHttpValue")]
            [Validation(Required=false)]
            public string CertHttpValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>baba2c9e90e840b3b55698cedf02b308</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>证书过期时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-19T11:15:20Z</para>
            /// </summary>
            [NameInMap("CertNotAfter")]
            [Validation(Required=false)]
            public string CertNotAfter { get; set; }

            /// <summary>
            /// <para>证书状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("CertStatus")]
            [Validation(Required=false)]
            public string CertStatus { get; set; }

            /// <summary>
            /// <para>证书校验TXT名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>_acme-challenge.custom.site.com</para>
            /// </summary>
            [NameInMap("CertTxtKey")]
            [Validation(Required=false)]
            public string CertTxtKey { get; set; }

            /// <summary>
            /// <para>证书校验TXT内容</para>
            /// 
            /// <b>Example:</b>
            /// <para>lcKYad3UQXgrZLvMm_6TBUYKK4xTkGmninV0Mzx4gjM</para>
            /// </summary>
            [NameInMap("CertTxtValue")]
            [Validation(Required=false)]
            public string CertTxtValue { get; set; }

            /// <summary>
            /// <para>证书类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>上传的证书公钥</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN CERTIFICATE-----</para>
            /// </summary>
            [NameInMap("Certificate")]
            [Validation(Required=false)]
            public string Certificate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>existing_custom_hostname</para>
            /// </summary>
            [NameInMap("ConflictWith")]
            [Validation(Required=false)]
            public string ConflictWith { get; set; }

            /// <summary>
            /// <para>创建时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-19T11:15:20Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>用户自定义的主机名</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom.site.com</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567890123</para>
            /// </summary>
            [NameInMap("HostnameId")]
            [Validation(Required=false)]
            public long? HostnameId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>missing_icp</para>
            /// </summary>
            [NameInMap("OfflineReason")]
            [Validation(Required=false)]
            public string OfflineReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-----BEGIN RSA PRIVATE KEY-----</para>
            /// </summary>
            [NameInMap("PrivateKey")]
            [Validation(Required=false)]
            public string PrivateKey { get; set; }

            /// <summary>
            /// <para>绑定的源站记录ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>4042843419650112</para>
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// <para>绑定的源站记录名</para>
            /// 
            /// <b>Example:</b>
            /// <para>origin.example.com</para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>与主机名关联的站点ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>890601022130656</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public long? SiteId { get; set; }

            /// <summary>
            /// <para>关联站点名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>SSL开关的状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SslFlag")]
            [Validation(Required=false)]
            public string SslFlag { get; set; }

            /// <summary>
            /// <para>自定义主机名状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>更新时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-04-19T11:15:20Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>归属校验TXT内容</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_16ab7f4d389d4dff6655f995c6a997bd</para>
            /// </summary>
            [NameInMap("VerifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            /// <summary>
            /// <para>归属校验TXT名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>_esa_custom_hostname.custom.site.com</para>
            /// </summary>
            [NameInMap("VerifyHost")]
            [Validation(Required=false)]
            public string VerifyHost { get; set; }

        }

        /// <summary>
        /// <para>本次请求的唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C414690-9D7B-5D66-9CD9-AD0B3F25ED49</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
