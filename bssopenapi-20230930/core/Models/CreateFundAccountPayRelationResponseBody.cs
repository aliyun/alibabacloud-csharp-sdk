// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class CreateFundAccountPayRelationResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<CreateFundAccountPayRelationResponseBodyData> Data { get; set; }
        public class CreateFundAccountPayRelationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1501603440974415</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test@test.aliyunid.com">test@test.aliyunid.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12332112</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public string FundAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ResultCode")]
            [Validation(Required=false)]
            public string ResultCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6000EE23-274B-4E07-A697-FF2E999</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
