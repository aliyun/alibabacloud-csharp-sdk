// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class GetMCTableSchemaResponseBody : TeaModel {
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<GetMCTableSchemaResponseBodyColumns> Columns { get; set; }
        public class GetMCTableSchemaResponseBodyColumns : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>column1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Preview")]
            [Validation(Required=false)]
            public List<string> Preview { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("PartitionColumns")]
        [Validation(Required=false)]
        public List<string> PartitionColumns { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
