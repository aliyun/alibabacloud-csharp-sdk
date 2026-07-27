// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetInstanceErrorRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The error ranking data of nodes.</para>
        /// </summary>
        [NameInMap("InstanceErrorRank")]
        [Validation(Required=false)]
        public GetInstanceErrorRankResponseBodyInstanceErrorRank InstanceErrorRank { get; set; }
        public class GetInstanceErrorRankResponseBodyInstanceErrorRank : TeaModel {
            /// <summary>
            /// <para>The error ranking data of nodes in the last month.</para>
            /// </summary>
            [NameInMap("ErrorRank")]
            [Validation(Required=false)]
            public List<GetInstanceErrorRankResponseBodyInstanceErrorRankErrorRank> ErrorRank { get; set; }
            public class GetInstanceErrorRankResponseBodyInstanceErrorRankErrorRank : TeaModel {
                /// <summary>
                /// <para>The number of errors of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node name</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud UID of the node owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>952795279527</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The type of the node task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PrgType")]
                [Validation(Required=false)]
                public int? PrgType { get; set; }

                /// <summary>
                /// <para>The ID of the DataWorks workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the error ranking was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600963200000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The unique ID generated for each request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>952795279527****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
