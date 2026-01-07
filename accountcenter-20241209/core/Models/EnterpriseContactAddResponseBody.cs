// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseContactAddResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EnterpriseContactAddResponseBodyData Data { get; set; }
        public class EnterpriseContactAddResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public long? ContactId { get; set; }

            [NameInMap("ErrorList")]
            [Validation(Required=false)]
            public List<EnterpriseContactAddResponseBodyDataErrorList> ErrorList { get; set; }
            public class EnterpriseContactAddResponseBodyDataErrorList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>MOBILE_CODE_ILLEGAL</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Mobile Code Illegal</para>
                /// </summary>
                [NameInMap("ErrorDesc")]
                [Validation(Required=false)]
                public string ErrorDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MOBILE_VERIFY_CODE</para>
                /// </summary>
                [NameInMap("Item")]
                [Validation(Required=false)]
                public string Item { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40EA3ECB-2167-5A8E-9327-F7E59E508FA8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
