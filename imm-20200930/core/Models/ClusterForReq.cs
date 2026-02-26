// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ClusterForReq : TeaModel {
        /// <summary>
        /// <para>The cover.</para>
        /// </summary>
        [NameInMap("Cover")]
        [Validation(Required=false)]
        public ClusterForReqCover Cover { get; set; }
        public class ClusterForReqCover : TeaModel {
            /// <summary>
            /// <para>The persons.</para>
            /// </summary>
            [NameInMap("Figures")]
            [Validation(Required=false)]
            public List<ClusterForReqCoverFigures> Figures { get; set; }
            public class ClusterForReqCoverFigures : TeaModel {
                /// <summary>
                /// <para>The person ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2cb3c51e-b406-4b0c-af1b-897d88e1****</para>
                /// </summary>
                [NameInMap("FigureId")]
                [Validation(Required=false)]
                public string FigureId { get; set; }

            }

        }

        /// <summary>
        /// <para>The custom ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// <para>The custom labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;: &quot;examplebucket&quot;}</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-99b1c333-86dc-45da-8c6****</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

    }

}
