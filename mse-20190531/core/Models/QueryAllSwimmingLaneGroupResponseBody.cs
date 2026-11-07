// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class QueryAllSwimmingLaneGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The code is used only to synchronize with success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{id:100,name:&quot;test&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryAllSwimmingLaneGroupResponseBodyData> Data { get; set; }
        public class QueryAllSwimmingLaneGroupResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abcde@abcde,abcde@abcde</para>
            /// </summary>
            [NameInMap("AppIds")]
            [Validation(Required=false)]
            public string AppIds { get; set; }

            /// <summary>
            /// <para>The routing mode for end-to-end canary release:</para>
            /// <list type="bullet">
            /// <item><description><para>0: routing based on request content</para>
            /// </description></item>
            /// <item><description><para>1: routing based on percentages</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanaryModel")]
            [Validation(Required=false)]
            public int? CanaryModel { get; set; }

            /// <summary>
            /// <para>The type of the ingress application and the ID of the ingress application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mse:abcde@abcde</para>
            /// </summary>
            [NameInMap("EntryApp")]
            [Validation(Required=false)]
            public string EntryApp { get; set; }

            /// <summary>
            /// <para>The ID of the lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The side at which canary release for messaging is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Client</para>
            /// </summary>
            [NameInMap("MessageQueueFilterSide")]
            [Validation(Required=false)]
            public string MessageQueueFilterSide { get; set; }

            /// <summary>
            /// <para>Indicates whether canary release for messaging is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("MessageQueueGrayEnable")]
            [Validation(Required=false)]
            public bool? MessageQueueGrayEnable { get; set; }

            /// <summary>
            /// <para>The name of a lane group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swimmingGroup</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The MSE namespace to which the lane belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/a&quot;]</para>
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public string Paths { get; set; }

            /// <summary>
            /// <para>Indicates whether to record the request details (metrics of end-to-end canary release).</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("RecordCanaryDetail")]
            [Validation(Required=false)]
            public bool? RecordCanaryDetail { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The canary version. Valid values: 0 and 2. Recommended value: 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("SwimVersion")]
            [Validation(Required=false)]
            public int? SwimVersion { get; set; }

            /// <summary>
            /// <para>The ID of the user to which the lane belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The dynamic part in the error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message that is returned for the request.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, a success message is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, an error message is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54973C90-F379-4372-9AA5-053A3F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
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
