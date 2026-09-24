// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class TestLargeModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The authentication error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code. A value of OK indicates that the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<TestLargeModelResponseBodyData> Data { get; set; }
        public class TestLargeModelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;code\&quot;:\&quot;InvalidApiKey\&quot;,\&quot;message\&quot;:\&quot;Invalid API-key provided.\&quot;,\&quot;request_id\&quot;:\&quot;dd14065e-3dd5-90a1-b8ee-d6c80891defe\&quot;}</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The model version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ModelVersion")]
            [Validation(Required=false)]
            public string ModelVersion { get; set; }

            /// <summary>
            /// <para>The output result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>⌈Hello! I am the AI assistant on the Alibaba Cloud website.\n\nYour input seems incomplete. What specific information about Alibaba Cloud would you like to know?\n\nFor example:\n*   What are the core products of Alibaba Cloud (such as ECS, RDS, OSS, etc.)?\n*   How do I purchase or renew a cloud server?\n*   What security protection capabilities does Alibaba Cloud offer?\n*   How do I get technical support or view documentation?\n\nFeel free to ask your specific questions, and I will answer them for you!⌋</para>
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>Indicates whether the operation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2051E18-FF3F-5C08-8D24-6F150D2AF757</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Successful.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
