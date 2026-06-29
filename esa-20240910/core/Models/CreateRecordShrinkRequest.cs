// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRecordShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The origin authentication information for the CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public string AuthConfShrink { get; set; }

        /// <summary>
        /// <para>Used to tag the business scenario of the DNS record. This parameter is required when proxy acceleration is enabled for the DNS record (i.e., when the proxied parameter is set to true), and is not required when proxy acceleration is disabled (i.e., when the proxied parameter is set to false). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>image_video</b>: Image and video.</description></item>
        /// <item><description><b>api</b>: API.</description></item>
        /// <item><description><b>web</b>: Web page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The comment for the record, with a maximum length of 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS information of the record. Different types of records require different content for this field. For more information, see
        /// &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">Documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Documentation</a>
        /// .</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;value&quot;:&quot;2.2.2.2&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string DataShrink { get; set; }

        /// <summary>
        /// <para>The origin host policy. This takes effect when the record type is CNAME. It specifies the host policy for back-to-origin requests. Two modes are available:</para>
        /// <list type="bullet">
        /// <item><description><b>follow_hostname</b>: Follow the request host.</description></item>
        /// <item><description><b>follow_origin_domain</b>: Follow the origin domain.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>follow_origin_domain</para>
        /// </summary>
        [NameInMap("HostPolicy")]
        [Validation(Required=false)]
        public string HostPolicy { get; set; }

        [NameInMap("HttpPorts")]
        [Validation(Required=false)]
        public string HttpPorts { get; set; }

        [NameInMap("HttpsPorts")]
        [Validation(Required=false)]
        public string HttpsPorts { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable proxy acceleration for the record. Only CNAME records or A/AAAA records (i.e., when the type parameter is set to A/AAAA or CNAME) can enable proxy acceleration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable proxy acceleration.</description></item>
        /// <item><description><b>false</b>: Disable proxy acceleration.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>The record name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("RecordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The origin type of the CNAME record. This parameter is required when adding a CNAME record (i.e., when the type parameter is set to CNAME). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b>: OSS origin.</description></item>
        /// <item><description><b>S3</b>: S3 origin.</description></item>
        /// <item><description><b>LB</b>: Load balancer origin.</description></item>
        /// <item><description><b>OP</b>: Origin pool origin.</description></item>
        /// <item><description><b>Domain</b>: Standard domain origin.</description></item>
        /// </list>
        /// <para>If this parameter is not specified or is left empty, it defaults to Domain, which is the standard domain origin type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The time-to-live (TTL) of the record, in seconds. When set to 1, the TTL is automatic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// <para>The DNS type of the record, such as <b>A/AAAA</b>, <b>CNAME</b>, <b>TXT</b>, etc.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A/AAAA</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
