// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumExceptionStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The responses code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRumExceptionStackResponseBodyData Data { get; set; }
        public class GetRumExceptionStackResponseBodyData : TeaModel {
            [NameInMap("BinaryImages")]
            [Validation(Required=false)]
            public string BinaryImages { get; set; }

            [NameInMap("CrashAddress")]
            [Validation(Required=false)]
            public string CrashAddress { get; set; }

            [NameInMap("CrashReason")]
            [Validation(Required=false)]
            public string CrashReason { get; set; }

            /// <summary>
            /// <para>The list of stacks.</para>
            /// </summary>
            [NameInMap("Lines")]
            [Validation(Required=false)]
            public List<string> Lines { get; set; }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The thread ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16643</para>
            /// </summary>
            [NameInMap("ThreadId")]
            [Validation(Required=false)]
            public string ThreadId { get; set; }

            [NameInMap("ThreadInfoList")]
            [Validation(Required=false)]
            public List<GetRumExceptionStackResponseBodyDataThreadInfoList> ThreadInfoList { get; set; }
            public class GetRumExceptionStackResponseBodyDataThreadInfoList : TeaModel {
                [NameInMap("ThreadDetail")]
                [Validation(Required=false)]
                public string ThreadDetail { get; set; }

                [NameInMap("ThreadTag")]
                [Validation(Required=false)]
                public string ThreadTag { get; set; }

            }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error. Please try again. Contact the DingTalk service account if the issue                              persists after multiple retries.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6A00968-82A8-4F14-9D1B-B53827DB****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c></description></item>
        /// <item><description><c>false</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
