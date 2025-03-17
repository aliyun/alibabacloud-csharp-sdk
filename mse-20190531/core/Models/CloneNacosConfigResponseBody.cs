// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CloneNacosConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloneNacosConfigResponseBodyData Data { get; set; }
        public class CloneNacosConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Failed configuration information.</para>
            /// </summary>
            [NameInMap("FailData")]
            [Validation(Required=false)]
            public List<CloneNacosConfigResponseBodyDataFailData> FailData { get; set; }
            public class CloneNacosConfigResponseBodyDataFailData : TeaModel {
                /// <summary>
                /// <para>Data ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2.yaml</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>Group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The reason for the current operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>param not support</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>Number of skips.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SkipCount")]
            [Validation(Required=false)]
            public int? SkipCount { get; set; }

            /// <summary>
            /// <para>Skipped configuration information.</para>
            /// </summary>
            [NameInMap("SkipData")]
            [Validation(Required=false)]
            public List<CloneNacosConfigResponseBodyDataSkipData> SkipData { get; set; }
            public class CloneNacosConfigResponseBodyDataSkipData : TeaModel {
                /// <summary>
                /// <para>Data ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.yaml</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>Group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

            }

            /// <summary>
            /// <para>Number of successes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccCount")]
            [Validation(Required=false)]
            public int? SuccCount { get; set; }

        }

        /// <summary>
        /// <para>Dynamic error message, used to replace the <b>%s</b> in the <b>ErrMessage</b> error message.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b>, and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the input request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Clone Completed Successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6678DBA9-5600-5948-ACF8-ED3105B288A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Request result, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Request succeeded.</description></item>
        /// <item><description><c>false</c>: Request failed.</description></item>
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
