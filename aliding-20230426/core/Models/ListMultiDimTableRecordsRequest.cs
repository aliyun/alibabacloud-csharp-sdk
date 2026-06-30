// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListMultiDimTableRecordsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("BaseId")]
        [Validation(Required=false)]
        public string BaseId { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ListMultiDimTableRecordsRequestFilter Filter { get; set; }
        public class ListMultiDimTableRecordsRequestFilter : TeaModel {
            [NameInMap("Combination")]
            [Validation(Required=false)]
            public string Combination { get; set; }

            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<ListMultiDimTableRecordsRequestFilterConditions> Conditions { get; set; }
            public class ListMultiDimTableRecordsRequestFilterConditions : TeaModel {
                [NameInMap("Field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public List<object> Value { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SheetIdOrName")]
        [Validation(Required=false)]
        public string SheetIdOrName { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public ListMultiDimTableRecordsRequestTenantContext TenantContext { get; set; }
        public class ListMultiDimTableRecordsRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
