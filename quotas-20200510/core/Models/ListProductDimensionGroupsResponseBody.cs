// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductDimensionGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The dimension groups.</para>
        /// </summary>
        [NameInMap("DimensionGroups")]
        [Validation(Required=false)]
        public List<ListProductDimensionGroupsResponseBodyDimensionGroups> DimensionGroups { get; set; }
        public class ListProductDimensionGroupsResponseBodyDimensionGroups : TeaModel {
            /// <summary>
            /// <para>The key of the dimension group.</para>
            /// </summary>
            [NameInMap("DimensionKeys")]
            [Validation(Required=false)]
            public List<string> DimensionKeys { get; set; }

            /// <summary>
            /// <para>The code of the dimension group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss_wf1ngqmd7q</para>
            /// </summary>
            [NameInMap("GroupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

            /// <summary>
            /// <para>The name of the dimension group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS_Group</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The service code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records that are returned for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position at which the query ends. An empty value indicates that all data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>057D210F-F2FC-5329-A536-26C16628BB09</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that are returned for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
