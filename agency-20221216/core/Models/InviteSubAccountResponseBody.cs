// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class InviteSubAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>Error Code: </br>
        /// • 200 OK</br>
        /// • 1109 System Error</br></para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Message</br></para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, Alibaba Cloud will track errors with this ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of invitation sending results</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public InviteSubAccountResponseBodyResults Results { get; set; }
        public class InviteSubAccountResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<InviteSubAccountResponseBodyResultsResult> Result { get; set; }
            public class InviteSubAccountResponseBodyResultsResult : TeaModel {
                /// <summary>
                /// <para>Error Code, 200 OK</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>Message, Notes of Code</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Returning Message of Invitation Results</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public InviteSubAccountResponseBodyResultsResultResult Result { get; set; }
                public class InviteSubAccountResponseBodyResultsResultResult : TeaModel {
                    /// <summary>
                    /// <para>Valid days of registration URL, count on daily basis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15</para>
                    /// </summary>
                    [NameInMap("Days")]
                    [Validation(Required=false)]
                    public int? Days { get; set; }

                    /// <summary>
                    /// <para>Invitation ID, The invitation status tracking code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("InviteId")]
                    [Validation(Required=false)]
                    public long? InviteId { get; set; }

                    /// <summary>
                    /// <para>URL for Partner Customer Registration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://agency-intl.console.aliyun.com/customer/register?intl=true&fxinfo=-4uT%2FMWHnnUdvr5GXVd1AYK8luTnGgH3M7Y3lSCd5M1fxRwAkViTWtDJDpckh0HL">http://agency-intl.console.aliyun.com/customer/register?intl=true&amp;fxinfo=-4uT%2FMWHnnUdvr5GXVd1AYK8luTnGgH3M7Y3lSCd5M1fxRwAkViTWtDJDpckh0HL</a></para>
                    /// </summary>
                    [NameInMap("RegUrl")]
                    [Validation(Required=false)]
                    public string RegUrl { get; set; }

                }

                /// <summary>
                /// <para>Always true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// <para>Candidate Values: True/False, this value states if the current API calling action is successful. It does not guarantee the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
