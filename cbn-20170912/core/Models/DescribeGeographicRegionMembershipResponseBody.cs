// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGeographicRegionMembershipResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of regions.</para>
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public DescribeGeographicRegionMembershipResponseBodyRegionIds RegionIds { get; set; }
        public class DescribeGeographicRegionMembershipResponseBodyRegionIds : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public List<DescribeGeographicRegionMembershipResponseBodyRegionIdsRegionId> RegionId { get; set; }
            public class DescribeGeographicRegionMembershipResponseBodyRegionIdsRegionId : TeaModel {
                /// <summary>
                /// <para>The ID of the region.</para>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the most recent region list.</para>
                /// 
                /// <b>Example:</b>
                /// <para>us-west-1</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC9EB0C9-60AF-4A09-A36C-608F70130274</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
