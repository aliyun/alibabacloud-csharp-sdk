// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class NearbySearchRequest : TeaModel {
        /// <summary>
        /// <para>搜索的关键词</para>
        /// </summary>
        [NameInMap("keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>搜索范围中心的纬度坐标。小数精度均不得超过六位</para>
        /// </summary>
        [NameInMap("latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// <para>搜索范围中心的经度坐标。小数精度均不得超过六位</para>
        /// </summary>
        [NameInMap("longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// <para>搜索的页数</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;total_count\&quot;: 6851, \&quot;page_number\&quot;: 54, \&quot;page_size\&quot;: 100}</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>搜索的范围，以米为单位。</para>
        /// </summary>
        [NameInMap("radius")]
        [Validation(Required=false)]
        public long? Radius { get; set; }

        /// <summary>
        /// <para>搜索结果每页所包含的结果数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>812788</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>目标类型的枚举值，以 <c>|</c> 标记分隔</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;synonym\&quot;,\&quot;stopword\&quot;,\&quot;correction\&quot;,\&quot;ner\&quot;,\&quot;term_weighting\&quot;,\&quot;category_prediction\&quot;]</para>
        /// </summary>
        [NameInMap("types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
