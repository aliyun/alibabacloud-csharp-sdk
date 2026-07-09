// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20230930.Models
{
    public class QueryCostCenterRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cost center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>597745</para>
        /// </summary>
        [NameInMap("CostCenterId")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>List of enterprises and accounts. If empty, queries the current account itself.</para>
        /// </summary>
        [NameInMap("EcIdAccountIds")]
        [Validation(Required=false)]
        public List<QueryCostCenterRuleRequestEcIdAccountIds> EcIdAccountIds { get; set; }
        public class QueryCostCenterRuleRequestEcIdAccountIds : TeaModel {
            /// <summary>
            /// <para>List of accounts to access. If empty, all accounts under the current entity ID are selected.</para>
            /// </summary>
            [NameInMap("AccountIds")]
            [Validation(Required=false)]
            public List<long?> AccountIds { get; set; }

            /// <summary>
            /// <para>Enterprise entity ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1004064243473974</para>
            /// </summary>
            [NameInMap("EcId")]
            [Validation(Required=false)]
            public string EcId { get; set; }

        }

        /// <summary>
        /// <para>Primary marketplace ID. If empty, the marketplace ID of the current user is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2684201000001</para>
        /// </summary>
        [NameInMap("Nbid")]
        [Validation(Required=false)]
        public string Nbid { get; set; }

    }

}
