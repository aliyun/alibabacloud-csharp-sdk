// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiProductsByAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about API products.</para>
        /// </summary>
        [NameInMap("ApiProductInfoList")]
        [Validation(Required=false)]
        public DescribeApiProductsByAppResponseBodyApiProductInfoList ApiProductInfoList { get; set; }
        public class DescribeApiProductsByAppResponseBodyApiProductInfoList : TeaModel {
            [NameInMap("ApiProductInfo")]
            [Validation(Required=false)]
            public List<DescribeApiProductsByAppResponseBodyApiProductInfoListApiProductInfo> ApiProductInfo { get; set; }
            public class DescribeApiProductsByAppResponseBodyApiProductInfoListApiProductInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the API product.</para>
                /// 
                /// <b>Example:</b>
                /// <para>117b7a64a8b3f064eaa4a47ac62aac5e</para>
                /// </summary>
                [NameInMap("ApiProductId")]
                [Validation(Required=false)]
                public string ApiProductId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B805201-AF4C-5788-AC9E-C3EEC83DC82A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
