// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListServiceUsagesRequest : TeaModel {
        /// <summary>
        /// <para>The filters.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListServiceUsagesRequestFilter> Filter { get; set; }
        public class ListServiceUsagesRequestFilter : TeaModel {
            /// <summary>
            /// <para>The parameter name of the filter. You can specify one or more filters. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ServiceId: the ID of the service.</description></item>
            /// <item><description>ServiceName: the service name.</description></item>
            /// <item><description>Status: the state of the service.</description></item>
            /// <item><description>SupplierName: the name of the service provider.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceId</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter values of the filter.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
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

    }

}
