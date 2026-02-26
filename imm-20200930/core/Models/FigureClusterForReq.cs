// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FigureClusterForReq : TeaModel {
        /// <summary>
        /// <para>The cover image.</para>
        /// </summary>
        [NameInMap("Cover")]
        [Validation(Required=false)]
        public FigureClusterForReqCover Cover { get; set; }
        public class FigureClusterForReqCover : TeaModel {
            /// <summary>
            /// <para>The persons.</para>
            /// </summary>
            [NameInMap("Figures")]
            [Validation(Required=false)]
            public List<FigureClusterForReqCoverFigures> Figures { get; set; }
            public class FigureClusterForReqCoverFigures : TeaModel {
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
        /// <para>The custom labels. You can search for the cluster by label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;: &quot;examplebucket&quot;}</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The version of the metadata lock. A metadata lock version can be obtained by using a get or list operation. If you include the MetaLockVersion parameter in a request to update the cluster, the server checks consistency between the MetaLockVersion parameter value sent in the request and the one on the server side and updates the cluster only when they are consistent. This parameter is used to prevent update conflicts in concurrent scenarios. The initial version is 0. The version is automatically increased by 1 after each successful update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MetaLockVersion")]
        [Validation(Required=false)]
        public long? MetaLockVersion { get; set; }

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
        /// <para>The ID of the face cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cluster-99b1c333-86dc-45da-8c6****</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

    }

}
