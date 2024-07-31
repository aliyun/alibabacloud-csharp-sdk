// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceConsumeTimeRankResponseBody : TeaModel {
        /// <summary>
        /// The ranking record of the running durations of instances.
        /// </summary>
        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=false)]
        public GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRank : TeaModel {
            /// <summary>
            /// The ranking data of the running durations of instances.
            /// </summary>
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=false)]
            public List<GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                /// <summary>
                /// The data timestamp of the instance.
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// The running duration of the instance. Unit: seconds.
                /// </summary>
                [NameInMap("Consumed")]
                [Validation(Required=false)]
                public long? Consumed { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the node owner.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The type of the node.
                /// </summary>
                [NameInMap("PrgType")]
                [Validation(Required=false)]
                public int? PrgType { get; set; }

            }

            /// <summary>
            /// The timestamp when the ranking was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
