// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUserDeliveryTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The business type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dcdn_log_access_l1</b> (default): access log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_er</b>: edge function log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_waf</b>: WAF log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_ipa</b>: Layer 4 acceleration log.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_er</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The data center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn</b>: Chinese mainland</para>
        /// </description></item>
        /// <item><description><para><b>sg</b>: Global (excluding the Chinese mainland)</para>
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
        /// <item><description><para><b>sls</b>: Log Service</para>
        /// </description></item>
        /// <item><description><para><b>http</b>: HTTP service</para>
        /// </description></item>
        /// <item><description><para><b>aws3</b>: Amazon S3</para>
        /// </description></item>
        /// <item><description><para><b>oss</b>: OSS</para>
        /// </description></item>
        /// <item><description><para><b>kafka</b>: Kafka service</para>
        /// </description></item>
        /// <item><description><para><b>aws3cmpt</b>: Amazon S3-compatible service</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        [NameInMap("Details")]
        [Validation(Required=false)]
        public string Details { get; set; }

        /// <summary>
        /// <para>The discard rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>A comma-separated list of fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ClientRequestID,ClientRequestHost</para>
        /// </summary>
        [NameInMap("FieldList")]
        [Validation(Required=false)]
        public string FieldList { get; set; }

        /// <summary>
        /// <para>The filter rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ClientSSLProtocol&quot;: {&quot;equals&quot;: [&quot;TLSv1.3&quot;]}}]</para>
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
        /// <para>7072132a-bd3c-46a6-9e81-aba3e0e3f861</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The delivery configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Project\&quot;: \&quot;er-online-hjy-pro\&quot;, \&quot;Logstore\&quot;: \&quot;er-online-hjy-log\&quot;, \&quot;Region\&quot;: \&quot;cn-hangzhou\&quot;, \&quot;Endpoint\&quot;: \&quot;cn-hangzhou.log.aliyuncs.com\&quot;, \&quot;Aliuid\&quot;: \&quot;1077912128805410\&quot;}</para>
        /// </summary>
        [NameInMap("SinkConfig")]
        [Validation(Required=false)]
        public object SinkConfig { get; set; }

        /// <summary>
        /// <para>The task status.</para>
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
        /// <para>testoss11</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
