// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePackageConfigResponseBody : TeaModel {
        [NameInMap("LivePackageConfigList")]
        [Validation(Required=false)]
        public DescribeLivePackageConfigResponseBodyLivePackageConfigList LivePackageConfigList { get; set; }
        public class DescribeLivePackageConfigResponseBodyLivePackageConfigList : TeaModel {
            [NameInMap("LivePackageConfig")]
            [Validation(Required=false)]
            public List<DescribeLivePackageConfigResponseBodyLivePackageConfigListLivePackageConfig> LivePackageConfig { get; set; }
            public class DescribeLivePackageConfigResponseBodyLivePackageConfigListLivePackageConfig : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("IgnoreTranscode")]
                [Validation(Required=false)]
                public bool? IgnoreTranscode { get; set; }

                [NameInMap("PartDuration")]
                [Validation(Required=false)]
                public int? PartDuration { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("SegmentDuration")]
                [Validation(Required=false)]
                public int? SegmentDuration { get; set; }

                [NameInMap("SegmentNum")]
                [Validation(Required=false)]
                public int? SegmentNum { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

        }

        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b> (default): ascending order</description></item>
        /// <item><description><b>desc</b>: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>1FEDCFD8-4C5D-5CB3-A5A1-0B59E5AE57B0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of live stream encapsulation configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
