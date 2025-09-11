// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class KafkaIngestionConfigurationSource : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.28:9092</para>
        /// </summary>
        [NameInMap("bootstrapServers")]
        [Validation(Required=false)]
        public string BootstrapServers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;protocol&quot;:&quot;SASL_PLAINTEXT&quot;,      &quot;sasl&quot;:{         &quot;mechanism&quot;:&quot;PLAIN&quot;,         &quot;username&quot;:&quot;用户名&quot;,         &quot;password&quot;:&quot;密码&quot;     } }</para>
        /// </summary>
        [NameInMap("communication")]
        [Validation(Required=false)]
        public string Communication { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>consumer</para>
        /// </summary>
        [NameInMap("consumerGroup")]
        [Validation(Required=false)]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system,kafka</para>
        /// </summary>
        [NameInMap("defaultTimeSource")]
        [Validation(Required=false)]
        public string DefaultTimeSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableSlsContext")]
        [Validation(Required=false)]
        public bool? EnableSlsContext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF-8</para>
        /// </summary>
        [NameInMap("encoding")]
        [Validation(Required=false)]
        public string Encoding { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>earliest,latest</para>
        /// </summary>
        [NameInMap("fromPosition")]
        [Validation(Required=false)]
        public string FromPosition { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;hostname&quot;: &quot;192.168.1.28&quot;}</para>
        /// </summary>
        [NameInMap("nameResolutions")]
        [Validation(Required=false)]
        public string NameResolutions { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("parseArray")]
        [Validation(Required=false)]
        public bool? ParseArray { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b>time</b></para>
        /// </summary>
        [NameInMap("timeField")]
        [Validation(Required=false)]
        public string TimeField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>epoch</para>
        /// </summary>
        [NameInMap("timeFormat")]
        [Validation(Required=false)]
        public string TimeFormat { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2}</para>
        /// </summary>
        [NameInMap("timePattern")]
        [Validation(Required=false)]
        public string TimePattern { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>+0800</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic1,topic2</para>
        /// </summary>
        [NameInMap("topics")]
        [Validation(Required=false)]
        public string Topics { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text,json</para>
        /// </summary>
        [NameInMap("valueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
