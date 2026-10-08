// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSourceTableMetaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSourceTableMetaResponseBodyData Data { get; set; }
        public class GetSourceTableMetaResponseBodyData : TeaModel {
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetSourceTableMetaResponseBodyDataColumns> Columns { get; set; }
            public class GetSourceTableMetaResponseBodyDataColumns : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>unique id</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Pk")]
                [Validation(Required=false)]
                public bool? Pk { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Pt")]
                [Validation(Required=false)]
                public bool? Pt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("RawDataType")]
                [Validation(Required=false)]
                public string RawDataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SeqNumber")]
                [Validation(Required=false)]
                public int? SeqNumber { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>300001410.default.sample</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sample</para>
            /// </summary>
            [NameInMap("TableComment")]
            [Validation(Required=false)]
            public string TableComment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sample</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
