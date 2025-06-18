// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class TestEventSourceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success: The request was successful.</description></item>
        /// <item><description>Other codes indicate that the request failed. For information about error codes, see Error codes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The update result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<TestEventSourceConfigResponseBodyData> Data { get; set; }
        public class TestEventSourceConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHECK_CONNECTION</para>
            /// </summary>
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connection established successfully.</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>Indicates whether the check item is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSucceed")]
            [Validation(Required=false)]
            public string IsSucceed { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FF942675-F937-549C-A942-EB94FFE28DD3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. If the operation was successful, the value true is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
