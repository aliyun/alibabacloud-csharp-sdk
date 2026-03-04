// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UpdateSubscriptionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateSubscriptionResponseBodyData Data { get; set; }
        public class UpdateSubscriptionResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>rmq-cn-****.cn-shanghai.rmq.aliyuncs.com:8080</para>
            /// </summary>
            [NameInMap("AccessPoint")]
            [Validation(Required=false)]
            public string AccessPoint { get; set; }

            [NameInMap("EventList")]
            [Validation(Required=false)]
            public List<UpdateSubscriptionResponseBodyDataEventList> EventList { get; set; }
            public class UpdateSubscriptionResponseBodyDataEventList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Disabled")]
                [Validation(Required=false)]
                public bool? Disabled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Dialing</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rmq-cn-****</para>
            /// </summary>
            [NameInMap("MqInstanceId")]
            [Validation(Required=false)]
            public string MqInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rocketmq5</para>
            /// </summary>
            [NameInMap("MqType")]
            [Validation(Required=false)]
            public string MqType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GID_xxx</para>
            /// </summary>
            [NameInMap("ProducerId")]
            [Validation(Required=false)]
            public string ProducerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ccc-event</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>username</para>
            /// </summary>
            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>03C67DAD-EB26-41D8-949D-9B0C470FB716</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
