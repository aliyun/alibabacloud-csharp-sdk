// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineItemListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of image baseline data.</para>
        /// </summary>
        [NameInMap("BaselineItemInfos")]
        [Validation(Required=false)]
        public List<DescribeImageBaselineItemListResponseBodyBaselineItemInfos> BaselineItemInfos { get; set; }
        public class DescribeImageBaselineItemListResponseBodyBaselineItemInfos : TeaModel {
            /// <summary>
            /// <para>The alias of the baseline category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Access Key泄漏</para>
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// <para>The key of the baseline category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineClassKey")]
            [Validation(Required=false)]
            public string BaselineClassKey { get; set; }

            /// <summary>
            /// <para>The alias of the baseline sub-item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Access Key泄漏</para>
            /// </summary>
            [NameInMap("BaselineItemAlias")]
            [Validation(Required=false)]
            public string BaselineItemAlias { get; set; }

            /// <summary>
            /// <para>The key of the baseline sub-item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineItemKey")]
            [Validation(Required=false)]
            public string BaselineItemKey { get; set; }

            /// <summary>
            /// <para>The alias of the baseline name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Access Key泄漏</para>
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// <para>The key of the baseline name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineNameKey")]
            [Validation(Required=false)]
            public string BaselineNameKey { get; set; }

            /// <summary>
            /// <para>The fix status of the baseline risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unfixed</description></item>
            /// <item><description><b>1</b>: fixed</description></item>
            /// <item><description><b>2</b>: pending verification</description></item>
            /// <item><description><b>3</b>: fix failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The whitelist status of the baseline check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not whitelisted</description></item>
            /// <item><description><b>1</b>: whitelisted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public int? WhiteList { get; set; }

        }

        /// <summary>
        /// <para>The pagination information of the query results.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageBaselineItemListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageBaselineItemListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>253</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
