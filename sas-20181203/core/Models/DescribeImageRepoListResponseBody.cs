// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoListResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of image repositories that are added to Security Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("AddTargetCount")]
        [Validation(Required=false)]
        public int? AddTargetCount { get; set; }

        /// <summary>
        /// <para>The total number of image repositories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("AllTargetCount")]
        [Validation(Required=false)]
        public int? AllTargetCount { get; set; }

        /// <summary>
        /// <para>The number of excluded image repositories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DelTargetCount")]
        [Validation(Required=false)]
        public int? DelTargetCount { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about image repositories.</para>
        /// </summary>
        [NameInMap("ImageRepoList")]
        [Validation(Required=false)]
        public List<DescribeImageRepoListResponseBodyImageRepoList> ImageRepoList { get; set; }
        public class DescribeImageRepoListResponseBodyImageRepoList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the feature takes effect on the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>add</b>: yes</description></item>
            /// <item><description><b>del</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>add</para>
            /// </summary>
            [NameInMap("Flag")]
            [Validation(Required=false)]
            public string Flag { get; set; }

            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public int? ImageCount { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zeus</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace to which the image repository belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-script</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageRepoListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageRepoListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
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
            /// <para>The total number of image repositories.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
