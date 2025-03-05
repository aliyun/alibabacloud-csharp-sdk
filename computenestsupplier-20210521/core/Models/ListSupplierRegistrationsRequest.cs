// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListSupplierRegistrationsRequest : TeaModel {
        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListSupplierRegistrationsRequestFilter> Filter { get; set; }
        public class ListSupplierRegistrationsRequestFilter : TeaModel {
            /// <summary>
            /// <para>Name of the filter field. Allowed values:</para>
            /// <list type="bullet">
            /// <item><description><para>SupplierUid: The aliUid of supplier.</para>
            /// </description></item>
            /// <item><description><para>SupplierName: The name of supplier.</para>
            /// </description></item>
            /// <item><description><para>RegistrationId: Registration ID.</para>
            /// </description></item>
            /// <item><description><para>Status: Registration status. Allowed values: Submitted, Approved, Rejected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SupplierUid</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Filter value.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>Number of items per page in a paginated query. The maximum is 100, and the default is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAYChudnQUoBH+mGWFpb6oP0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
