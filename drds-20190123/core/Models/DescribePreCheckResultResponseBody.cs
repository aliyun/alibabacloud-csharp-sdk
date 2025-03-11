// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribePreCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the result of the precheck task.</para>
        /// </summary>
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public DescribePreCheckResultResponseBodyPreCheckResult PreCheckResult { get; set; }
        public class DescribePreCheckResultResponseBodyPreCheckResult : TeaModel {
            /// <summary>
            /// <para>Indicates the name of the precheck task.</para>
            /// </summary>
            [NameInMap("PreCheckName")]
            [Validation(Required=false)]
            public string PreCheckName { get; set; }

            /// <summary>
            /// <para>Indicates the state of the precheck task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FAIL</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>Indicates the details about the subtasks of the precheck task.</para>
            /// </summary>
            [NameInMap("SubCheckItems")]
            [Validation(Required=false)]
            public List<DescribePreCheckResultResponseBodyPreCheckResultSubCheckItems> SubCheckItems { get; set; }
            public class DescribePreCheckResultResponseBodyPreCheckResultSubCheckItems : TeaModel {
                /// <summary>
                /// <para>Indicates the error code that is returned by a subtask.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1004</para>
                /// </summary>
                [NameInMap("ErrorMsgCode")]
                [Validation(Required=false)]
                public string ErrorMsgCode { get; set; }

                /// <summary>
                /// <para>Indicates an error message.</para>
                /// </summary>
                [NameInMap("ErrorMsgParams")]
                [Validation(Required=false)]
                public List<string> ErrorMsgParams { get; set; }

                /// <summary>
                /// <para>Indicates the name of the subtask.</para>
                /// </summary>
                [NameInMap("PreCheckItemName")]
                [Validation(Required=false)]
                public string PreCheckItemName { get; set; }

                /// <summary>
                /// <para>Indicates the state of the subtask.</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EED1A59A-CFEA-5CF8-BB4A-090E75B3D05E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
