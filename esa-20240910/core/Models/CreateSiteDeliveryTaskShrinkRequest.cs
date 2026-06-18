// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteDeliveryTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dcdn_log_access_l1</b> (default): access log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_er</b>: edge function log.</para>
        /// </description></item>
        /// <item><description><para><b>dcdn_log_waf</b>: WAF protection log.</para>
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
        /// <item><description><para><b>oversea</b>: regions outside the Chinese mainland.</para>
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
        /// <para>The type of the delivery destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sls</b>: Log Service.</para>
        /// </description></item>
        /// <item><description><para><b>http</b>: an HTTP service.</para>
        /// </description></item>
        /// <item><description><para><b>aws3</b>: Amazon S3.</para>
        /// </description></item>
        /// <item><description><para><b>oss</b>: Object Storage Service.</para>
        /// </description></item>
        /// <item><description><para><b>kafka</b>: a Kafka service.</para>
        /// </description></item>
        /// <item><description><para><b>aws3cmpt</b>: an Amazon S3-compatible service.</para>
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

        /// <summary>
        /// <para>The discard rate. If you do not specify this parameter, the default value 0 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>The log fields for delivery. Separate multiple fields with a comma (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_agent,ip_adress,ip_port</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        [NameInMap("FilterVer")]
        [Validation(Required=false)]
        public string FilterVer { get; set; }

        /// <summary>
        /// <para>The parameters for delivering logs to an HTTP server.</para>
        /// </summary>
        [NameInMap("HttpDelivery")]
        [Validation(Required=false)]
        public string HttpDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The parameters for delivering logs to a Kafka cluster.</para>
        /// </summary>
        [NameInMap("KafkaDelivery")]
        [Validation(Required=false)]
        public string KafkaDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The parameters for delivering logs to Object Storage Service (OSS).</para>
        /// </summary>
        [NameInMap("OssDelivery")]
        [Validation(Required=false)]
        public string OssDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The parameters for delivering logs to an Amazon S3 bucket or an S3-compatible service.</para>
        /// </summary>
        [NameInMap("S3Delivery")]
        [Validation(Required=false)]
        public string S3DeliveryShrink { get; set; }

        /// <summary>
        /// <para>The ID of the site. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312312112***</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The parameters for delivering logs to Log Service.</para>
        /// </summary>
        [NameInMap("SlsDelivery")]
        [Validation(Required=false)]
        public string SlsDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn-test-task</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
