// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class DescDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>Track verification</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CnameAuthStatus")]
        [Validation(Required=false)]
        public string CnameAuthStatus { get; set; }

        /// <summary>
        /// <para>CName verification flag, success: 0, failure: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CnameConfirmStatus")]
        [Validation(Required=false)]
        public string CnameConfirmStatus { get; set; }

        /// <summary>
        /// <para>CNAME records</para>
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
        /// <para>2019-09-29T12:49Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Default domain name</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        /// <summary>
        /// <para>DKIM validation flag, success: 0, failure: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DkimAuthStatus")]
        [Validation(Required=false)]
        public string DkimAuthStatus { get; set; }

        /// <summary>
        /// <para>DKIM public key</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DKIM1; k=rsa; p=MIGfMA0GCSqGSI...</para>
        /// </summary>
        [NameInMap("DkimPublicKey")]
        [Validation(Required=false)]
        public string DkimPublicKey { get; set; }

        /// <summary>
        /// <para>DKIM HostRecord</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-cn-hangzhou._domainkey.hangzhou26</para>
        /// </summary>
        [NameInMap("DkimRR")]
        [Validation(Required=false)]
        public string DkimRR { get; set; }

        /// <summary>
        /// <para>DMARC validation flag, success: 0, failure: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DmarcAuthStatus")]
        [Validation(Required=false)]
        public int? DmarcAuthStatus { get; set; }

        /// <summary>
        /// <para>DMARC host record</para>
        /// 
        /// <b>Example:</b>
        /// <para>_dmarc.xxx</para>
        /// </summary>
        [NameInMap("DmarcHostRecord")]
        [Validation(Required=false)]
        public string DmarcHostRecord { get; set; }

        /// <summary>
        /// <para>DMARC record</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DMARC1;p=none;rua=mailto:<a href="mailto:dmarc_report@service.aliyun.com">dmarc_report@service.aliyun.com</a></para>
        /// </summary>
        [NameInMap("DmarcRecord")]
        [Validation(Required=false)]
        public string DmarcRecord { get; set; }

        /// <summary>
        /// <para>dmarc record value resolved through public DNS</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=DMARC1;p=none;rua=mailto:<a href="mailto:dmarc_report@service.aliyun.com">dmarc_report@service.aliyun.com</a></para>
        /// </summary>
        [NameInMap("DnsDmarc")]
        [Validation(Required=false)]
        public string DnsDmarc { get; set; }

        /// <summary>
        /// <para>MX record value resolved through public DNS</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc-com.xxxx.com</para>
        /// </summary>
        [NameInMap("DnsMx")]
        [Validation(Required=false)]
        public string DnsMx { get; set; }

        /// <summary>
        /// <para>SPF record value resolved through public DNS</para>
        /// 
        /// <b>Example:</b>
        /// <para>v=xxxx</para>
        /// </summary>
        [NameInMap("DnsSpf")]
        [Validation(Required=false)]
        public string DnsSpf { get; set; }

        /// <summary>
        /// <para>TXT record value resolved through public DNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121309ohdsa</para>
        /// </summary>
        [NameInMap("DnsTxt")]
        [Validation(Required=false)]
        public string DnsTxt { get; set; }

        /// <summary>
        /// <para>The ID of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>158910</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>domain</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.net</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The status of the domain name. Indicates whether the domain name is verified and available. Valid values:</para>
        /// <para>0: indicates that the domain name is verified and available.</para>
        /// <para>1: indicates that the domain name fails to be verified and is unavailable.</para>
        /// <para>2: indicates that the domain name is available, but not filed or configured with a CNAME record.</para>
        /// <para>3: indicates that the domain name is available but not filed.</para>
        /// <para>4: indicates that the domain name is available but not configured with a CNAME record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public string DomainStatus { get; set; }

        /// <summary>
        /// <para>TXT records provided by the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c40d5f125af4e42892a</para>
        /// </summary>
        [NameInMap("DomainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>host record</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("HostRecord")]
        [Validation(Required=false)]
        public string HostRecord { get; set; }

        /// <summary>
        /// <para>Filing status. 1 indicates that it has been filed, and 0 indicates that it has not been filed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IcpStatus")]
        [Validation(Required=false)]
        public string IcpStatus { get; set; }

        /// <summary>
        /// <para>MX validation flag, success: 0, failure: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MxAuthStatus")]
        [Validation(Required=false)]
        public string MxAuthStatus { get; set; }

        /// <summary>
        /// <para>MX record</para>
        /// 
        /// <b>Example:</b>
        /// <para>mx01.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("MxRecord")]
        [Validation(Required=false)]
        public string MxRecord { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51B74264-46B4-43C8-A9A0-6B8E8BC04F34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>SPF validation flag, success: 0, failure: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpfAuthStatus")]
        [Validation(Required=false)]
        public string SpfAuthStatus { get; set; }

        /// <summary>
        /// <para>Spf record</para>
        /// 
        /// <b>Example:</b>
        /// <para>include:spf1.dm.aliyun.com</para>
        /// </summary>
        [NameInMap("SpfRecord")]
        [Validation(Required=false)]
        public string SpfRecord { get; set; }

        /// <summary>
        /// <para>SpfRecord</para>
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
        /// <para>example.net</para>
        /// </summary>
        [NameInMap("TlDomainName")]
        [Validation(Required=false)]
        public string TlDomainName { get; set; }

        /// <summary>
        /// <para>The CNAME verification record provided by the Direct Mail console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tracedm.aliyuncs.com</para>
        /// </summary>
        [NameInMap("TracefRecord")]
        [Validation(Required=false)]
        public string TracefRecord { get; set; }

    }

}
