// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListRCVClustersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>07F6177E-6DE4-408A-BB4F-0723301340F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VClusters")]
        [Validation(Required=false)]
        public List<ListRCVClustersResponseBodyVClusters> VClusters { get; set; }
        public class ListRCVClustersResponseBodyVClusters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cd21387ea640145bab79a78276c1a****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("SupportDiskPerformanceLevel")]
            [Validation(Required=false)]
            public List<string> SupportDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-2zeqj40j2ce0s5yhg****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
