// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class UpdatePostPaidBindRelResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call fails. For more information, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdatePostPaidBindRelResponseBodyData Data { get; set; }
        public class UpdatePostPaidBindRelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message body.</para>
            /// </summary>
            [NameInMap("Body")]
            [Validation(Required=false)]
            public UpdatePostPaidBindRelResponseBodyDataBody Body { get; set; }
            public class UpdatePostPaidBindRelResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <para>The number of servers that are successfully bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BindCount")]
                [Validation(Required=false)]
                public long? BindCount { get; set; }

                /// <summary>
                /// <para>Id of the request</para>
                /// 
                /// <b>Example:</b>
                /// <para>62A7DCE2-7D9C-511B-919E-0F46A9D19AE6</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <para>The result code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E20BFD0-AA91-594F-B5A7-32CED4777DA0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values: true: The call is successful. false: The call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
