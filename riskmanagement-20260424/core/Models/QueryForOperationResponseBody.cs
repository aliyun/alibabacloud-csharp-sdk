// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryForOperationResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryForOperationResponseBodyData Data { get; set; }
        public class QueryForOperationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The event data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryForOperationResponseBodyDataList> List { get; set; }
            public class QueryForOperationResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The application time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1788873796000</para>
                /// </summary>
                [NameInMap("ApplyTime")]
                [Validation(Required=false)]
                public long? ApplyTime { get; set; }

                /// <summary>
                /// <para>The asset type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>EIP</b>: VPC public IP address.</description></item>
                /// <item><description><b>SLB</b>: load balancing.</description></item>
                /// <item><description><b>ECS</b>: Public IP address in the classic network.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EIP</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <para>The review remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("AuditMemo")]
                [Validation(Required=false)]
                public string AuditMemo { get; set; }

                /// <summary>
                /// <para>The review time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1791937132000</para>
                /// </summary>
                [NameInMap("AuditTime")]
                [Validation(Required=false)]
                public long? AuditTime { get; set; }

                /// <summary>
                /// <para>The reviewer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>149754</para>
                /// </summary>
                [NameInMap("Auditor")]
                [Validation(Required=false)]
                public string Auditor { get; set; }

                /// <summary>
                /// <para>The customer UID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1068723216148614</para>
                /// </summary>
                [NameInMap("CustomerUid")]
                [Validation(Required=false)]
                public string CustomerUid { get; set; }

                /// <summary>
                /// <para>The type of the sent email.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("EmailType")]
                [Validation(Required=false)]
                public string EmailType { get; set; }

                /// <summary>
                /// <para>Specifies whether the email contains an unsubscribe option. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Yes.</description></item>
                /// <item><description><b>false</b>: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasUnsubscribe")]
                [Validation(Required=false)]
                public bool? HasUnsubscribe { get; set; }

                /// <summary>
                /// <para>The unique ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>710864062</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The IP address of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.158.58</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The description of the number of sent emails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SendCount")]
                [Validation(Required=false)]
                public string SendCount { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>auditing</b>: Under review.</description></item>
                /// <item><description><b>approved</b>: Approved.</description></item>
                /// <item><description><b>rejected</b>: Rejected.</description></item>
                /// <item><description><b>effective</b>: Effective.</description></item>
                /// <item><description><b>ineffective</b>: Ineffective.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("UseDesc")]
                [Validation(Required=false)]
                public string UseDesc { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public QueryForOperationResponseBodyDataPageInfo PageInfo { get; set; }
            public class QueryForOperationResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The page number from which the query results are displayed.</para>
                /// <remarks>
                /// <para>Default value: 1, which indicates that the query results are displayed from the first page.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The number of entries to return on each page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <para>The total number of events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEE90F8C-EDC2-5394-953B-D07A121612B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
