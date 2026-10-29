// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkRabbitMQMsgSyncParameters : TeaModel {
        /// <summary>
        /// <para>The message body.</para>
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public SinkRabbitMQMsgSyncParametersBody Body { get; set; }
        public class SinkRabbitMQMsgSyncParametersBody : TeaModel {
            /// <summary>
            /// <para>The method used to generate the message body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSONPATH</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format parameter values. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The value expression of the message body.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$.data.body</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The endpoint of the ApsaraMQ for RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-hangzhou-2x***.com</para>
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>The exchange. This parameter is required only when the TargetType parameter is set to Exchange.</para>
        /// </summary>
        [NameInMap("Exchange")]
        [Validation(Required=false)]
        public SinkRabbitMQMsgSyncParametersExchange Exchange { get; set; }
        public class SinkRabbitMQMsgSyncParametersExchange : TeaModel {
            /// <summary>
            /// <para>The method used to generate the target exchange.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSONPATH</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format parameter values. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The value expression of the target exchange.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$.data.exchange</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-a1b2c3d4e5f</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the ApsaraMQ for RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The maximum number of hops allowed for message forwarding in a federation task. Messages that exceed this limit are dropped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxHops")]
        [Validation(Required=false)]
        public string MaxHops { get; set; }

        /// <summary>
        /// <para>The message ID.</para>
        /// </summary>
        [NameInMap("MessageId")]
        [Validation(Required=false)]
        public SinkRabbitMQMsgSyncParametersMessageId MessageId { get; set; }
        public class SinkRabbitMQMsgSyncParametersMessageId : TeaModel {
            /// <summary>
            /// <para>The method used to generate the message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSONPATH</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format parameter values. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The value expression of the message ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$.data.messageId</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The network type used to connect to the ApsaraMQ for RabbitMQ instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrivateNetwork</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The password used to connect to the ApsaraMQ for RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yourPassword</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The message properties.</para>
        /// </summary>
        [NameInMap("Properties")]
        [Validation(Required=false)]
        public SinkRabbitMQMsgSyncParametersProperties Properties { get; set; }
        public class SinkRabbitMQMsgSyncParametersProperties : TeaModel {
            /// <summary>
            /// <para>The method used to generate the message properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSONPATH</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format parameter values. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The value expression of the message properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$.data.properties</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The routing key of the message. This parameter is required only when the TargetType parameter is set to Exchange.</para>
        /// </summary>
        [NameInMap("RoutingKey")]
        [Validation(Required=false)]
        public SinkRabbitMQMsgSyncParametersRoutingKey RoutingKey { get; set; }
        public class SinkRabbitMQMsgSyncParametersRoutingKey : TeaModel {
            /// <summary>
            /// <para>The method used to generate the routing key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>JSONPATH</para>
            /// </summary>
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            /// <summary>
            /// <para>The template string used to format parameter values. This parameter is used only when Form is set to TEMPLATE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The value of ${key} is ${value}!</para>
            /// </summary>
            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The value expression of the routing key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$.data.routingKey</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the security group to which the nodes of the ApsaraMQ for RabbitMQ cluster belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-a1b2c3d4e5f6g7h8i9j0</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The username used to connect to the ApsaraMQ for RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches in the VPC where the ApsaraMQ for RabbitMQ cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        /// <summary>
        /// <para>The name of the virtual host (vhost) in the ApsaraMQ for RabbitMQ cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-001</para>
        /// </summary>
        [NameInMap("VirtualHostName")]
        [Validation(Required=false)]
        public string VirtualHostName { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where the ApsaraMQ for RabbitMQ cluster resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-a1b2c3d4e5f6g7h8i9j0k</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
