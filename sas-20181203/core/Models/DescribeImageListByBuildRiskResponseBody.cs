// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListByBuildRiskResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageListByBuildRiskResponseBodyData Data { get; set; }
        public class DescribeImageListByBuildRiskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of images.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DescribeImageListByBuildRiskResponseBodyDataList> List { get; set; }
            public class DescribeImageListByBuildRiskResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The digest value of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a5ccdd9b166b67e02954aa9b618fe19b7968bd56a15463d2ad7f2643ba5b****</para>
                /// </summary>
                [NameInMap("Digest")]
                [Validation(Required=false)]
                public string Digest { get; set; }

                /// <summary>
                /// <para>The timestamp of the first scan. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723710827000</para>
                /// </summary>
                [NameInMap("FirstScanTime")]
                [Validation(Required=false)]
                public long? FirstScanTime { get; set; }

                /// <summary>
                /// <para>The instance ID of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>39010****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The timestamp of the most recent scan. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1723710827999</para>
                /// </summary>
                [NameInMap("LastScanTime")]
                [Validation(Required=false)]
                public long? LastScanTime { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The name of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-tepo</para>
                /// </summary>
                [NameInMap("RepoName")]
                [Validation(Required=false)]
                public string RepoName { get; set; }

                /// <summary>
                /// <para>The namespace of the image repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespace</para>
                /// </summary>
                [NameInMap("RepoNamespace")]
                [Validation(Required=false)]
                public string RepoNamespace { get; set; }

                /// <summary>
                /// <para>The risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>high</b></description></item>
                /// <item><description><b>medium</b></description></item>
                /// <item><description><b>low</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>medium</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The status of the alert event to query. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Unhandled.</description></item>
                /// <item><description><b>1</b>: Ignored.</description></item>
                /// <item><description><b>2</b>: False positive.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The tag of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The UUID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6ec898e6274f942e0e4a053eff1c****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The pagination information.</para>
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeImageListByBuildRiskResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeImageListByBuildRiskResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// <para>The page number of the current page in paging query. Default value: <b>1</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <para>The maximum number of entries per page in paging query. Default value: 20. If you leave this parameter empty, 20 entries are returned.</para>
                /// <remarks>
                /// <para>Do not leave PageSize empty.</para>
                /// </remarks>
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
                /// <para>109</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The detailed information about the error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52870893-48A7-5A9E-9E05-6253E5B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
