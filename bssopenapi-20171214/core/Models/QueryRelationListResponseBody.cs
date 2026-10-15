// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryRelationListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRelationListResponseBodyData Data { get; set; }
        public class QueryRelationListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of relationships.</para>
            /// </summary>
            [NameInMap("FinancialRelationInfoList")]
            [Validation(Required=false)]
            public List<QueryRelationListResponseBodyDataFinancialRelationInfoList> FinancialRelationInfoList { get; set; }
            public class QueryRelationListResponseBodyDataFinancialRelationInfoList : TeaModel {
                /// <summary>
                /// <para>The UID of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1851253838840762</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// <para>The logon name of the Alibaba Cloud account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>caiwuyun_test4</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The display name of the account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test4</para>
                /// </summary>
                [NameInMap("AccountNickName")]
                [Validation(Required=false)]
                public string AccountNickName { get; set; }

                /// <summary>
                /// <para>The type of the financial account. Valid values: MASTER and MEMBER.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MEMBER</para>
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// <para>The time when the relationship expires. If this parameter is empty, the relationship does not expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-08T15:12Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The relationship ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>51463</para>
                /// </summary>
                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public long? RelationId { get; set; }

                /// <summary>
                /// <para>The relationship type. <c>FinancialManagement</c> indicates Financial Management and <c>FinancialTrusteeship</c> indicates finance trusteeship.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinancialManagement</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The time when the relationship was established. The time is in UTC and follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-02T15:12Z</para>
                /// </summary>
                [NameInMap("SetupTime")]
                [Validation(Required=false)]
                public string SetupTime { get; set; }

                /// <summary>
                /// <para>The time when the relationship takes effect. The time is in UTC and follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-02T15:12Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status of the relationship. The value is an enumeration of RelationshipStatusEnum.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RELATED</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

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
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7FC5D662-37FD-40A6-85B1-33442D815184</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
