// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The CNAME verification status. Valid values: <c>0</c> (Success), <c>1</c> (Failure).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CnameAuthStatus")]
        [Validation(Required=false)]
        public string CnameAuthStatus { get; set; }

        /// <summary>
        /// <para>Indicates if the CNAME host record has been modified. A value of <c>1</c> indicates a change, including reverting to the original value. A value of <c>0</c> indicates no change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CnameConfirmStatus")]
        [Validation(Required=false)]
        public string CnameConfirmStatus { get; set; }

        /// <summary>
        /// <para>The CNAME host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dmtrace</para>
        /// </summary>
        [NameInMap("CnameRecord")]
        [Validation(Required=false)]
        public string CnameRecord { get; set; }

        /// <summary>
        /// <para>The time the domain name was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-19T12:49Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates if this is the default domain name.</para>
        /// <para>This parameter is deprecated and always returns <c>0</c> (No).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        /// <summary>
        /// <para>The DKIM verification status. Valid values: <c>0</c> (Verified), <c>1</c> (Not verified).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DkimAuthStatus")]
        [Validation(Required=false)]
        public string DkimAuthStatus { get; set; }

        /// <summary>
        /// <para>The public key for the DKIM record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DKIM1; k=rsa; p=MIGfMA0GCSqGSI...</para>
        /// </summary>
        [NameInMap("DkimPublicKey")]
        [Validation(Required=false)]
        public string DkimPublicKey { get; set; }

        /// <summary>
        /// <para>The DKIM host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-cn-hangzhou._domainkey.hangzhou26</para>
        /// </summary>
        [NameInMap("DkimRR")]
        [Validation(Required=false)]
        public string DkimRR { get; set; }

        /// <summary>
        /// <para>The length of the DKIM RSA key, such as <c>1024</c> or <c>2048</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("DkimRsaLength")]
        [Validation(Required=false)]
        public int? DkimRsaLength { get; set; }

        /// <summary>
        /// <para>The DMARC verification status. Valid values: <c>0</c> (Verified), <c>1</c> (Not verified).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DmarcAuthStatus")]
        [Validation(Required=false)]
        public int? DmarcAuthStatus { get; set; }

        /// <summary>
        /// <para>The DMARC host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>_dmarc.xxx</para>
        /// </summary>
        [NameInMap("DmarcHostRecord")]
        [Validation(Required=false)]
        public string DmarcHostRecord { get; set; }

        /// <summary>
        /// <para>The DMARC record value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DMARC1;p=none;rua=mailto:<a href="mailto:dmarc_report@service.aliyun.com">dmarc_report@service.aliyun.com</a></para>
        /// </summary>
        [NameInMap("DmarcRecord")]
        [Validation(Required=false)]
        public string DmarcRecord { get; set; }

        /// <summary>
        /// <para>The DMARC record value resolved from public DNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DMARC1;p=none;rua=mailto:<a href="mailto:dmarc_report@service.aliyun.com">dmarc_report@service.aliyun.com</a></para>
        /// </summary>
        [NameInMap("DnsDmarc")]
        [Validation(Required=false)]
        public string DnsDmarc { get; set; }

        /// <summary>
        /// <para>The MX record value resolved from public DNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mx01.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("DnsMx")]
        [Validation(Required=false)]
        public string DnsMx { get; set; }

        /// <summary>
        /// <para>The SPF record value resolved from public DNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=xxxx</para>
        /// </summary>
        [NameInMap("DnsSpf")]
        [Validation(Required=false)]
        public string DnsSpf { get; set; }

        /// <summary>
        /// <para>The ownership record value resolved from public DNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c40d5f125af4e42892a</para>
        /// </summary>
        [NameInMap("DnsTxt")]
        [Validation(Required=false)]
        public string DnsTxt { get; set; }

        /// <summary>
        /// <para>The domain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158910</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.net</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The verification status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Available. The domain name is verified.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Unavailable. The domain name failed verification.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// <para>The required value for the domain ownership verification record, from the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c40d5f125af4e42892a</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        [NameInMap("DomainVersion")]
        [Validation(Required=false)]
        public int? DomainVersion { get; set; }

        /// <summary>
        /// <para>The host record for domain ownership verification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("HostRecord")]
        [Validation(Required=false)]
        public string HostRecord { get; set; }

        /// <summary>
        /// <para>The ICP filing status. <b>1</b> indicates the filing is complete. <b>0</b> indicates no filing is found.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IcpStatus")]
        [Validation(Required=false)]
        public string IcpStatus { get; set; }

        /// <summary>
        /// <para>The MX verification status. Valid values: <c>0</c> (Success), <c>1</c> (Failure).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MxAuthStatus")]
        [Validation(Required=false)]
        public string MxAuthStatus { get; set; }

        /// <summary>
        /// <para>The MX record value from the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mx01.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("MxRecord")]
        [Validation(Required=false)]
        public string MxRecord { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51B74264-46B4-43C8-A9A0-6B8E8BC04F34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SPF verification status. Valid values: <c>0</c> (Success), <c>1</c> (Failure).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpfAuthStatus")]
        [Validation(Required=false)]
        public string SpfAuthStatus { get; set; }

        /// <summary>
        /// <para>The SPF record value from the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>include:spf1.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("SpfRecord")]
        [Validation(Required=false)]
        public string SpfRecord { get; set; }

        /// <summary>
        /// <para>The complete SPF record. This parameter replaces <c>SpfRecord</c>. You can directly use the value of <c>SpfRecordV2</c> without constructing it from the value of <c>SpfRecord</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=spf1 include:spf1.dm.aliyun.com -all</para>
        /// </summary>
        [NameInMap("SpfRecordV2")]
        [Validation(Required=false)]
        public string SpfRecordV2 { get; set; }

        /// <summary>
        /// <para>The root domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("TlDomainName")]
        [Validation(Required=false)]
        public string TlDomainName { get; set; }

        /// <summary>
        /// <para>The CNAME record value from the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tracedm.aliyuncs.com</para>
        /// </summary>
        [NameInMap("TracefRecord")]
        [Validation(Required=false)]
        public string TracefRecord { get; set; }

    }

}
