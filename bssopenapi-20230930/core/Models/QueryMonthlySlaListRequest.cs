// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryMonthlySlaListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<QueryMonthlySlaListRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class QueryMonthlySlaListRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1501603440974415</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;instance_1&quot;,&quot;instance_2&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[202602,202603]</para>
        /// </summary>
        [NameInMap("Months")]
        [Validation(Required=false)]
        public List<int?> Months { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PayStatuses")]
        [Validation(Required=false)]
        public List<int?> PayStatuses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;ecs&quot;,&quot;oss&quot;]</para>
        /// </summary>
        [NameInMap("ProductCodes")]
        [Validation(Required=false)]
        public List<string> ProductCodes { get; set; }

    }

}
