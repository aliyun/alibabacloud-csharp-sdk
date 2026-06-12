// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceUsagesRequest : TeaModel {
        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListServiceUsagesRequestFilter> Filter { get; set; }
        public class ListServiceUsagesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter name. You can query by one or more names. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ServiceId: The service ID.</para>
            /// </description></item>
            /// <item><description><para>ServiceName: The service name.</para>
            /// </description></item>
            /// <item><description><para>Status: The service status.</para>
            /// </description></item>
            /// <item><description><para>SupplierName: The supplier name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The filter values. You can specify 1 to 10 values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page. The maximum value is 100. The default value is 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. You can obtain this token from the NextToken parameter in the response to the previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The supplier role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Supplier</para>
        /// </summary>
        [NameInMap("SupplierRole")]
        [Validation(Required=false)]
        public string SupplierRole { get; set; }

    }

}
