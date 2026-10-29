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
            /// <para>The business ID of the member.</para>
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
            /// <para>The email address of the member.</para>
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
            /// <para>The ID of the organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org_123456789</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The upper limit information for the shared usage package available to the member.</para>
            /// </summary>
            [NameInMap("PackLimitInfo")]
            [Validation(Required=false)]
            public ListOrganizationMembersResponseBodyDataPackLimitInfo PackLimitInfo { get; set; }
            public class ListOrganizationMembersResponseBodyDataPackLimitInfo : TeaModel {
                /// <summary>
                /// <para>The currently available quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("AvailableLimit")]
                [Validation(Required=false)]
                public double? AvailableLimit { get; set; }

                /// <summary>
                /// <para>The end time of the current cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1792476000001</para>
                /// </summary>
                [NameInMap("CycleEndTime")]
                [Validation(Required=false)]
                public long? CycleEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the current cycle.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1792476000000</para>
                /// </summary>
                [NameInMap("CycleStartTime")]
                [Validation(Required=false)]
                public long? CycleStartTime { get; set; }

                /// <summary>
                /// <para>The frozen quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FrozenCredits")]
                [Validation(Required=false)]
                public double? FrozenCredits { get; set; }

                /// <summary>
                /// <para>Indicates whether a quota limit exists for the shared usage package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("HasShareLimit")]
                [Validation(Required=false)]
                public bool? HasShareLimit { get; set; }

                /// <summary>
                /// <para>Indicates whether the quota is currently available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true/false</para>
                /// </summary>
                [NameInMap("IsAvailable")]
                [Validation(Required=false)]
                public bool? IsAvailable { get; set; }

                /// <summary>
                /// <para>The time when the quota limit configuration was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1792476000000</para>
                /// </summary>
                [NameInMap("LastConfirmedTime")]
                [Validation(Required=false)]
                public long? LastConfirmedTime { get; set; }

                /// <summary>
                /// <para>The upper limit of the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50000</para>
                /// </summary>
                [NameInMap("UpperLimit")]
                [Validation(Required=false)]
                public double? UpperLimit { get; set; }

                /// <summary>
                /// <para>The used quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UsedCredits")]
                [Validation(Required=false)]
                public double? UsedCredits { get; set; }

            }

            /// <summary>
            /// <para>The list of roles for the member.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <para>The resource allocation ID of the seat.</para>
            /// 
            /// <b>Example:</b>
            /// <para>seat_123456</para>
            /// </summary>
            [NameInMap("SeatId")]
            [Validation(Required=false)]
            public string SeatId { get; set; }

            /// <summary>
            /// <para>The specification type of the seat. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>standard: Standard seat.</description></item>
            /// <item><description>pro: Pro seat.</description></item>
            /// <item><description>max: Premium seat.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>The status of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subscription information of the member.</para>
            /// </summary>
            [NameInMap("SubscriptionInfo")]
            [Validation(Required=false)]
            public ListOrganizationMembersResponseBodyDataSubscriptionInfo SubscriptionInfo { get; set; }
            public class ListOrganizationMembersResponseBodyDataSubscriptionInfo : TeaModel {
                /// <summary>
                /// <para>The end time of the subscription.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1792476000002</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The list of subscription entitlements.</para>
                /// </summary>
                [NameInMap("EquityList")]
                [Validation(Required=false)]
                public List<ListOrganizationMembersResponseBodyDataSubscriptionInfoEquityList> EquityList { get; set; }
                public class ListOrganizationMembersResponseBodyDataSubscriptionInfoEquityList : TeaModel {
                    /// <summary>
                    /// <para>The start time of the current cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1792476000001</para>
                    /// </summary>
                    [NameInMap("CycleEndTime")]
                    [Validation(Required=false)]
                    public long? CycleEndTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the current cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1792476000000</para>
                    /// </summary>
                    [NameInMap("CycleStartTime")]
                    [Validation(Required=false)]
                    public long? CycleStartTime { get; set; }

                    /// <summary>
                    /// <para>The remaining entitlement quota for the current cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32259</para>
                    /// </summary>
                    [NameInMap("CycleSurplusValue")]
                    [Validation(Required=false)]
                    public double? CycleSurplusValue { get; set; }

                    /// <summary>
                    /// <para>The total entitlement quota for the current cycle.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>250000</para>
                    /// </summary>
                    [NameInMap("CycleTotalValue")]
                    [Validation(Required=false)]
                    public double? CycleTotalValue { get; set; }

                    /// <summary>
                    /// <para>The entitlement type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CREDITS</para>
                    /// </summary>
                    [NameInMap("EquityType")]
                    [Validation(Required=false)]
                    public string EquityType { get; set; }

                    /// <summary>
                    /// <para>The unit of measurement for the entitlement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Credit</para>
                    /// </summary>
                    [NameInMap("EquityUnit")]
                    [Validation(Required=false)]
                    public string EquityUnit { get; set; }

                }

                /// <summary>
                /// <para>The code of the subscription instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>subs-1234567</para>
                /// </summary>
                [NameInMap("InstanceCode")]
                [Validation(Required=false)]
                public string InstanceCode { get; set; }

                /// <summary>
                /// <para>The billing method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>total</para>
                /// </summary>
                [NameInMap("PayMode")]
                [Validation(Required=false)]
                public string PayMode { get; set; }

                /// <summary>
                /// <para>The code of the subscription product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sfm_tokenplanteams_dp_cn</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The specification type of the subscription.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("SpecType")]
                [Validation(Required=false)]
                public string SpecType { get; set; }

                /// <summary>
                /// <para>The start time of the subscription.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1792476000000</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The subscription status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
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
