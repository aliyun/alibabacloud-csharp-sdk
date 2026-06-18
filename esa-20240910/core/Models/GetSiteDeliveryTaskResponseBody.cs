// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteDeliveryTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of real-time log for Dynamic Route for CDN (DCDN). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dcdn_log_access_l1</b> (default): access log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_er</b>: edge function log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_waf</b>: WAF log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_ipa</b>: layer 4 acceleration log.</para>
        /// </description></item>
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
        /// <item><description><para><b>cn</b>: Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>sg</b>: Global (excluding Chinese mainland). Note that the value for this region is &quot;sg&quot;.</para>
        /// </description></item>
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
        /// <item><description><para><b>sls</b>: Log Service.</para>
        /// </description></item>
        /// <item><description><para><b>http</b>: HTTP service.</para>
        /// </description></item>
        /// <item><description><para><b>aws3</b>: Amazon S3.</para>
        /// </description></item>
        /// <item><description><para><b>oss</b>: Object Storage Service.</para>
        /// </description></item>
        /// <item><description><para><b>kafka</b>: Kafka service.</para>
        /// </description></item>
        /// <item><description><para><b>aws3cmpt</b>: Amazon S3-compatible service.</para>
        /// </description></item>
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
        /// <para>A comma-separated list of log fields to deliver.</para>
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

        [NameInMap("FilterVer")]
        [Validation(Required=false)]
        public string FilterVer { get; set; }

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
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>online</b>: The task is delivering logs.</para>
        /// </description></item>
        /// <item><description><para><b>offline</b>: The task is paused.</para>
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
