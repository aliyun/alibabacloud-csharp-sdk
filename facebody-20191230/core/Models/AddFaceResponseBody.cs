// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class AddFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddFaceResponseBodyData Data { get; set; }
        public class AddFaceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("FaceId")]
            [Validation(Required=false)]
            public string FaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99.79581</para>
            /// </summary>
            [NameInMap("QualitieScore")]
            [Validation(Required=false)]
            public float? QualitieScore { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2B93C43A-F824-40C8-AF79-844342B0F43A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
