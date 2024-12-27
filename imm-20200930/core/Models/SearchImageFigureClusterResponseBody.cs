// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SearchImageFigureClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The face clusters.</para>
        /// </summary>
        [NameInMap("Clusters")]
        [Validation(Required=false)]
        public List<SearchImageFigureClusterResponseBodyClusters> Clusters { get; set; }
        public class SearchImageFigureClusterResponseBodyClusters : TeaModel {
            /// <summary>
            /// <para>The bounding box of the face.</para>
            /// </summary>
            [NameInMap("Boundary")]
            [Validation(Required=false)]
            public Boundary Boundary { get; set; }

            /// <summary>
            /// <para>The ID of the face cluster that contains faces similar to the face within the bounding box.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Cluster-ca730577-06b1-42c7-a25b-8f2c7******</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The similarity between the face within the bounding box and the face cluster. Valid value: 0 to 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.87413794</para>
            /// </summary>
            [NameInMap("Similarity")]
            [Validation(Required=false)]
            public float? Similarity { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C2734912-E6D5-052C-AC67-6A9FD02*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
