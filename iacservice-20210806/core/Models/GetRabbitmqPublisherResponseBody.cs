// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetRabbitmqPublisherResponseBody : TeaModel {
        [NameInMap("publisher")]
        [Validation(Required=false)]
        public GetRabbitmqPublisherResponseBodyPublisher Publisher { get; set; }
        public class GetRabbitmqPublisherResponseBodyPublisher : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-10-05T06:07:48Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ExchangeTest</para>
            /// </summary>
            [NameInMap("exchangeName")]
            [Validation(Required=false)]
            public string ExchangeName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TOPIC</para>
            /// </summary>
            [NameInMap("exchangeType")]
            [Validation(Required=false)]
            public string ExchangeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1880770****.mq-amqp.cn-hangzhou-a.aliyuncs.com</para>
            /// </summary>
            [NameInMap("hostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test123</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5671</para>
            /// </summary>
            [NameInMap("port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mqp-3b6cb9fa4751a6fa1b69b8dca1</para>
            /// </summary>
            [NameInMap("publisherId")]
            [Validation(Required=false)]
            public string PublisherId { get; set; }

            [NameInMap("taskIds")]
            [Validation(Required=false)]
            public List<string> TaskIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MjoxODgwNzcwODY5MD****</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MjoxODgwNzcwODY5MD****</para>
            /// </summary>
            [NameInMap("virtualHost")]
            [Validation(Required=false)]
            public string VirtualHost { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1E7BA3EB-B0EF-53F5-9999-07CAD6D9F8A3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
