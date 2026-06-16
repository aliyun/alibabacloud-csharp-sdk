// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateForeignPocSampleResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return Result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public CreateForeignPocSampleResponseBodyResultObject ResultObject { get; set; }
        public class CreateForeignPocSampleResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Indicates whether validation warnings exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasWarnings")]
            [Validation(Required=false)]
            public bool? HasWarnings { get; set; }

            /// <summary>
            /// <para>Sample ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>174</para>
            /// </summary>
            [NameInMap("SampleId")]
            [Validation(Required=false)]
            public int? SampleId { get; set; }

            /// <summary>
            /// <para>Sample Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleNameTest</para>
            /// </summary>
            [NameInMap("SampleName")]
            [Validation(Required=false)]
            public string SampleName { get; set; }

            /// <summary>
            /// <para>Scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FINANCE</para>
            /// </summary>
            [NameInMap("Tab")]
            [Validation(Required=false)]
            public string Tab { get; set; }

            /// <summary>
            /// <para>Warning summary.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WarningMessage")]
            [Validation(Required=false)]
            public string WarningMessage { get; set; }

        }

    }

}
