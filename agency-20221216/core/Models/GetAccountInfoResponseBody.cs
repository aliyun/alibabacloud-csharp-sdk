// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyAccountInfoList AccountInfoList { get; set; }
        public class GetAccountInfoResponseBodyAccountInfoList : TeaModel {
            [NameInMap("AccountInfo")]
            [Validation(Required=false)]
            public List<GetAccountInfoResponseBodyAccountInfoListAccountInfo> AccountInfo { get; set; }
            public class GetAccountInfoResponseBodyAccountInfoListAccountInfo : TeaModel {
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                [NameInMap("AssociationSuccessTime")]
                [Validation(Required=false)]
                public string AssociationSuccessTime { get; set; }

                [NameInMap("Cid")]
                [Validation(Required=false)]
                public long? Cid { get; set; }

                [NameInMap("CustomerAccountType")]
                [Validation(Required=false)]
                public int? CustomerAccountType { get; set; }

                [NameInMap("CustomerBd")]
                [Validation(Required=false)]
                public string CustomerBd { get; set; }

                [NameInMap("CustomerEnterpriseCertified")]
                [Validation(Required=false)]
                public int? CustomerEnterpriseCertified { get; set; }

                [NameInMap("DelayAmount")]
                [Validation(Required=false)]
                public string DelayAmount { get; set; }

                [NameInMap("DelayStatus")]
                [Validation(Required=false)]
                public string DelayStatus { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("NewBuyStatus")]
                [Validation(Required=false)]
                public string NewBuyStatus { get; set; }

                [NameInMap("RegisterCountryCode")]
                [Validation(Required=false)]
                public string RegisterCountryCode { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SubAccountType")]
                [Validation(Required=false)]
                public int? SubAccountType { get; set; }

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
