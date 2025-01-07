// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageRepoDetailListResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the information about image repositories.</para>
        /// </summary>
        [NameInMap("ImageRepoResponses")]
        [Validation(Required=false)]
        public List<DescribeImageRepoDetailListResponseBodyImageRepoResponses> ImageRepoResponses { get; set; }
        public class DescribeImageRepoDetailListResponseBodyImageRepoResponses : TeaModel {
            /// <summary>
            /// <para>The number of alerts that are generated for the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AlarmCount")]
            [Validation(Required=false)]
            public int? AlarmCount { get; set; }

            /// <summary>
            /// <para>Indicates whether alerts are generated for the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("AlarmStatus")]
            [Validation(Required=false)]
            public string AlarmStatus { get; set; }

            /// <summary>
            /// <para>The address of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///       {
            ///             &quot;domains&quot;: [
            ///                   &quot;<b><b>.cn-shenzhen.cr.aliyuncs.com&quot;
            ///             ],
            ///             &quot;type&quot;: &quot;internet&quot;
            ///       },
            ///       {
            ///             &quot;domains&quot;: [
            ///                   &quot;</b></b>.cn-shenzhen.cr.aliyuncs.com&quot;
            ///             ],
            ///             &quot;type&quot;: &quot;intranet&quot;
            ///       },
            ///       {
            ///             &quot;domains&quot;: [
            ///                   &quot;****.cn-shenzhen.cr.aliyuncs.com&quot;
            ///             ],
            ///             &quot;type&quot;: &quot;vpc&quot;
            ///       }
            /// ]</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            [NameInMap("HasRiskImageCount")]
            [Validation(Required=false)]
            public int? HasRiskImageCount { get; set; }

            /// <summary>
            /// <para>The number of baseline risk items on the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HcCount")]
            [Validation(Required=false)]
            public int? HcCount { get; set; }

            /// <summary>
            /// <para>Indicates whether baseline risk items are detected on the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NO</b></description></item>
            /// <item><description><b>YES</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("HcStatus")]
            [Validation(Required=false)]
            public string HcStatus { get; set; }

            /// <summary>
            /// <para>The number of images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public int? ImageCount { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf6fsg6xlmorug5****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>acr</b></description></item>
            /// <item><description><b>harbor</b></description></item>
            /// <item><description><b>quay</b></description></item>
            /// <item><description><b>CI/CD</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acr</para>
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// <para>The ID of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-2chlzf47w2rk****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

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
            /// <para>test-dev</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>Indicates whether the image repository is at risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("RiskStatus")]
            [Validation(Required=false)]
            public string RiskStatus { get; set; }

            /// <summary>
            /// <para>The number of vulnerabilities detected on the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("VulCount")]
            [Validation(Required=false)]
            public int? VulCount { get; set; }

            /// <summary>
            /// <para>Indicates whether vulnerabilities are detected on the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>YES</b></description></item>
            /// <item><description><b>NO</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NO</para>
            /// </summary>
            [NameInMap("VulStatus")]
            [Validation(Required=false)]
            public string VulStatus { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageRepoDetailListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageRepoDetailListResponseBodyPageInfo : TeaModel {
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
            /// <para>19</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B48AB3C-84FC-424D-A01D-B9270EF46038</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
