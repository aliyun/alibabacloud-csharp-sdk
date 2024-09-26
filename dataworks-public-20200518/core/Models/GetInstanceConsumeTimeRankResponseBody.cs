// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceConsumeTimeRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The ranking record of the running durations of instances.</para>
        /// </summary>
        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=false)]
        public GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRank : TeaModel {
            /// <summary>
            /// <para>The ranking data of the running durations of instances.</para>
            /// </summary>
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=false)]
            public List<GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class GetInstanceConsumeTimeRankResponseBodyInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                /// <summary>
                /// <para>The data timestamp of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600963200000</para>
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// <para>The running duration of the instance. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Consumed")]
                [Validation(Required=false)]
                public long? Consumed { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>95279527</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the node owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>952795279527</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PrgType")]
                [Validation(Required=false)]
                public int? PrgType { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the ranking was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600963200000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6347364dadsfadf****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
