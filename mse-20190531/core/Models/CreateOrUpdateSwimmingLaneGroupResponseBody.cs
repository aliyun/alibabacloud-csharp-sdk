// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateOrUpdateSwimmingLaneGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The data overview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOrUpdateSwimmingLaneGroupResponseBodyData Data { get; set; }
        public class CreateOrUpdateSwimmingLaneGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The IDs of the applications, separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcd1@abcde123,abcd1@abcde124</para>
            /// </summary>
            [NameInMap("AppIds")]
            [Validation(Required=false)]
            public string AppIds { get; set; }

            /// <summary>
            /// <para>The end-to-end canary release mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Route by request content.</description></item>
            /// <item><description>1: Route by proportion.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            /// <summary>
            /// <para>Indicates whether canary release is enabled for databases.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DbGrayEnable")]
            [Validation(Required=false)]
            public string DbGrayEnable { get; set; }

            /// <summary>
            /// <para>The entry application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse:abcd1@a2345</para>
            /// </summary>
            [NameInMap("EntryApp")]
            [Validation(Required=false)]
            public string EntryApp { get; set; }

            /// <summary>
            /// <para>The ID of the swimlane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2047</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The side where message queue canary release filtering is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Client</para>
            /// </summary>
            [NameInMap("MessageQueueFilterSide")]
            [Validation(Required=false)]
            public string MessageQueueFilterSide { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable canary release for message queues.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MessageQueueGrayEnable")]
            [Validation(Required=false)]
            public bool? MessageQueueGrayEnable { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example-app</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the MSE namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The paths. This parameter is a list of paths when a Java gateway is used as the entry point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/a&quot;]</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public string Paths { get; set; }

            /// <summary>
            /// <para>Specifies whether to record request details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("RecordCanaryDetail")]
            [Validation(Required=false)]
            public bool? RecordCanaryDetail { get; set; }

            /// <summary>
            /// <para>The region to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the application belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Succ</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE5C32A1-BC0E-4B79-817C-103E4EDF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
