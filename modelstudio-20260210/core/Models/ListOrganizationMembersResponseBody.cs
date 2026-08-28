// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListOrganizationMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOrganizationMembersResponseBodyData> Data { get; set; }
        public class ListOrganizationMembersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The member business ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112233</para>
            /// </summary>
            [NameInMap("AccountBizId")]
            [Validation(Required=false)]
            public string AccountBizId { get; set; }

            /// <summary>
            /// <para>The ID of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acc_123456789</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The name of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_001</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>API Key ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>key_123456789</para>
            /// </summary>
            [NameInMap("ApiKeyId")]
            [Validation(Required=false)]
            public string ApiKeyId { get; set; }

            /// <summary>
            /// <para>The member email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@email.com">test@email.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The time when the member joined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-10T11:57:42.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The masked API key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prefix.abc****456</para>
            /// </summary>
            [NameInMap("MaskedApiKey")]
            [Validation(Required=false)]
            public string MaskedApiKey { get; set; }

            /// <summary>
            /// <para>The organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org_123456789</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            [NameInMap("PackLimitInfo")]
            [Validation(Required=false)]
            public ListOrganizationMembersResponseBodyDataPackLimitInfo PackLimitInfo { get; set; }
            public class ListOrganizationMembersResponseBodyDataPackLimitInfo : TeaModel {
                [NameInMap("AvailableLimit")]
                [Validation(Required=false)]
                public double? AvailableLimit { get; set; }

                [NameInMap("CycleEndTime")]
                [Validation(Required=false)]
                public long? CycleEndTime { get; set; }

                [NameInMap("CycleStartTime")]
                [Validation(Required=false)]
                public long? CycleStartTime { get; set; }

                [NameInMap("FrozenCredits")]
                [Validation(Required=false)]
                public double? FrozenCredits { get; set; }

                [NameInMap("HasShareLimit")]
                [Validation(Required=false)]
                public bool? HasShareLimit { get; set; }

                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public bool? IsAvailable { get; set; }

                [NameInMap("LastConfirmedTime")]
                [Validation(Required=false)]
                public long? LastConfirmedTime { get; set; }

                [NameInMap("UpperLimit")]
                [Validation(Required=false)]
                public double? UpperLimit { get; set; }

                [NameInMap("UsedCredits")]
                [Validation(Required=false)]
                public double? UsedCredits { get; set; }

            }

            /// <summary>
            /// <para>The list of member roles.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <para>The seat resource allocate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>seat_123456</para>
            /// </summary>
            [NameInMap("SeatId")]
            [Validation(Required=false)]
            public string SeatId { get; set; }

            /// <summary>
            /// <para>The seat specification type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: Standard seat.</description></item>
            /// <item><description>pro: Pro seat.</description></item>
            /// <item><description>max: Max seat.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>The member status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubscriptionInfo")]
            [Validation(Required=false)]
            public ListOrganizationMembersResponseBodyDataSubscriptionInfo SubscriptionInfo { get; set; }
            public class ListOrganizationMembersResponseBodyDataSubscriptionInfo : TeaModel {
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("EquityList")]
                [Validation(Required=false)]
                public List<ListOrganizationMembersResponseBodyDataSubscriptionInfoEquityList> EquityList { get; set; }
                public class ListOrganizationMembersResponseBodyDataSubscriptionInfoEquityList : TeaModel {
                    [NameInMap("CycleEndTime")]
                    [Validation(Required=false)]
                    public long? CycleEndTime { get; set; }

                    [NameInMap("CycleStartTime")]
                    [Validation(Required=false)]
                    public long? CycleStartTime { get; set; }

                    [NameInMap("CycleSurplusValue")]
                    [Validation(Required=false)]
                    public double? CycleSurplusValue { get; set; }

                    [NameInMap("CycleTotalValue")]
                    [Validation(Required=false)]
                    public double? CycleTotalValue { get; set; }

                    [NameInMap("EquityType")]
                    [Validation(Required=false)]
                    public string EquityType { get; set; }

                    [NameInMap("EquityUnit")]
                    [Validation(Required=false)]
                    public string EquityUnit { get; set; }

                }

                [NameInMap("InstanceCode")]
                [Validation(Required=false)]
                public string InstanceCode { get; set; }

                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("SpecType")]
                [Validation(Required=false)]
                public string SpecType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
