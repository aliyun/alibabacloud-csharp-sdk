// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRecordShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The origin authentication information of the CNAME record.</para>
        /// </summary>
        [NameInMap("AuthConf")]
        [Validation(Required=false)]
        public string AuthConfShrink { get; set; }

        /// <summary>
        /// <para>The business scenario of the record for acceleration. Leave the parameter empty if your record is not proxied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video_image</b>: video and image.</description></item>
        /// <item><description><b>api</b>: API.</description></item>
        /// <item><description><b>web</b>: web page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The comments of the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a remark.</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The DNS record information. The format of this field varies based on the record type. For more information, see <a href="https://www.alibabacloud.com/help/doc-detail/2708761.html">Add DNS records</a>.</para>
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
        /// <para>The origin host policy. This policy takes effect when the record type is CNAME. You can set the policy in two modes:</para>
        /// <list type="bullet">
        /// <item><description><b>follow_hostname</b>: match the requested domain name.</description></item>
        /// <item><description><b>follow_origin_domain</b>: match the origin\&quot;s domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>follow_origin_domain</para>
        /// </summary>
        [NameInMap("HostPolicy")]
        [Validation(Required=false)]
        public string HostPolicy { get; set; }

        /// <summary>
        /// <para>Specifies whether to proxy the record. Only CNAME and A/AAAA records can be proxied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Proxied")]
        [Validation(Required=false)]
        public bool? Proxied { get; set; }

        /// <summary>
        /// <para>The record ID, which can be obtained by calling <a href="https://help.aliyun.com/document_detail/2850265.html">ListRecords</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("RecordId")]
        [Validation(Required=false)]
        public long? RecordId { get; set; }

        /// <summary>
        /// <para>The type of the origin for the CNAME record. This parameter is required when you add a CNAME record. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OSS</b> : OSS origin.</description></item>
        /// <item><description><b>S3</b> : S3 origin.</description></item>
        /// <item><description><b>LB</b>: Load Balancer origin.</description></item>
        /// <item><description><b>OP</b>: origin in an origin pool.</description></item>
        /// <item><description><b>Domain</b>: common domain name.</description></item>
        /// </list>
        /// <para>If you leave the parameter empty or set its value as null, the default is Domain, which is common domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The TTL of the record. Unit: seconds. The range is 30 to 86,400, or 1. If the value is 1, the TTL of the record is determined by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
