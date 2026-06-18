// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRecordShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The origin authentication settings for the CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public string AuthConfShrink { get; set; }

        /// <summary>
        /// <para>The use case for proxy acceleration. Omit this parameter if proxy acceleration is disabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>video_image</b>: Video and images.</para>
        /// </description></item>
        /// <item><description><para><b>api</b>: APIs.</para>
        /// </description></item>
        /// <item><description><para><b>web</b>: Web pages.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>A comment for the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS data for the record. The required content varies based on the record type. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/document_detail/2708761.html">Documentation</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Documentation</a>.</para>
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
        /// <para>The origin HOST policy. This policy, which applies only to CNAME records, determines the value of the <c>HOST</c> header in requests sent to the origin. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>follow_hostname</b>: Follows the host record.</para>
        /// </description></item>
        /// <item><description><para><b>follow_origin_domain</b>: Follows the origin domain name.</para>
        /// </description></item>
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
        /// <para>Indicates whether to enable proxy acceleration for the record. Only CNAME and A/AAAA records support proxy acceleration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables proxy acceleration.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables proxy acceleration.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>The record ID. Call the <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a> operation to get this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The origin type for the CNAME record. This parameter is required for CNAME records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>OSS</b>: An OSS origin.</para>
        /// </description></item>
        /// <item><description><para><b>S3</b>: An S3 origin.</para>
        /// </description></item>
        /// <item><description><para><b>LB</b>: A load balancer origin.</para>
        /// </description></item>
        /// <item><description><para><b>OP</b>: An origin address pool origin.</para>
        /// </description></item>
        /// <item><description><para><b>Domain</b>: A standard domain name origin.</para>
        /// </description></item>
        /// </list>
        /// <para>If this parameter is omitted or left empty, the default value is <c>Domain</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The record\&quot;s time to live (TTL) in seconds. The value must be an integer from <b>30 to 86400</b> or 1. A value of 1 sets the TTL to automatic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
