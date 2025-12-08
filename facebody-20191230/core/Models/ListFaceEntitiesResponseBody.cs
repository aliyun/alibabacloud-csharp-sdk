// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ListFaceEntitiesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFaceEntitiesResponseBodyData Data { get; set; }
        public class ListFaceEntitiesResponseBodyData : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<ListFaceEntitiesResponseBodyDataEntities> Entities { get; set; }
            public class ListFaceEntitiesResponseBodyDataEntities : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1589203871832</para>
                /// </summary>
                [NameInMap("CreatedAt")]
                [Validation(Required=false)]
                public long? CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>222</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("FaceCount")]
                [Validation(Required=false)]
                public int? FaceCount { get; set; }

                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1589203871832</para>
                /// </summary>
                [NameInMap("UpdatedAt")]
                [Validation(Required=false)]
                public long? UpdatedAt { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
