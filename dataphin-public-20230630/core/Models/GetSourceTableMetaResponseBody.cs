// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetSourceTableMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The metadata of the integration source table, including the table description and field list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSourceTableMetaResponseBodyData Data { get; set; }
        public class GetSourceTableMetaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The column list.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetSourceTableMetaResponseBodyDataColumns> Columns { get; set; }
            public class GetSourceTableMetaResponseBodyDataColumns : TeaModel {
                /// <summary>
                /// <para>The column comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unique id</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The column data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The column name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>id</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the column is a primary key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Pk")]
                [Validation(Required=false)]
                public bool? Pk { get; set; }

                /// <summary>
                /// <para>Indicates whether the column is a partition column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Pt")]
                [Validation(Required=false)]
                public bool? Pt { get; set; }

                /// <summary>
                /// <para>The raw column data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("RawDataType")]
                [Validation(Required=false)]
                public string RawDataType { get; set; }

                /// <summary>
                /// <para>The column sequence number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SeqNumber")]
                [Validation(Required=false)]
                public int? SeqNumber { get; set; }

            }

            /// <summary>
            /// <para>The globally unique identifier (GUID) of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300001410.default.sample</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            /// <summary>
            /// <para>The table description or comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sample</para>
            /// </summary>
            [NameInMap("TableComment")]
            [Validation(Required=false)]
            public string TableComment { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sample</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
