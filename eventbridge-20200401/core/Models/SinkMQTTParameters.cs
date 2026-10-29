// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkMQTTParameters : TeaModel {
        /// <summary>
        /// <para>The ID of the destination MQTT instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mqtt-cn-a1b2c3d4e5f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The user properties.</para>
        /// </summary>
        [NameInMap("Mqtt5UserProperty")]
        [Validation(Required=false)]
        public SinkMQTTParametersMqtt5UserProperty Mqtt5UserProperty { get; set; }
        public class SinkMQTTParametersMqtt5UserProperty : TeaModel {
            /// <summary>
            /// <para>The method used to generate the parameter value. Valid values: CONSTANT (constant), JSONPATH (extracted from event content), and TEMPLATE (template).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format the parameter value. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the parameter value specified by Form. When Form is set to CONSTANT, this value is the content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO CONTENT</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The parent topic of the destination MQTT instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-topic</para>
        /// </summary>
        [NameInMap("ParentTopic")]
        [Validation(Required=false)]
        public string ParentTopic { get; set; }

        /// <summary>
        /// <para>The message payload.</para>
        /// </summary>
        [NameInMap("Payload")]
        [Validation(Required=false)]
        public SinkMQTTParametersPayload Payload { get; set; }
        public class SinkMQTTParametersPayload : TeaModel {
            /// <summary>
            /// <para>The method used to generate the message content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ORIGINAL</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format the parameter value. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the parameter value specified by Form. When Form is set to CONSTANT, this value is the content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO CONTENT</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The subtopic name.</para>
        /// </summary>
        [NameInMap("SubTopic")]
        [Validation(Required=false)]
        public SinkMQTTParametersSubTopic SubTopic { get; set; }
        public class SinkMQTTParametersSubTopic : TeaModel {
            /// <summary>
            /// <para>The method used to generate the parameter value. Valid values: CONSTANT (constant), JSONPATH (extracted from event content), and TEMPLATE (template).</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONSTANT</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format the parameter value. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The source content of the parameter value specified by Form. When Form is set to CONSTANT, this value is the content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUB-TOPIC</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
