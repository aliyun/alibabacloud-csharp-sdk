// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChartReleaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of chart versions.</para>
        /// </summary>
        [NameInMap("ChartReleases")]
        [Validation(Required=false)]
        public List<ListChartReleaseResponseBodyChartReleases> ChartReleases { get; set; }
        public class ListChartReleaseResponseBodyChartReleases : TeaModel {
            /// <summary>
            /// <para>The chart version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chart1</para>
            /// </summary>
            [NameInMap("Chart")]
            [Validation(Required=false)]
            public string Chart { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-xkx6vujuhay0****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The time when the chart was last modified. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1571930323000</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The chart version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1.0</para>
            /// </summary>
            [NameInMap("Release")]
            [Validation(Required=false)]
            public string Release { get; set; }

            /// <summary>
            /// <para>The chart repository ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crcr-gpsu7b8chmxk****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The size of the chart version, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2826</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLED</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F68823F6-F1B5-4A4E-8421-A83CAB8F2963</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
