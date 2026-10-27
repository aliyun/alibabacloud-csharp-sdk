// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20251111.Models
{
    public class ListInstructionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned for the list of instructions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInstructionsResponseBodyData Data { get; set; }
        public class ListInstructionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of instructions.</para>
            /// </summary>
            [NameInMap("Instructions")]
            [Validation(Required=false)]
            public List<ListInstructionsResponseBodyDataInstructions> Instructions { get; set; }
            public class ListInstructionsResponseBodyDataInstructions : TeaModel {
                /// <summary>
                /// <para>The instruction code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Transfer00</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The instruction configuration, in a JSON string format.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para><c>providerId</c>: The ID of the call center provider. You can obtain this ID by calling the <c>ListCallCenterProviders</c> operation.</para>
                /// </description></item>
                /// <item><description><para><c>transferMethod</c>: The transfer method. Valid values: <c>BYE</c>, <c>BRIDGE</c>, and <c>REFER</c>.</para>
                /// </description></item>
                /// <item><description><para><c>transferType</c>: The transfer target type. Valid values: <c>External</c> (external number), <c>Agent</c> (agent), and <c>SkillGroup</c> (skill group).</para>
                /// </description></item>
                /// <item><description><para><c>transferTarget</c>: The transfer target.</para>
                /// </description></item>
                /// <item><description><para><c>transferor</c>: The caller ID. If not specified, the caller\&quot;s phone number is used.</para>
                /// </description></item>
                /// <item><description><para><c>timeoutSeconds</c>: The transfer timeout, in seconds. The default value is 30.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///     &quot;providerId&quot;: &quot;xxxxxxxxx&quot;,
                ///     &quot;transferMethod&quot;: &quot;BYE&quot;,
                ///     &quot;transferType&quot;: &quot;External&quot;,
                ///     &quot;transferTarget&quot;: &quot;152******&quot;,
                ///     &quot;transferor&quot;: &quot;01*****&quot;,
                ///     &quot;timeoutSeconds&quot;: &quot;10&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36e9a4cd-a821-4f78-86fa-a9a4aefeea2e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instruction name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>转人工指令一</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The instruction type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TRANSFER</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
        /// <para>The result message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A list of request parameters that are echoed in the response.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e48e45dd-e47a-4744-a063-f08cbebb1c5a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
