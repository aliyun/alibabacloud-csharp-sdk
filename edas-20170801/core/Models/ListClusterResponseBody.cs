// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterResponseBody : TeaModel {
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public ListClusterResponseBodyClusterList ClusterList { get; set; }
        public class ListClusterResponseBodyClusterList : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<ListClusterResponseBodyClusterListCluster> Cluster { get; set; }
            public class ListClusterResponseBodyClusterListCluster : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public int? ClusterType { get; set; }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("CpuUsed")]
                [Validation(Required=false)]
                public int? CpuUsed { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CsClusterId")]
                [Validation(Required=false)]
                public string CsClusterId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IaasProvider")]
                [Validation(Required=false)]
                public string IaasProvider { get; set; }

                [NameInMap("Mem")]
                [Validation(Required=false)]
                public int? Mem { get; set; }

                [NameInMap("MemUsed")]
                [Validation(Required=false)]
                public int? MemUsed { get; set; }

                [NameInMap("NetworkMode")]
                [Validation(Required=false)]
                public int? NetworkMode { get; set; }

                [NameInMap("NodeNum")]
                [Validation(Required=false)]
                public int? NodeNum { get; set; }

                [NameInMap("OversoldFactor")]
                [Validation(Required=false)]
                public int? OversoldFactor { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The additional information that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1053-08e4-47a5-b2ab-5c0323de****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
