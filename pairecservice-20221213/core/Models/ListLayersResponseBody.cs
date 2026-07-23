// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListLayersResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of layers.</para>
        /// </summary>
        [NameInMap("Layers")]
        [Validation(Required=false)]
        public List<ListLayersResponseBodyLayers> Layers { get; set; }
        public class ListLayersResponseBodyLayers : TeaModel {
            /// <summary>
            /// <para>The layer description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a test.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the layer was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-30T02:02:28.000Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The laboratory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LaboratoryId")]
            [Validation(Required=false)]
            public string LaboratoryId { get; set; }

            /// <summary>
            /// <para>The layer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("LayerId")]
            [Validation(Required=false)]
            public string LayerId { get; set; }

            /// <summary>
            /// <para>The layer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>layer1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The remaining traffic for the layer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ResidualFlow")]
            [Validation(Required=false)]
            public long? ResidualFlow { get; set; }

            /// <summary>
            /// <para>The scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>518C64F6-DFF7-11ED-85B0-00163E14B3D1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count of layers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
