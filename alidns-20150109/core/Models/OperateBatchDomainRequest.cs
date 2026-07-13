// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class OperateBatchDomainRequest : TeaModel {
        /// <summary>
        /// <para>The data for the batch operation.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DomainRecordInfo")]
        [Validation(Required=false)]
        public List<OperateBatchDomainRequestDomainRecordInfo> DomainRecordInfo { get; set; }
        public class OperateBatchDomainRequestDomainRecordInfo : TeaModel {
            /// <summary>
            /// <para>The domain name.</para>
            /// <remarks>
            /// <para>A single request can contain up to 200 entries. Exceeding this limit may cause the request to fail due to the HTTP request header size limit.</para>
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
            /// <para>The resolution line. Default value: default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Line")]
            [Validation(Required=false)]
            public string Line { get; set; }

            /// <summary>
            /// <para>The new host record. This parameter is used only for modification operations and is for internal use only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mail</para>
            /// </summary>
            [NameInMap("NewRr")]
            [Validation(Required=false)]
            public string NewRr { get; set; }

            /// <summary>
            /// <para>The new record type. This parameter is used only for modification operations and is for internal use only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAAA</para>
            /// </summary>
            [NameInMap("NewType")]
            [Validation(Required=false)]
            public string NewType { get; set; }

            /// <summary>
            /// <para>The new record value. This parameter is used only for modification operations and is for internal use only.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114.92.XX.XX</para>
            /// </summary>
            [NameInMap("NewValue")]
            [Validation(Required=false)]
            public string NewValue { get; set; }

            /// <summary>
            /// <para>The MX priority.</para>
            /// <para>This parameter is required if the record type is MX. Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The host record.</para>
            /// <remarks>
            /// <para>This parameter is required when <c>Type</c> is <b>RR_ADD</b> or <b>RR_DEL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>zhaohui</para>
            /// </summary>
            [NameInMap("Rr")]
            [Validation(Required=false)]
            public string Rr { get; set; }

            /// <summary>
            /// <para>The TTL, in seconds. Default value: <em><b>600</b></em>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

            /// <summary>
            /// <para>The record type. Examples: A, AAAA, TXT, MX, and CNAME.</para>
            /// <remarks>
            /// <para>This parameter is required when <c>Type</c> is <b>RR_ADD</b> or <b>RR_DEL</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>MX</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The record value.</para>
            /// <remarks>
            /// <para>This parameter is required when <c>Type</c> is <b>RR_ADD</b> or <b>RR_DEL</b>.</para>
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
        /// <para>The response language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
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
        /// <para>The batch operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DOMAIN_ADD</b>: adds domain names in batches.</para>
        /// </description></item>
        /// <item><description><para><b>DOMAIN_DEL</b>: deletes domain names in batches.</para>
        /// </description></item>
        /// <item><description><para><b>RR_ADD</b>: adds DNS records in batches.</para>
        /// </description></item>
        /// <item><description><para><b>RR_DEL</b>: deletes DNS records in batches. This operation deletes DNS records that match the conditions specified by <c>Rr</c>, <c>Value</c>, or both. If you do not specify <c>Rr</c> and <c>Value</c>, all DNS records for the specified domain name are deleted.</para>
        /// </description></item>
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
