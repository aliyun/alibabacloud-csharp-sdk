// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePackageConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The live stream encapsulation configurations.</para>
        /// </summary>
        [NameInMap("LivePackageConfigList")]
        [Validation(Required=false)]
        public DescribeLivePackageConfigResponseBodyLivePackageConfigList LivePackageConfigList { get; set; }
        public class DescribeLivePackageConfigResponseBodyLivePackageConfigList : TeaModel {
            [NameInMap("LivePackageConfig")]
            [Validation(Required=false)]
            public List<DescribeLivePackageConfigResponseBodyLivePackageConfigListLivePackageConfig> LivePackageConfig { get; set; }
            public class DescribeLivePackageConfigResponseBodyLivePackageConfigListLivePackageConfig : TeaModel {
                /// <summary>
                /// <para>The application name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AppName</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>Indicates whether the transcoded stream is ignored. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b> (default)</description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IgnoreTranscode")]
                [Validation(Required=false)]
                public bool? IgnoreTranscode { get; set; }

                /// <summary>
                /// <para>The part length. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PartDuration")]
                [Validation(Required=false)]
                public int? PartDuration { get; set; }

                /// <summary>
                /// <para>The streaming protocol and encapsulation format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HLS_CMAF</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The segment length. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SegmentDuration")]
                [Validation(Required=false)]
                public int? SegmentDuration { get; set; }

                /// <summary>
                /// <para>The number of segments.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SegmentNum")]
                [Validation(Required=false)]
                public int? SegmentNum { get; set; }

                /// <summary>
                /// <para>The stream name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StreamName</para>
                /// </summary>
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
