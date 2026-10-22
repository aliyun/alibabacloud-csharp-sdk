// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class QueryForOperationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryForOperationResponseBodyData Data { get; set; }
        public class QueryForOperationResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<QueryForOperationResponseBodyDataList> List { get; set; }
            public class QueryForOperationResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1788873796000</para>
                /// </summary>
                [NameInMap("ApplyTime")]
                [Validation(Required=false)]
                public long? ApplyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EIP</para>
                /// </summary>
                [NameInMap("AssetType")]
                [Validation(Required=false)]
                public string AssetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("AuditMemo")]
                [Validation(Required=false)]
                public string AuditMemo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1791937132000</para>
                /// </summary>
                [NameInMap("AuditTime")]
                [Validation(Required=false)]
                public long? AuditTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>149754</para>
                /// </summary>
                [NameInMap("Auditor")]
                [Validation(Required=false)]
                public string Auditor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1068723216148614</para>
                /// </summary>
                [NameInMap("CustomerUid")]
                [Validation(Required=false)]
                public string CustomerUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("EmailType")]
                [Validation(Required=false)]
                public string EmailType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasUnsubscribe")]
                [Validation(Required=false)]
                public bool? HasUnsubscribe { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>710864062</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.0.158.58</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SendCount")]
                [Validation(Required=false)]
                public string SendCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Executing</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("UseDesc")]
                [Validation(Required=false)]
                public string UseDesc { get; set; }

            }

            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public QueryForOperationResponseBodyDataPageInfo PageInfo { get; set; }
            public class QueryForOperationResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BEE90F8C-EDC2-5394-953B-D07A121612B5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
