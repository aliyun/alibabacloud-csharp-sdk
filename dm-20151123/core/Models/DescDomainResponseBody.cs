// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The CNAME authentication flag. 0: Succeeded. 1: Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CnameAuthStatus")]
        [Validation(Required=false)]
        public string CnameAuthStatus { get; set; }

        /// <summary>
        /// <para>Indicates whether the CNAME host record was modified. A value of 1 means the record was modified. Reverting to the original value is also considered a modification. A value of 0 means the record was not modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CnameConfirmStatus")]
        [Validation(Required=false)]
        public string CnameConfirmStatus { get; set; }

        /// <summary>
        /// <para>The custom part of the CNAME host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dmtrace</para>
        /// </summary>
        [NameInMap("CnameRecord")]
        [Validation(Required=false)]
        public string CnameRecord { get; set; }

        /// <summary>
        /// <para>The time when the domain name was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-19T12:49Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name is the default domain name.</para>
        /// <para>Value: 0 (No). This field is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        /// <summary>
        /// <para>The DKIM authentication flag. Indicates if the DKIM record in your DNS settings passed verification. 0: Passed. 1: Not passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DkimAuthStatus")]
        [Validation(Required=false)]
        public string DkimAuthStatus { get; set; }

        /// <summary>
        /// <para>The DKIM public key. This is the value of the DKIM record to configure in your DNS settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DKIM1; k=rsa; p=MIGfMA0GCSqGSI...</para>
        /// </summary>
        [NameInMap("DkimPublicKey")]
        [Validation(Required=false)]
        public string DkimPublicKey { get; set; }

        /// <summary>
        /// <para>The DKIM host record. This is the key of the DKIM record to configure in your DNS settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-cn-hangzhou._domainkey.hangzhou26</para>
        /// </summary>
        [NameInMap("DkimRR")]
        [Validation(Required=false)]
        public string DkimRR { get; set; }

        [NameInMap("DkimRsaLength")]
        [Validation(Required=false)]
        public int? DkimRsaLength { get; set; }

        /// <summary>
        /// <para>The DMARC authentication flag. Indicates if the DMARC record in your DNS settings passed verification. 0: Passed. 1: Not passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DmarcAuthStatus")]
        [Validation(Required=false)]
        public int? DmarcAuthStatus { get; set; }

        /// <summary>
        /// <para>The DMARC host record value.</para>
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
        /// <para>The DMARC record value parsed from the public domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DMARC1;p=none;rua=mailto:<a href="mailto:dmarc_report@service.aliyun.com">dmarc_report@service.aliyun.com</a></para>
        /// </summary>
        [NameInMap("DnsDmarc")]
        [Validation(Required=false)]
        public string DnsDmarc { get; set; }

        /// <summary>
        /// <para>The MX record value parsed from the public domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mx01.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("DnsMx")]
        [Validation(Required=false)]
        public string DnsMx { get; set; }

        /// <summary>
        /// <para>The SPF record value parsed from the public domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=xxxx</para>
        /// </summary>
        [NameInMap("DnsSpf")]
        [Validation(Required=false)]
        public string DnsSpf { get; set; }

        /// <summary>
        /// <para>The ownership record value parsed from the public domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c40d5f125af4e42892a</para>
        /// </summary>
        [NameInMap("DnsTxt")]
        [Validation(Required=false)]
        public string DnsTxt { get; set; }

        /// <summary>
        /// <para>The domain name ID.</para>
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
        /// <para>The domain status. This indicates whether the domain name passed authentication. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Active. The domain name passed authentication.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Inactive. The domain name failed authentication.</para>
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
        /// <para>The ownership record provided by the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c40d5f125af4e42892a</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The host record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("HostRecord")]
        [Validation(Required=false)]
        public string HostRecord { get; set; }

        /// <summary>
        /// <para>The ICP filing status. <b>1</b> indicates that the domain name has an ICP filing. <b>0</b> indicates that the domain name does not have an ICP filing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IcpStatus")]
        [Validation(Required=false)]
        public string IcpStatus { get; set; }

        /// <summary>
        /// <para>The MX authentication flag. 0: Succeeded. 1: Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MxAuthStatus")]
        [Validation(Required=false)]
        public string MxAuthStatus { get; set; }

        /// <summary>
        /// <para>The MX record value provided by the Direct Mail console.</para>
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
        /// <para>The SPF authentication flag. 0: Succeeded. 1: Failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpfAuthStatus")]
        [Validation(Required=false)]
        public string SpfAuthStatus { get; set; }

        /// <summary>
        /// <para>The SPF record value provided by the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>include:spf1.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("SpfRecord")]
        [Validation(Required=false)]
        public string SpfRecord { get; set; }

        /// <summary>
        /// <para>The SPF record. This field replaces the \<c>spfRecord\\</c> field. You can directly display the value of this field without needing to calculate it from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=spf1 include:spf1.dm.aliyun.com -all</para>
        /// </summary>
        [NameInMap("SpfRecordV2")]
        [Validation(Required=false)]
        public string SpfRecordV2 { get; set; }

        /// <summary>
        /// <para>The primary domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("TlDomainName")]
        [Validation(Required=false)]
        public string TlDomainName { get; set; }

        /// <summary>
        /// <para>The CNAME record value provided by the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tracedm.aliyuncs.com</para>
        /// </summary>
        [NameInMap("TracefRecord")]
        [Validation(Required=false)]
        public string TracefRecord { get; set; }

    }

}
