// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceErrorRankResponseBody : TeaModel {
        /// <summary>
        /// The ranking data of nodes on which errors occurred.
        /// </summary>
        [NameInMap("InstanceErrorRank")]
        [Validation(Required=false)]
        public GetInstanceErrorRankResponseBodyInstanceErrorRank InstanceErrorRank { get; set; }
        public class GetInstanceErrorRankResponseBodyInstanceErrorRank : TeaModel {
            /// <summary>
            /// The ranking data of nodes on which errors occurred within the last month.
            /// </summary>
            [NameInMap("ErrorRank")]
            [Validation(Required=false)]
            public List<GetInstanceErrorRankResponseBodyInstanceErrorRankErrorRank> ErrorRank { get; set; }
            public class GetInstanceErrorRankResponseBodyInstanceErrorRankErrorRank : TeaModel {
                /// <summary>
                /// The number of errors that occurred on the node.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

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

                /// <summary>
                /// The DataWorks workspace ID.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// The timestamp at which the rankings were updated.
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
