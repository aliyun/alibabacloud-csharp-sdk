// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetK8sClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated list of clusters.</para>
        /// </summary>
        [NameInMap("ClusterPage")]
        [Validation(Required=false)]
        public GetK8sClusterResponseBodyClusterPage ClusterPage { get; set; }
        public class GetK8sClusterResponseBodyClusterPage : TeaModel {
            [NameInMap("ClusterList")]
            [Validation(Required=false)]
            public GetK8sClusterResponseBodyClusterPageClusterList ClusterList { get; set; }
            public class GetK8sClusterResponseBodyClusterPageClusterList : TeaModel {
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public List<GetK8sClusterResponseBodyClusterPageClusterListCluster> Cluster { get; set; }
                public class GetK8sClusterResponseBodyClusterPageClusterListCluster : TeaModel {
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    [NameInMap("ClusterImportStatus")]
                    [Validation(Required=false)]
                    public int? ClusterImportStatus { get; set; }

                    [NameInMap("ClusterName")]
                    [Validation(Required=false)]
                    public string ClusterName { get; set; }

                    [NameInMap("ClusterStatus")]
                    [Validation(Required=false)]
                    public int? ClusterStatus { get; set; }

                    [NameInMap("ClusterType")]
                    [Validation(Required=false)]
                    public int? ClusterType { get; set; }

                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public int? Cpu { get; set; }

                    [NameInMap("CsClusterId")]
                    [Validation(Required=false)]
                    public string CsClusterId { get; set; }

                    [NameInMap("CsClusterStatus")]
                    [Validation(Required=false)]
                    public string CsClusterStatus { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Mem")]
                    [Validation(Required=false)]
                    public int? Mem { get; set; }

                    [NameInMap("NetworkMode")]
                    [Validation(Required=false)]
                    public int? NetworkMode { get; set; }

                    [NameInMap("NodeNum")]
                    [Validation(Required=false)]
                    public int? NodeNum { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("SubClusterType")]
                    [Validation(Required=false)]
                    public string SubClusterType { get; set; }

                    [NameInMap("SubNetCidr")]
                    [Validation(Required=false)]
                    public string SubNetCidr { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("VswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of the returned page. The default value is 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. The default value is 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The status of the call or a POP error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3CE915C-0C83-4AA5-8D66-E8BEED62939E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
