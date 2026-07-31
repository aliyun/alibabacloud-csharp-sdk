// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSchemasResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSchemasResponseBodyItems Items { get; set; }
        public class DescribeSchemasResponseBodyItems : TeaModel {
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public List<DescribeSchemasResponseBodyItemsSchema> Schema { get; set; }
            public class DescribeSchemasResponseBodyItemsSchema : TeaModel {
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25B56BC7-4978-40B3-9E48-4B7067******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
