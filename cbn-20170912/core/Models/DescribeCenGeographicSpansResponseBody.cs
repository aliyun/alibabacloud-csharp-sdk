// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenGeographicSpansResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of areas.</para>
        /// </summary>
        [NameInMap("GeographicSpanModels")]
        [Validation(Required=false)]
        public DescribeCenGeographicSpansResponseBodyGeographicSpanModels GeographicSpanModels { get; set; }
        public class DescribeCenGeographicSpansResponseBodyGeographicSpanModels : TeaModel {
            [NameInMap("GeographicSpanModel")]
            [Validation(Required=false)]
            public List<DescribeCenGeographicSpansResponseBodyGeographicSpanModelsGeographicSpanModel> GeographicSpanModel { get; set; }
            public class DescribeCenGeographicSpansResponseBodyGeographicSpanModelsGeographicSpanModel : TeaModel {
                /// <summary>
                /// <para>The ID of the pair of connected areas.</para>
                /// 
                /// <b>Example:</b>
                /// <para>china_asia-pacific</para>
                /// </summary>
                [NameInMap("GeographicSpanId")]
                [Validation(Required=false)]
                public string GeographicSpanId { get; set; }

                /// <summary>
                /// <para>The ID of the local area.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asia-pacific</para>
                /// </summary>
                [NameInMap("LocalGeoRegionId")]
                [Validation(Required=false)]
                public string LocalGeoRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the peer area.</para>
                /// 
                /// <b>Example:</b>
                /// <para>china</para>
                /// </summary>
                [NameInMap("OppositeGeoRegionId")]
                [Validation(Required=false)]
                public string OppositeGeoRegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09780287-BC24-4164-8334-773432E32696</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
