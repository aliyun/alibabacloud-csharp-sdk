// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>List of Account Information</para>
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
                /// <para>The name of Sub Account.</para>
                /// <list type="bullet">
                /// <item><description>Enterprise Customer: Name of Company</description></item>
                /// <item><description>T2 Reseller: Name of Partner</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>XXX Technology LTD.</para>
                /// </summary>
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                /// <summary>
                /// <para>Alibaba Cloud Login name of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:1234@qq.com">1234@qq.com</a></para>
                /// </summary>
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                /// <summary>
                /// <para>The time that Distribution Customer successfully associated with Distributor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-01</para>
                /// </summary>
                [NameInMap("AssociationSuccessTime")]
                [Validation(Required=false)]
                public string AssociationSuccessTime { get; set; }

                /// <summary>
                /// <para>Account CID of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61479572</para>
                /// </summary>
                [NameInMap("Cid")]
                [Validation(Required=false)]
                public long? Cid { get; set; }

                /// <summary>
                /// <para>Type of customer\&quot;s account, 0 Individual, 1 Enterprise</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomerAccountType")]
                [Validation(Required=false)]
                public int? CustomerAccountType { get; set; }

                /// <summary>
                /// <para>Customer\&quot;s Sales Manager</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tommy</para>
                /// </summary>
                [NameInMap("CustomerBd")]
                [Validation(Required=false)]
                public string CustomerBd { get; set; }

                /// <summary>
                /// <para>Whether the customer has completed Enterprise Real-name Authentication, 0 No, 1 Yes</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CustomerEnterpriseCertified")]
                [Validation(Required=false)]
                public int? CustomerEnterpriseCertified { get; set; }

                /// <summary>
                /// <para>When Shutdown Policy is delayStop, this number refer to Shutdown-delay Credit (overdraft limit).</para>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("DelayAmount")]
                [Validation(Required=false)]
                public string DelayAmount { get; set; }

                /// <summary>
                /// <para>There are a value for Shutdown Policy Management towards Sub Account.</para>
                /// <list type="bullet">
                /// <item><description>1 immediatelyStop,  immediately shutdown the instance once customer\&quot;s quota is ran out.</description></item>
                /// <item><description>2 delayStop, delay shutdown the instance until customer\&quot;s Shutdown-delay Credit is ran out. Please refer to DelayAmount.</description></item>
                /// <item><description>3 noStop, customer\&quot;s instance status is rely on manual control instead of auto setting.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>immediatelyStop</para>
                /// </summary>
                [NameInMap("DelayStatus")]
                [Validation(Required=false)]
                public string DelayStatus { get; set; }

                /// <summary>
                /// <para>The E-mail of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:1234@qq.com">1234@qq.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The contact number of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13641588680</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                /// <summary>
                /// <para>Purchase Control, Value Range:</para>
                /// <list type="bullet">
                /// <item><description>Purchase Forbidden</description></item>
                /// <item><description>Normal (Purchase is allowed)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("NewBuyStatus")]
                [Validation(Required=false)]
                public string NewBuyStatus { get; set; }

                /// <summary>
                /// <para>The Country Code where the customer\&quot;s account is registered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("RegisterCountryCode")]
                [Validation(Required=false)]
                public string RegisterCountryCode { get; set; }

                /// <summary>
                /// <para>Description of Distribution Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sub Account</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

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
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SubAccountType")]
                [Validation(Required=false)]
                public int? SubAccountType { get; set; }

                /// <summary>
                /// <para>Account UID of Distribution Customer.</para>
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
        /// <para>Result Code - Error Code. Value Range:</para>
        /// <list type="bullet">
        /// <item><description>200 OK</description></item>
        /// <item><description>1109 System Error</description></item>
        /// <item><description>3029: Invalid UID</description></item>
        /// <item><description>3062: UID and UserType are both empty.</description></item>
        /// <item><description>3063: UserType value out of range.</description></item>
        /// </list>
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
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Pagination Information</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyPageInfo PageInfo { get; set; }
        public class GetAccountInfoResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>Pagination, current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// <para>Pagination, record number on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Pagination, page volume in total.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Request id, a unique identifier generated by Alibaba Cloud for the request.</para>
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
