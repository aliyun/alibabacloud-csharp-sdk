// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListBySensitiveFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of <b>200</b> indicates success, whereas other values indicate failure. You can use this field to identify the cause of the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of image information.</para>
        /// </summary>
        [NameInMap("ImageInfos")]
        [Validation(Required=false)]
        public List<DescribeImageListBySensitiveFileResponseBodyImageInfos> ImageInfos { get; set; }
        public class DescribeImageListBySensitiveFileResponseBodyImageInfos : TeaModel {
            /// <summary>
            /// <para>The image digest.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v005</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <para>The timestamp of the first scan. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649814050000</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// <para>The ID of the image instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cri-a595qp31knh9****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sec-NessusSc</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The timestamp of the latest scan. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649814050000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The region ID of the image instance.</para>
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
            /// <para>opa-test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The namespace of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>libssh2</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The risk level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b>: high</description></item>
            /// <item><description><b>medium</b>: medium</description></item>
            /// <item><description><b>low</b>: low</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The status of the sensitive file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: unhandled</description></item>
            /// <item><description><b>1</b>: ignored</description></item>
            /// <item><description><b>2</b>: false positive</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The image tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nuxeo6</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The unique identifier of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f58681174f944623345379e23b7b****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

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
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageListBySensitiveFileResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageListBySensitiveFileResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
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
            /// <para>The key of the last entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CAESGgoSChAKDGNvbXBsZXRlVGltZRABCgQiAggAGAAiQAoJAGYXFWIAAAAACjMDLgAAADFTNzMyZDMwMzAzMDM1Mzc3Njc4MzA2ODY5NmI2YTY1Nzg2NTcxNjE2NDc4NjE=</para>
            /// </summary>
            [NameInMap("LastRowKey")]
            [Validation(Required=false)]
            public string LastRowKey { get; set; }

            /// <summary>
            /// <para>The number of alert events returned per page in a paged query. Default value: <b>20</b>, which indicates that 20 alert events are returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request and can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0C5C07F-1576-509A-AE44-1C36B8445B37</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the operation result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The operation is successful.</description></item>
        /// <item><description><b>false</b>: The operation fails.</description></item>
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
