// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairSkvDdbTableResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2363CEDF-C697-14B6-AB9E-C57A4AA0EAD4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tables")]
        [Validation(Required=false)]
        public DescribeTairSkvDdbTableResponseBodyTables Tables { get; set; }
        public class DescribeTairSkvDdbTableResponseBodyTables : TeaModel {
            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<DescribeTairSkvDdbTableResponseBodyTablesTable> Table { get; set; }
            public class DescribeTairSkvDdbTableResponseBodyTablesTable : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

        }

    }

}
