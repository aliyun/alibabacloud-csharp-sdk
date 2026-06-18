// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateUserDeliveryTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The real-time log type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dcdn_log_access_l1</b> (default): access log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_er</b>: edge function log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_waf</b>: WAF log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_ipa</b>: Layer-4 acceleration log.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
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
        /// <item><description><para><b>sg</b>: global (excluding the Chinese mainland).</para>
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
        /// <para>The log delivery destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sls</b>: Log Service (SLS).</para>
        /// </description></item>
        /// <item><description><para><b>http</b>: an HTTP service.</para>
        /// </description></item>
        /// <item><description><para><b>aws3</b>: Amazon S3.</para>
        /// </description></item>
        /// <item><description><para><b>oss</b>: Object Storage Service (OSS).</para>
        /// </description></item>
        /// <item><description><para><b>kafka</b>: Kafka.</para>
        /// </description></item>
        /// <item><description><para><b>aws3cmpt</b>: an S3-compatible service.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sls</para>
        /// </summary>
        [NameInMap("DeliveryType")]
        [Validation(Required=false)]
        public string DeliveryType { get; set; }

        [NameInMap("Details")]
        [Validation(Required=false)]
        public string Details { get; set; }

        /// <summary>
        /// <para>The log discard rate. Defaults to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>The fields to be delivered. Separate multiple fields with a comma.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_agent,ip_address,ip_port</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        [NameInMap("FilterVer")]
        [Validation(Required=false)]
        public string FilterVer { get; set; }

        /// <summary>
        /// <para>Configuration for delivering logs to an HTTP or HTTPS endpoint.</para>
        /// </summary>
        [NameInMap("HttpDelivery")]
        [Validation(Required=false)]
        public string HttpDeliveryShrink { get; set; }

        /// <summary>
        /// <para>Configuration for delivering logs to Kafka.</para>
        /// </summary>
        [NameInMap("KafkaDelivery")]
        [Validation(Required=false)]
        public string KafkaDeliveryShrink { get; set; }

        /// <summary>
        /// <para>Configuration for delivering logs to Object Storage Service (OSS).</para>
        /// </summary>
        [NameInMap("OssDelivery")]
        [Validation(Required=false)]
        public string OssDeliveryShrink { get; set; }

        /// <summary>
        /// <para>Configuration for delivering logs to Amazon S3 or an S3-compatible service.</para>
        /// </summary>
        [NameInMap("S3Delivery")]
        [Validation(Required=false)]
        public string S3DeliveryShrink { get; set; }

        /// <summary>
        /// <para>Configuration for delivering logs to Log Service (SLS).</para>
        /// </summary>
        [NameInMap("SlsDelivery")]
        [Validation(Required=false)]
        public string SlsDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_project</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
