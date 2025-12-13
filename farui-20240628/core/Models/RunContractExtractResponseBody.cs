// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractExtractResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public RunContractExtractResponseBodyData Data { get; set; }
        public class RunContractExtractResponseBodyData : TeaModel {
            [NameInMap("contractText")]
            [Validation(Required=false)]
            public string ContractText { get; set; }

            [NameInMap("extractResult")]
            [Validation(Required=false)]
            public List<RunContractExtractResponseBodyDataExtractResult> ExtractResult { get; set; }
            public class RunContractExtractResponseBodyDataExtractResult : TeaModel {
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("extractItem")]
                [Validation(Required=false)]
                public string ExtractItem { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("option")]
                [Validation(Required=false)]
                public string Option { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<RunContractExtractResponseBodyDataExtractResultValue> Value { get; set; }
                public class RunContractExtractResponseBodyDataExtractResultValue : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HT-2022-0001</para>
                    /// </summary>
                    [NameInMap("data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                    [NameInMap("originalText")]
                    [Validation(Required=false)]
                    public string OriginalText { get; set; }

                }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C844BE6B-33A9-5AC4-A1AE-97B131849E0F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
