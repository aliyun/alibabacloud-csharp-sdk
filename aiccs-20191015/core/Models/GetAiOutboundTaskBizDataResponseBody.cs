// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskBizDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskBizDataResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskBizDataResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;customer&quot;:123}</para>
            /// </summary>
            [NameInMap("BizData")]
            [Validation(Required=false)]
            public string BizData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CaseId")]
            [Validation(Required=false)]
            public long? CaseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>158****0000</para>
            /// </summary>
            [NameInMap("PhoneNum")]
            [Validation(Required=false)]
            public string PhoneNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
