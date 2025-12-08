// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GetFaceEntityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFaceEntityResponseBodyData Data { get; set; }
        public class GetFaceEntityResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>66</para>
            /// </summary>
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("Faces")]
            [Validation(Required=false)]
            public List<GetFaceEntityResponseBodyDataFaces> Faces { get; set; }
            public class GetFaceEntityResponseBodyDataFaces : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FaceId")]
                [Validation(Required=false)]
                public string FaceId { get; set; }

            }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA7CAFEB-0A37-4496-9CDF-E3DBB6309CB2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
