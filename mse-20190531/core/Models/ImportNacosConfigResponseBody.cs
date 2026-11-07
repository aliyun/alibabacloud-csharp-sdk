// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportNacosConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data overview.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportNacosConfigResponseBodyData Data { get; set; }
        public class ImportNacosConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of failed imports.</para>
            /// </summary>
            [NameInMap("FailData")]
            [Validation(Required=false)]
            public List<ImportNacosConfigResponseBodyDataFailData> FailData { get; set; }
            public class ImportNacosConfigResponseBodyDataFailData : TeaModel {
                /// <summary>
                /// <para>The data ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2.yaml</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The cause of the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The import configuration format is incorrect.</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The number of skipped messages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SkipCount")]
            [Validation(Required=false)]
            public int? SkipCount { get; set; }

            /// <summary>
            /// <para>The list of skipped configurations.</para>
            /// </summary>
            [NameInMap("SkipData")]
            [Validation(Required=false)]
            public List<ImportNacosConfigResponseBodyDataSkipData> SkipData { get; set; }
            public class ImportNacosConfigResponseBodyDataSkipData : TeaModel {
                /// <summary>
                /// <para>The data ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.yaml</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

            }

            /// <summary>
            /// <para>The number of successfully imported instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccCount")]
            [Validation(Required=false)]
            public int? SuccCount { get; set; }

        }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace <b>%s</b> in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
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
        /// <para>mse-100-100</para>
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
        /// <para>The returned message.</para>
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
        /// <para>AF21683A-29C7-4853-AC0F-B5ADEE4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
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
