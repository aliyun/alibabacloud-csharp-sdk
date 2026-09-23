// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryMonthlySlaListRequest : TeaModel {
        /// <summary>
        /// <para>The current page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of enterprise entities and accounts. If this parameter is left empty, the current account is queried.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<QueryMonthlySlaListRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class QueryMonthlySlaListRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>The list of accounts to access. If this parameter is left empty, all accounts under the current entity ID are selected.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>The enterprise entity ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1501603440974415</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>Optional. The instance IDs used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;instance_1&quot;,&quot;instance_2&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>Optional. The list of months in the yyyyMM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[202602,202603]</para>
        /// </summary>
        [NameInMap("Months")]
        [Validation(Required=false)]
        public List<int?> Months { get; set; }

        /// <summary>
        /// <para>The primary marketplace ID. If this parameter is left empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Optional. The compensation statuses used for filtering. Valid values: 0 and 1.</para>
        /// </summary>
        [NameInMap("PayStatuses")]
        [Validation(Required=false)]
        public List<int?> PayStatuses { get; set; }

        /// <summary>
        /// <para>Optional. The product codes used for filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ecs&quot;,&quot;oss&quot;]</para>
        /// </summary>
        [NameInMap("ProductCodes")]
        [Validation(Required=false)]
        public List<string> ProductCodes { get; set; }

    }

}
