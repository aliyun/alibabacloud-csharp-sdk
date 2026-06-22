// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FigureClusterForReq : TeaModel {
        /// <summary>
        /// <para>The cover of the cluster.</para>
        /// </summary>
        [NameInMap("Cover")]
        [Validation(Required=false)]
        public FigureClusterForReqCover Cover { get; set; }
        public class FigureClusterForReqCover : TeaModel {
            /// <summary>
            /// <para>The figure list.</para>
            /// </summary>
            [NameInMap("Figures")]
            [Validation(Required=false)]
            public List<FigureClusterForReqCoverFigures> Figures { get; set; }
            public class FigureClusterForReqCoverFigures : TeaModel {
                /// <summary>
                /// <para>The figure ID.</para>
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
        /// <para>A key-value map of custom labels that can be used to search for the figure cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;: &quot;examplebucket&quot;}</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The metadata lock version. This parameter enables optimistic locking to prevent conflicting updates during high concurrency. To ensure data consistency, pass the current MetaLockVersion value when updating a figure cluster. You can retrieve this value from a Get or List operation. The service proceeds with the update only if the provided version matches the system\&quot;s current version. The initial value is 0 and is incremented by 1 after each successful update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MetaLockVersion")]
        [Validation(Required=false)]
        public long? MetaLockVersion { get; set; }

        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The object ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-99b1c333-86dc-45da-8c6****</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

    }

}
