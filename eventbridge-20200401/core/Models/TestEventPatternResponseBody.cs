// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class TestEventPatternResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. <c>Success</c> indicates that the call was successful. For more information about other return codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The result of the test.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TestEventPatternResponseBodyData Data { get; set; }
        public class TestEventPatternResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates if the event matches the event pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96D7C0AB-DCE5-5E82-96B8-4725E1706BB1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
