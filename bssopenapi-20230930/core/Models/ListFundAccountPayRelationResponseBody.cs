// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class ListFundAccountPayRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListFundAccountPayRelationResponseBodyData> Data { get; set; }
        public class ListFundAccountPayRelationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account ID of the user associated with the payment relationship, that is, the account that uses this account for payment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32812132121</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The user name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云某的名称</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The enterprise entity ID of the user associated with the payment relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>213231232</para>
            /// </summary>
            [NameInMap("Ecid")]
            [Validation(Required=false)]
            public string Ecid { get; set; }

            /// <summary>
            /// <para>The time when the payment relationship takes effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-12-01 12:00:10</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123231213</para>
            /// </summary>
            [NameInMap("FundAccountId")]
            [Validation(Required=false)]
            public string FundAccountId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the account owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>312328912</para>
            /// </summary>
            [NameInMap("FundAccountOwnerAccountId")]
            [Validation(Required=false)]
            public string FundAccountOwnerAccountId { get; set; }

            /// <summary>
            /// <para>The time when the payment relationship expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 12:12:12</para>
            /// </summary>
            [NameInMap("IneffectiveTime")]
            [Validation(Required=false)]
            public string IneffectiveTime { get; set; }

            /// <summary>
            /// <para>The primary marketplace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2684210001</para>
            /// </summary>
            [NameInMap("Nbid")]
            [Validation(Required=false)]
            public string Nbid { get; set; }

            /// <summary>
            /// <para>The operator name.
            /// When the operator type is aliyun_pk, the operator name is the Alibaba Cloud nickname.
            /// When the operator type is system, the operator name is &quot;Alibaba Cloud assistant&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>云某的名称</para>
            /// </summary>
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <para>The authorized operator.
            /// When the operator type is aliyun_pk, operatorNo is the Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232343423</para>
            /// </summary>
            [NameInMap("OperatorNo")]
            [Validation(Required=false)]
            public string OperatorNo { get; set; }

            /// <summary>
            /// <para>The type of the authorized operator.
            /// aliyun_pk: user.
            /// system: Alibaba Cloud system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_pk</para>
            /// </summary>
            [NameInMap("OperatorType")]
            [Validation(Required=false)]
            public string OperatorType { get; set; }

            /// <summary>
            /// <para>The relationship type, which can be collection relationship or payment relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PAYMENT</para>
            /// </summary>
            [NameInMap("RelationType")]
            [Validation(Required=false)]
            public string RelationType { get; set; }

            /// <summary>
            /// <para>The site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Site")]
            [Validation(Required=false)]
            public string Site { get; set; }

            /// <summary>
            /// <para>The relationship status.
            /// valid: valid.
            /// expired: invalid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The response metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79EE7556-0CFD-44EB-9CD6-B3B526E3A85F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
