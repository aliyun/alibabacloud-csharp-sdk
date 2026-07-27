// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ImportKgSchemaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("ImportResult")]
        [Validation(Required=false)]
        public ImportKgSchemaResponseBodyImportResult ImportResult { get; set; }
        public class ImportKgSchemaResponseBodyImportResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1032591</para>
            /// </summary>
            [NameInMap("EntityTypeCount")]
            [Validation(Required=false)]
            public int? EntityTypeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3380766</para>
            /// </summary>
            [NameInMap("RelationTypeCount")]
            [Validation(Required=false)]
            public int? RelationTypeCount { get; set; }

        }

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
