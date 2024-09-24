// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineItemListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of baseline check items.</para>
        /// </summary>
        [NameInMap("BaselineItemInfos")]
        [Validation(Required=false)]
        public List<DescribeImageBaselineItemListResponseBodyBaselineItemInfos> BaselineItemInfos { get; set; }
        public class DescribeImageBaselineItemListResponseBodyBaselineItemInfos : TeaModel {
            /// <summary>
            /// <para>The alias of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey pair leak</para>
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// <para>The key of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineClassKey")]
            [Validation(Required=false)]
            public string BaselineClassKey { get; set; }

            /// <summary>
            /// <para>The alias of the baseline check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey pair leak</para>
            /// </summary>
            [NameInMap("BaselineItemAlias")]
            [Validation(Required=false)]
            public string BaselineItemAlias { get; set; }

            /// <summary>
            /// <para>The key of the baseline check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ak_leak</para>
            /// </summary>
            [NameInMap("BaselineItemKey")]
            [Validation(Required=false)]
            public string BaselineItemKey { get; set; }

            /// <summary>
            /// <para>The alias of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AccessKey pair leak</para>
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
            /// <para>The status of the baseline risks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unfixed</description></item>
            /// <item><description><b>1</b>: fixed</description></item>
            /// <item><description><b>2</b>: pending verification</description></item>
            /// <item><description><b>3</b>: fixing failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the baseline check item is added to the whitelist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The baseline check item is not added to the whitelist.</description></item>
            /// <item><description><b>1</b>: The baseline check item is added to the whitelist.</description></item>
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
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageBaselineItemListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageBaselineItemListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
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
