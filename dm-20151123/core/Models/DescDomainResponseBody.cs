// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>CNAME verification flag, 0 for success, 1 for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CnameAuthStatus")]
        [Validation(Required=false)]
        public string CnameAuthStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the CNAME host record has been modified, 1 for modified (reverting to the original value also counts as modification), 0 for not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CnameConfirmStatus")]
        [Validation(Required=false)]
        public string CnameConfirmStatus { get; set; }

        /// <summary>
        /// <para>Custom part of the CNAME host record</para>
        /// 
        /// <b>Example:</b>
        /// <para>dmtrace</para>
        /// </summary>
        [NameInMap("CnameRecord")]
        [Validation(Required=false)]
        public string CnameRecord { get; set; }

        /// <summary>
        /// <para>Creation time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-19T12:49Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Whether it is the default domain,</para>
        /// <para>Value: 0 No (this field is deprecated)</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        /// <summary>
        /// <para>DKIM verification flag, indicating whether the DKIM record set by the user in DNS has passed validation, 0: Passed, 1: Not passed</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DkimAuthStatus")]
        [Validation(Required=false)]
        public string DkimAuthStatus { get; set; }

        /// <summary>
        /// <para>DKIM public key value, the value that users need to set for the DKIM record in DNS</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DKIM1; k=rsa; p=MIGfMA0GCSqGSI...</para>
        /// </summary>
        [NameInMap("DkimPublicKey")]
        [Validation(Required=false)]
        public string DkimPublicKey { get; set; }

        /// <summary>
        /// <para>DKIM host record, the key that the user needs to set in the DNS for the DKIM record</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-cn-hangzhou._domainkey.hangzhou26</para>
        /// </summary>
        [NameInMap("DkimRR")]
        [Validation(Required=false)]
        public string DkimRR { get; set; }

        /// <summary>
        /// <para>DMARC verification flag, indicating whether the DMARC record set by the user in DNS has passed validation, 0: Passed, 1: Not passed</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DmarcAuthStatus")]
        [Validation(Required=false)]
        public int? DmarcAuthStatus { get; set; }

        /// <summary>
        /// <para>DMARC host record value</para>
        /// 
        /// <b>Example:</b>
        /// <para>_dmarc.xxx</para>
        /// </summary>
        [NameInMap("DmarcHostRecord")]
        [Validation(Required=false)]
        public string DmarcHostRecord { get; set; }

        /// <summary>
        /// <para>DMARC record value</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DMARC1;p=none;rua=mailto:<a href="mailto:dmarc_report@service.aliyun.com">dmarc_report@service.aliyun.com</a></para>
        /// </summary>
        [NameInMap("DmarcRecord")]
        [Validation(Required=false)]
        public string DmarcRecord { get; set; }

        /// <summary>
        /// <para>DMARC record value resolved through the public domain name</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DMARC1;p=none;rua=mailto:<a href="mailto:dmarc_report@service.aliyun.com">dmarc_report@service.aliyun.com</a></para>
        /// </summary>
        [NameInMap("DnsDmarc")]
        [Validation(Required=false)]
        public string DnsDmarc { get; set; }

        /// <summary>
        /// <para>MX record value resolved from the public network domain</para>
        /// 
        /// <b>Example:</b>
        /// <para>mx01.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("DnsMx")]
        [Validation(Required=false)]
        public string DnsMx { get; set; }

        /// <summary>
        /// <para>SPF record value resolved from the public network domain</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=xxxx</para>
        /// </summary>
        [NameInMap("DnsSpf")]
        [Validation(Required=false)]
        public string DnsSpf { get; set; }

        /// <summary>
        /// <para>Ownership record value resolved from the public network domain</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c40d5f125af4e42892a</para>
        /// </summary>
        [NameInMap("DnsTxt")]
        [Validation(Required=false)]
        public string DnsTxt { get; set; }

        /// <summary>
        /// <para>Domain ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>158910</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>Domain name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.example.net</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Domain status. Indicates whether the verification was successful, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Available, verified successfully</description></item>
        /// <item><description><b>1</b>: Unavailable, verification failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// <para>Ownership record provided by the email push console</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c40d5f125af4e42892a</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>Host record</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("HostRecord")]
        [Validation(Required=false)]
        public string HostRecord { get; set; }

        /// <summary>
        /// <para>Filing status. <b>1</b> indicates filed, <b>0</b> indicates not filed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IcpStatus")]
        [Validation(Required=false)]
        public string IcpStatus { get; set; }

        /// <summary>
        /// <para>MX verification flag, 0 for success, 1 for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MxAuthStatus")]
        [Validation(Required=false)]
        public string MxAuthStatus { get; set; }

        /// <summary>
        /// <para>MX record value provided by the email push console</para>
        /// 
        /// <b>Example:</b>
        /// <para>mx01.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("MxRecord")]
        [Validation(Required=false)]
        public string MxRecord { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>51B74264-46B4-43C8-A9A0-6B8E8BC04F34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>SPF verification flag, 0 for success, 1 for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpfAuthStatus")]
        [Validation(Required=false)]
        public string SpfAuthStatus { get; set; }

        /// <summary>
        /// <para>SPF record value provided by the email push console</para>
        /// 
        /// <b>Example:</b>
        /// <para>include:spf1.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("SpfRecord")]
        [Validation(Required=false)]
        public string SpfRecord { get; set; }

        /// <summary>
        /// <para>SPF record. Previously, the SPF display content needed to be calculated by the calling end based on the spfRecord in the response. The new field spfRecordV2 replaces spfRecord, and the calling end can directly display this field after obtaining it;</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=spf1 include:spf1.dm.aliyun.com -all</para>
        /// </summary>
        [NameInMap("SpfRecordV2")]
        [Validation(Required=false)]
        public string SpfRecordV2 { get; set; }

        /// <summary>
        /// <para>Primary domain</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("TlDomainName")]
        [Validation(Required=false)]
        public string TlDomainName { get; set; }

        /// <summary>
        /// <para>CNAME record value provided by the email push console</para>
        /// 
        /// <b>Example:</b>
        /// <para>tracedm.aliyuncs.com</para>
        /// </summary>
        [NameInMap("TracefRecord")]
        [Validation(Required=false)]
        public string TracefRecord { get; set; }

    }

}
