// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CloneNacosConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The dynamic part in the error message. This parameter is used to replace the \<em>\</em>%s\<em>\</em> variable in the <b>ErrMessage</b> parameter.</para>
        /// <remarks>
        /// <para> If the return value of the <b>ErrMessage</b> parameter is <b>The Value of Input Parameter %s is not valid</b> and the return value of the <b>DynamicMessage</b> parameter is <b>DtsJobId</b>, the specified <b>DtsJobId</b> parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloneNacosConfigResponseBodyData Data { get; set; }
        public class CloneNacosConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the failed configurations.</para>
            /// </summary>
            [NameInMap("FailData")]
            [Validation(Required=false)]
            public List<CloneNacosConfigResponseBodyDataFailData> FailData { get; set; }
            public class CloneNacosConfigResponseBodyDataFailData : TeaModel {
                /// <summary>
                /// <para>mse-200-105</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2.yaml</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>duplicatedClusterAliasName</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The data structure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SkipCount")]
            [Validation(Required=false)]
            public int? SkipCount { get; set; }

            /// <summary>
            /// <para>The ID of the data.</para>
            /// </summary>
            [NameInMap("SkipData")]
            [Validation(Required=false)]
            public List<CloneNacosConfigResponseBodyDataSkipData> SkipData { get; set; }
            public class CloneNacosConfigResponseBodyDataSkipData : TeaModel {
                /// <summary>
                /// <para>The details of the failed configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.yaml</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The data structure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

            }

            /// <summary>
            /// <para>The details of the skipped configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SuccCount")]
            [Validation(Required=false)]
            public int? SuccCount { get; set; }

        }

        /// <summary>
        /// <para>The number of successful operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Clone Completed Successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6678DBA9-5600-5948-ACF8-ED3105B288A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
