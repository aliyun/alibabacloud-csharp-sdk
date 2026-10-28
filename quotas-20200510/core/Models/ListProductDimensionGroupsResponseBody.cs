// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductDimensionGroupsResponseBody : Darabonba.Model {
        /// <summary>
        /// <para>The dimension groups.</para>
        /// </summary>
        [NameInMap("DimensionGroups")]
        [Validation(Required=false)]
        public List<ListProductDimensionGroupsResponseBodyDimensionGroups> DimensionGroups { get; set; }
        public class ListProductDimensionGroupsResponseBodyDimensionGroups : Darabonba.Model {
            /// <summary>
            /// <para>The keys of the dimension group.</para>
            /// </summary>
            [NameInMap("DimensionKeys")]
            [Validation(Required=false)]
            public List<string> DimensionKeys { get; set; }

            /// <summary>
            /// <para>The code of the dimension group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>entconsole_zjzp4d****</para>
            /// </summary>
            [NameInMap("GroupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

            /// <summary>
            /// <para>The name of the dimension group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Resource sharing</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The code of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>entconsole</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that marks the position where the returned query results end. An empty value indicates that all data is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>057D210F-F2FC-5329-A536-26C16628BB09</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}

