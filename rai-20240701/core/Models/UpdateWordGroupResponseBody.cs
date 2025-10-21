// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class UpdateWordGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code, 00000 indicates success; others indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>If there is an error, return the error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether it was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>List of error information.</para>
        /// </summary>
        [NameInMap("WordErrorInfoList")]
        [Validation(Required=false)]
        public List<UpdateWordGroupResponseBodyWordErrorInfoList> WordErrorInfoList { get; set; }
        public class UpdateWordGroupResponseBodyWordErrorInfoList : TeaModel {
            /// <summary>
            /// <para>Error message description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Keyword can not be empty</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Error status information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ErrorStatus")]
            [Validation(Required=false)]
            public int? ErrorStatus { get; set; }

            /// <summary>
            /// <para>Position of the error information in the array.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>Label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Buss.</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>Keyword.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Inv.</para>
            /// </summary>
            [NameInMap("Word")]
            [Validation(Required=false)]
            public string Word { get; set; }

        }

    }

}
