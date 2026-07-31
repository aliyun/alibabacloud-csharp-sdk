// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteDeliveryTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The real-time log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dcdn_log_access_l1 (default)</b>: access log.</description></item>
        /// <item><description><b>dcdn_log_er</b>: Edge Routine function log.</description></item>
        /// <item><description><b>dcdn_log_waf</b>: security protection log.</description></item>
        /// <item><description><b>dcdn_log_ipa</b>: Layer 4 acceleration log.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The data center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn</b>: the Chinese mainland.</description></item>
        /// <item><description><b>sg</b>: global (excluding the Chinese mainland).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The delivery type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sls</b>: Alibaba Cloud Simple Log Service.</description></item>
        /// <item><description><b>http</b>: HTTP service.</description></item>
        /// <item><description><b>aws3</b>: Amazon S3 service.</description></item>
        /// <item><description><b>oss</b>: Alibaba Cloud Object Storage Service.</description></item>
        /// <item><description><b>kafka</b>: Kafka service.</description></item>
        /// <item><description><b>aws3cmpt</b>: Amazon S3-compatible service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        /// <summary>
        /// <para>The discard rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>The list of delivery fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Client,UserAgent</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public string FieldList { get; set; }

        /// <summary>
        /// <para>The filter rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("FilterRules")]
        [Validation(Required=false)]
        public string FilterRules { get; set; }

        /// <summary>
        /// <para>The version of the filter rules.</para>
        /// <remarks>
        /// <para>For backward compatibility with legacy filter rules, the default value is v1. Newly created tasks use v2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("FilterVer")]
        [Validation(Required=false)]
        public string FilterVer { get; set; }

        /// <summary>
        /// <para>The filter rules for the delivery task.</para>
        /// <remarks>
        /// <para>The new version of delivery filter rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;where&quot;: {
        ///     &quot;or&quot;: [
        ///       {
        ///         &quot;and&quot;: [
        ///           { &quot;key&quot;: &quot;site&quot;, &quot;operator&quot;: &quot;eq&quot;, &quot;value&quot;: &quot;example.com&quot; },
        ///           { &quot;key&quot;: &quot;status_code&quot;, &quot;operator&quot;: &quot;in&quot;, &quot;value&quot;: [&quot;200&quot;, &quot;304&quot;] }
        ///         ]
        ///       }
        ///     ]
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("RawRule")]
        [Validation(Required=false)]
        public string RawRule { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34DCBC8A-<b><b>-</b></b>-****-6DAA11D7DDBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The delivery configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Region\&quot;: \&quot;cn-hangzhou\&quot;, \&quot;Endpoint\&quot;: \&quot;https://***.oss-cn-hangzhou.aliyuncs.com\&quot;, \&quot;BucketPath\&quot;: \&quot;hjy-test002/online-logs\&quot;}</para>
        /// </summary>
        [NameInMap("SinkConfig")]
        [Validation(Required=false)]
        public object SinkConfig { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.***.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>online</b>: pushing.</para>
        /// </description></item>
        /// <item><description><para><b>offline</b>: push paused.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cdn-test-task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
