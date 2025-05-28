// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostCenterResourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<QueryCostCenterResourceRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class QueryCostCenterResourceRequestEcIdAccountIds : TeaModel {
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1501603440974415</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAESEgoQCg4KCmd</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567812345678</para>
        /// </summary>
        [NameInMap("OwnerAccountId")]
        [Validation(Required=false)]
        public long? OwnerAccountId { get; set; }

    }

}
