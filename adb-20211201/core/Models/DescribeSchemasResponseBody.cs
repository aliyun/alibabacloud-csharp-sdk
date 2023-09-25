// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSchemasResponseBody : TeaModel {
        /// <summary>
        /// The queried databases.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSchemasResponseBodyItems Items { get; set; }
        public class DescribeSchemasResponseBodyItems : TeaModel {
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public List<DescribeSchemasResponseBodyItemsSchema> Schema { get; set; }
            public class DescribeSchemasResponseBodyItemsSchema : TeaModel {
                /// <summary>
                /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
