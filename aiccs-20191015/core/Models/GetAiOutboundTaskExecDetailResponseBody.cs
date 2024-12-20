// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetAiOutboundTaskExecDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAiOutboundTaskExecDetailResponseBodyData Data { get; set; }
        public class GetAiOutboundTaskExecDetailResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasNextPage")]
            [Validation(Required=false)]
            public bool? HasNextPage { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetAiOutboundTaskExecDetailResponseBodyDataList> List { get; set; }
            public class GetAiOutboundTaskExecDetailResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BatchVersion")]
                [Validation(Required=false)]
                public int? BatchVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("BizData")]
                [Validation(Required=false)]
                public string BizData { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallCount")]
                [Validation(Required=false)]
                public int? CallCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public long? CaseId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1632289999000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>未接通</para>
                /// </summary>
                [NameInMap("LastCallResult")]
                [Validation(Required=false)]
                public string LastCallResult { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>150****0000</para>
                /// </summary>
                [NameInMap("PhoneNum")]
                [Validation(Required=false)]
                public string PhoneNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>待呼叫</para>
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public int? StatusDesc { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>199</para>
            /// </summary>
            [NameInMap("TotalResults")]
            [Validation(Required=false)]
            public int? TotalResults { get; set; }

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
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
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
