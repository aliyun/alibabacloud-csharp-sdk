// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListImageRiskResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of image risk information.</para>
        /// </summary>
        [NameInMap("ImageRiskList")]
        [Validation(Required=false)]
        public List<ListImageRiskResponseBodyImageRiskList> ImageRiskList { get; set; }
        public class ListImageRiskResponseBodyImageRiskList : TeaModel {
            /// <summary>
            /// <para>The digest value of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f8efc2184cf1d24936b49c27286a284714b77be34c80c9ee38ca6bf322445****</para>
            /// </summary>
            [NameInMap("Digest")]
            [Validation(Required=false)]
            public string Digest { get; set; }

            /// <summary>
            /// <para>The list of endpoint information.</para>
            /// </summary>
            [NameInMap("EndPointList")]
            [Validation(Required=false)]
            public List<ListImageRiskResponseBodyImageRiskListEndPointList> EndPointList { get; set; }
            public class ListImageRiskResponseBodyImageRiskListEndPointList : TeaModel {
                /// <summary>
                /// <para>The list of endpoint domain names.</para>
                /// </summary>
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public List<string> Domains { get; set; }

                /// <summary>
                /// <para>The type of the endpoint domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>internet</b>: public network</description></item>
                /// <item><description><b>intranet</b>: private network.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>internet</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The list of endpoints for the image service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://172.20.XXX.XXX/test">https://172.20.XXX.XXX/test</a></para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public string Endpoints { get; set; }

            /// <summary>
            /// <para>The image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>.aliyuncs.com/sas_test/baseline:exploit</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The registration status of the image repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IN_SAS</b>: The repository is registered in Security Center.</description></item>
            /// <item><description><b>NOT_IN_SAS</b>: The repository is not registered in Security Center.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IN_SAS</para>
            /// </summary>
            [NameInMap("ImageAccessType")]
            [Validation(Required=false)]
            public string ImageAccessType { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f922bfeb6960436fe3f0e7b62fc6b9a0b47980986669c367c22433269404****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The public network access URL of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>registry-registry.cn-shenzhen-finance-1.cr.aliyuncs.com/xxxx/docker-</b></b></para>
            /// </summary>
            [NameInMap("InternetURLs")]
            [Validation(Required=false)]
            public string InternetURLs { get; set; }

            /// <summary>
            /// <para>The region where the image repository resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The type of the image registry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>acr</b>: ACR</description></item>
            /// <item><description><b>harbor</b>: Harbor</description></item>
            /// <item><description><b>quay</b>: Quay</description></item>
            /// <item><description><b>CI/CD</b>: Jenkins.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>harbor</para>
            /// </summary>
            [NameInMap("RegistryType")]
            [Validation(Required=false)]
            public string RegistryType { get; set; }

            /// <summary>
            /// <para>The ID of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-bk2l746eyxca1****</para>
            /// </summary>
            [NameInMap("RepoId")]
            [Validation(Required=false)]
            public string RepoId { get; set; }

            /// <summary>
            /// <para>The name of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scan_test</para>
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// <para>The image namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vultar***</para>
            /// </summary>
            [NameInMap("RepoNamespace")]
            [Validation(Required=false)]
            public string RepoNamespace { get; set; }

            /// <summary>
            /// <para>The repository type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PUBLIC</c>: public</para>
            /// </description></item>
            /// <item><description><para><c>PRIVATE</c>: private.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE</para>
            /// </summary>
            [NameInMap("RepoType")]
            [Validation(Required=false)]
            public string RepoType { get; set; }

            /// <summary>
            /// <para>The statistics of security events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;baselineNum&quot;: 0,
            ///     &quot;newSuspicious&quot;: 0,
            ///     &quot;vul&quot;: 0
            /// }</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The image tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.1.0</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The tag immutability setting. If immutability is enabled, image versions other than latest cannot be used to overwrite existing versions in this repository. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Mutable.</description></item>
            /// <item><description><b>1</b>: Immutable.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TagImmutable")]
            [Validation(Required=false)]
            public int? TagImmutable { get; set; }

            /// <summary>
            /// <para>The unique identifier of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>624778f3-5bf2-423c-ac0c-47a62c05****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The VPC access URL of the image repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>-registry-registry-vpc.cn-shenzhen-finance-1.cr.aliyuncs.com/xxxx/docker-</b></b></para>
            /// </summary>
            [NameInMap("VpcURLs")]
            [Validation(Required=false)]
            public string VpcURLs { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListImageRiskResponseBodyPageInfo PageInfo { get; set; }
        public class ListImageRiskResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paging query.</para>
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
            /// <para>23</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>050ACC7A-D4FD-55C6-B861-BA9569C1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
