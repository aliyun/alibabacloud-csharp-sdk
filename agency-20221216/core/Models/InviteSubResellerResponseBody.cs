// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class InviteSubResellerResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>邀请结果信息</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<InviteSubResellerResponseBodyResults> Results { get; set; }
        public class InviteSubResellerResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>Error code, 200 OK</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>Prompt message, explanation of the code</para>
            /// 
            /// <b>Example:</b>
            /// <para>成功</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Returned invitation result information</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public InviteSubResellerResponseBodyResultsResult Result { get; set; }
            public class InviteSubResellerResponseBodyResultsResult : TeaModel {
                /// <summary>
                /// <para>Validity period of the registration URL, in days</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public int? Days { get; set; }

                /// <summary>
                /// <para>Invitation ID, used for querying the invitation status</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("InviteId")]
                [Validation(Required=false)]
                public long? InviteId { get; set; }

                /// <summary>
                /// <para>T2 Reseller registration URL</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://agency-intl.console.aliyun.com/customer/register?intl=true&fxinfo=XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX">http://agency-intl.console.aliyun.com/customer/register?intl=true&amp;fxinfo=XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX</a></para>
                /// </summary>
                [NameInMap("RegUrl")]
                [Validation(Required=false)]
                public string RegUrl { get; set; }

            }

            /// <summary>
            /// <para>Always true</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
