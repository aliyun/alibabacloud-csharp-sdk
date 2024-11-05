// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetInviteStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Status Code. Error Code:</para>
        /// <list type="bullet">
        /// <item><description>3057 InviteId is empty</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInviteStatusResponseBodyData Data { get; set; }
        public class GetInviteStatusResponseBodyData : TeaModel {
            [NameInMap("InviteStatus")]
            [Validation(Required=false)]
            public List<GetInviteStatusResponseBodyDataInviteStatus> InviteStatus { get; set; }
            public class GetInviteStatusResponseBodyDataInviteStatus : TeaModel {
                /// <summary>
                /// <para>Result Code. Value Range:</para>
                /// <list type="bullet">
                /// <item><description>200 OK</description></item>
                /// <item><description>1109 system error</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>List of Invitation Status result</para>
                /// </summary>
                [NameInMap("InviteStatusList")]
                [Validation(Required=false)]
                public GetInviteStatusResponseBodyDataInviteStatusInviteStatusList InviteStatusList { get; set; }
                public class GetInviteStatusResponseBodyDataInviteStatusInviteStatusList : TeaModel {
                    /// <summary>
                    /// <para>The time that Distribution Customer successfully associated with Distributor.</br>
                    /// This value will be empty if there is no existing association.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-02-13</para>
                    /// </summary>
                    [NameInMap("AssociationSuccessTime")]
                    [Validation(Required=false)]
                    public string AssociationSuccessTime { get; set; }

                    /// <summary>
                    /// <para>Distribution Customer\&quot;s CID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890123</para>
                    /// </summary>
                    [NameInMap("Cid")]
                    [Validation(Required=false)]
                    public long? Cid { get; set; }

                    /// <summary>
                    /// <para>The time of email been sent out.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2018-02-12</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <para>The parent organization ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1093238769140523</para>
                    /// </summary>
                    [NameInMap("ParentId")]
                    [Validation(Required=false)]
                    public string ParentId { get; set; }

                    /// <summary>
                    /// <para>Invitation Status:</para>
                    /// <list type="bullet">
                    /// <item><description>0 No visit on registration URL</description></item>
                    /// <item><description>1 Successful Registration</description></item>
                    /// <item><description>2 Unsuccessful Registration</description></item>
                    /// <item><description>3 Registration URL have been visited, but no submitted sheet/ticket.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>Account Type:</para>
                    /// <list type="bullet">
                    /// <item><description>1 Agency\&quot;s End User</description></item>
                    /// <item><description>2 Reseller\&quot;s End User</description></item>
                    /// <item><description>5 T2 Reseller Partner</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SubAccountType")]
                    [Validation(Required=false)]
                    public string SubAccountType { get; set; }

                    /// <summary>
                    /// <para>Distribution Customer\&quot;s UID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1234567890123</para>
                    /// </summary>
                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public long? Uid { get; set; }

                }

                /// <summary>
                /// <para>The message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.</para>
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
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID, Alibaba Cloud will track errors with this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
