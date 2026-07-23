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
        /// <item><description><b>dcdn_log_access_l1 (default)</b>: access logs.</description></item>
        /// <item><description><b>dcdn_log_er</b>: edge function logs.</description></item>
        /// <item><description><b>dcdn_log_waf</b>: security protection logs.</description></item>
        /// <item><description><b>dcdn_log_ipa</b>: Layer 4 acceleration logs.</description></item>
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
        /// <item><description><b>cn</b>: Chinese mainland.</description></item>
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
        /// <para>The discard rate. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>The fields to be selected, separated by commas (,).</para>
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
        /// <para>The HTTP delivery configuration parameters.</para>
        /// </summary>
        [NameInMap("HttpDelivery")]
        [Validation(Required=false)]
        public string HttpDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The Kafka delivery configuration parameters.</para>
        /// </summary>
        [NameInMap("KafkaDelivery")]
        [Validation(Required=false)]
        public string KafkaDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The OSS delivery configuration parameters.</para>
        /// </summary>
        [NameInMap("OssDelivery")]
        [Validation(Required=false)]
        public string OssDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The S3 or S3-compatible delivery configuration parameters.</para>
        /// </summary>
        [NameInMap("S3Delivery")]
        [Validation(Required=false)]
        public string S3DeliveryShrink { get; set; }

        /// <summary>
        /// <para>The SLS delivery configuration.</para>
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
