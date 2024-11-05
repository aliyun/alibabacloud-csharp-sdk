// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Account Type:</para>
        /// <list type="bullet">
        /// <item><description>1 Agency\&quot;s End User</description></item>
        /// <item><description>2 Reseller\&quot;s End User</description></item>
        /// <item><description>3 Enterprise</description></item>
        /// <item><description>4 T2 Agency Partner</description></item>
        /// <item><description>5 T2 Reseller Partner</description></item>
        /// <item><description>6 T2 Agency+Reseller Partner</description></item>
        /// </list>
        /// </summary>
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyAccountInfoList AccountInfoList { get; set; }
        public class GetAccountInfoResponseBodyAccountInfoList : TeaModel {
            [NameInMap("AccountInfo")]
            [Validation(Required=false)]
            public List<GetAccountInfoResponseBodyAccountInfoListAccountInfo> AccountInfo { get; set; }
            public class GetAccountInfoResponseBodyAccountInfoListAccountInfo : TeaModel {
                /// <summary>
                /// <para>The E-mail of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description of Distribution Customer.</para>
                /// </summary>
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                /// <summary>
                /// <para>Account CID of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:1234@qq.com">1234@qq.com</a></para>
                /// </summary>
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                /// <summary>
                /// <para>XXX Technology LTD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-01</para>
                /// </summary>
                [NameInMap("AssociationSuccessTime")]
                [Validation(Required=false)]
                public string AssociationSuccessTime { get; set; }

                /// <summary>
                /// <para>customer\&quot;s CID</para>
                /// 
                /// <b>Example:</b>
                /// <para>61479572</para>
                /// </summary>
                [NameInMap("Cid")]
                [Validation(Required=false)]
                public long? Cid { get; set; }

                [NameInMap("CustomerAccountType")]
                [Validation(Required=false)]
                public int? CustomerAccountType { get; set; }

                /// <summary>
                /// <para>customer manager</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("CustomerBd")]
                [Validation(Required=false)]
                public string CustomerBd { get; set; }

                [NameInMap("CustomerEnterpriseCertified")]
                [Validation(Required=false)]
                public int? CustomerEnterpriseCertified { get; set; }

                /// <summary>
                /// <para>The account have Shutdown-delay Privilege, After Shutdown-delay Credit is ran out, Alibaba Cloud will take over resources and keep the instance for 15 days. In addition, the instance will be released if Sub Account failed to pay the bill within these 15 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("DelayAmount")]
                [Validation(Required=false)]
                public string DelayAmount { get; set; }

                /// <summary>
                /// <para>Partner\&quot;s Shutdown Policy Management for Sub Account.
                /// 1: delayStop. The account have Shutdown-delay Privilege, After Shutdown-delay Credit is ran out, Alibaba Cloud will take over resources and keep the instance for 15 days. In addition, the instance will be released if Sub Account failed to pay the bill within these 15 days.
                /// 2: noStop. Partner will manually manage Shutdown Status for Sub Account. Meanwhile, System would not manage the resource\&quot;s life-circle of Sub Account.
                /// 3: immediatelyStop. Once valid quota of Sub Account falls below 0 and be identified as defaulting account, it will trigger the instance shutdown immediately.</para>
                /// 
                /// <b>Example:</b>
                /// <para>noStop</para>
                /// </summary>
                [NameInMap("DelayStatus")]
                [Validation(Required=false)]
                public string DelayStatus { get; set; }

                /// <summary>
                /// <para>Sub Account</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:1234@qq.com">1234@qq.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>Account UID of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13641588680</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>Purchase Forbidden：Ban the new purchase action
                /// normal：Normal--End Use can issue Cloud Resource order immediately.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("NewBuyStatus")]
                [Validation(Required=false)]
                public string NewBuyStatus { get; set; }

                [NameInMap("RegisterCountryCode")]
                [Validation(Required=false)]
                public string RegisterCountryCode { get; set; }

                /// <summary>
                /// <para>Valid mobile number of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba Cloud Login name of Distribution Customer.</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The name of Sub Account:
                /// 1.	Use the official name of Company, if Sub Account is an enterprise.
                /// 2.	Use the official name of Partner, if Sub Account is a T2 reseller.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SubAccountType")]
                [Validation(Required=false)]
                public int? SubAccountType { get; set; }

                /// <summary>
                /// <para>Request ID, the unique request identifier generated by Alibaba Cloud.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1415740779475837</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

        }

        /// <summary>
        /// <para>Candidate Value: True/False, which indicates whether the current API call itself is successful. It does not guarantee the success of subsequent business operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Pagination Information</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pagination, page volume in total.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyPageInfo PageInfo { get; set; }
        public class GetAccountInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>Account Information</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>Pagination, current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>List of Account Information</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Request id, a unique identifier generated by Alibaba cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9C14ADFE-DF0A-54D4-8BD5-45D0839246B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Pagination, record number on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
