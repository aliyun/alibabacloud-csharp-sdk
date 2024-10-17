// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class SqlOutput : TeaModel {
        [NameInMap("rows")]
        [Validation(Required=false)]
        public List<SqlOutputRows> Rows { get; set; }
        public class SqlOutputRows : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("schema")]
        [Validation(Required=false)]
        public SqlOutputSchema Schema { get; set; }
        public class SqlOutputSchema : TeaModel {
            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<SqlOutputSchemaFields> Fields { get; set; }
            public class SqlOutputSchemaFields : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nullable")]
                [Validation(Required=false)]
                public bool? Nullable { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
