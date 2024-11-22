// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteDeliveryTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The log category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dcdn_log_access_l1</b> (default): access logs.</description></item>
        /// <item><description><b>dcdn_log_er</b>: Edge Routine logs.</description></item>
        /// <item><description><b>dcdn_log_waf</b>: firewall logs.</description></item>
        /// <item><description><b>dcdn_log_ipa</b>: TCP/UDP proxy logs.</description></item>
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
        /// <item><description>cn: the Chinese mainland.</description></item>
        /// <item><description>oversea: outside the Chinese mainland.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The destination of the delivery. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sls: Alibaba Cloud Simple Log Service (SLS).</description></item>
        /// <item><description>http: HTTP server.</description></item>
        /// <item><description>aws3: Amazon Simple Storage Service (S3).</description></item>
        /// <item><description>oss: Alibaba Cloud Object Storage Service (OSS).</description></item>
        /// <item><description>kafka: Kafka.</description></item>
        /// <item><description>aws3cmpt: S3-compatible storage service.</description></item>
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
        /// <para>The discard rate. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("DiscardRate")]
        [Validation(Required=false)]
        public float? DiscardRate { get; set; }

        /// <summary>
        /// <para>The log fields, which are separated by commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_agent,ip_adress,ip_port</para>
        /// </summary>
        [NameInMap("FieldName")]
        [Validation(Required=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// <para>The configurations for delivery to an HTTP server.</para>
        /// </summary>
        [NameInMap("HttpDelivery")]
        [Validation(Required=false)]
        public string HttpDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The configurations for delivery to Kafka.</para>
        /// </summary>
        [NameInMap("KafkaDelivery")]
        [Validation(Required=false)]
        public string KafkaDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The configurations for delivery to OSS.</para>
        /// </summary>
        [NameInMap("OssDelivery")]
        [Validation(Required=false)]
        public string OssDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The configurations for delivery to Amazon S3 or an S3-compatible service.</para>
        /// </summary>
        [NameInMap("S3Delivery")]
        [Validation(Required=false)]
        public string S3DeliveryShrink { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12312312112***</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The configurations for delivery to SLS.</para>
        /// </summary>
        [NameInMap("SlsDelivery")]
        [Validation(Required=false)]
        public string SlsDeliveryShrink { get; set; }

        /// <summary>
        /// <para>The name of the delivery task.</para>
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
