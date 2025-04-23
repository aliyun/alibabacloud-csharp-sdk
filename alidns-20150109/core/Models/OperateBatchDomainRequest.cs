// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class OperateBatchDomainRequest : TeaModel {
        /// <summary>
        /// <para>The DNS records. You can submit up to 1,000 DNS records.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DomainRecordInfo")]
        [Validation(Required=false)]
        public List<OperateBatchDomainRequestDomainRecordInfo> DomainRecordInfo { get; set; }
        public class OperateBatchDomainRequestDomainRecordInfo : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// <remarks>
            /// <para> You can submit 1 to 1,000 domain names. Due to the limit on the length of HTTP request headers, excessive domain names are ignored. Do not enter more than 1,000 domain names.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The DNS request source. Default value: default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            /// <summary>
            /// <para>The new hostname (used only for modification operations, not for external users).</para>
            /// 
            /// <b>Example:</b>
            /// <para>mail</para>
            /// </summary>
            [NameInMap("NewRr")]
            [Validation(Required=false)]
            public string NewRr { get; set; }

            /// <summary>
            /// <para>The new type of the DNS record (used only for modification operations, not for external users).</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAA</para>
            /// </summary>
            [NameInMap("NewType")]
            [Validation(Required=false)]
            public string NewType { get; set; }

            /// <summary>
            /// <para>The new value of the DNS record (used only for modification operations, not for external users).</para>
            /// 
            /// <b>Example:</b>
            /// <para>114.92.XX.XX</para>
            /// </summary>
            [NameInMap("NewValue")]
            [Validation(Required=false)]
            public string NewValue { get; set; }

            /// <summary>
            /// <para>The priority of the mail exchanger (MX) record.</para>
            /// <para>This parameter is required if the type of the DNS record is MX. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// <remarks>
            /// <para> This parameter is required if you set Type to <b>RR_ADD</b> or <b>RR_DEL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>zhaohui</para>
            /// </summary>
            [NameInMap("Rr")]
            [Validation(Required=false)]
            public string Rr { get; set; }

            /// <summary>
            /// <para>The time-to-live (TTL) value of the cached DNS record. Unit: seconds. Default value: <em><b>600</b></em>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The type of the DNS record. Valid values: A, AAAA, TXT, MX, and CNAME.</para>
            /// <remarks>
            /// <para> This parameter is required if you set Type to <b>RR_ADD</b> or <b>RR_DEL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>MX</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of the DNS record.</para>
            /// <remarks>
            /// <para> This parameter is required if you set Type to <b>RR_ADD</b> or <b>RR_DEL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>fd87da3c4528844d45af39200155a905</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// <para>Default value: zh</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of the batch operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DOMAIN_ADD</b>: adds domain names in batches.</description></item>
        /// <item><description><b>DOMAIN_DEL</b>: deletes domain names in batches.</description></item>
        /// <item><description><b>RR_ADD</b>: adds DNS records in batches.</description></item>
        /// <item><description><b>RR_DEL</b>: deletes DNS records in batches. This operation deletes the DNS records with the specified hostname or record value. If you do not specify the Rr and Value parameters, this operation deletes the DNS records that are added for the specified domain names.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RR_ADD</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
