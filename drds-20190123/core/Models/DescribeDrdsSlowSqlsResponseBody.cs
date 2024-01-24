// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsSlowSqlsResponseBody : TeaModel {
        /// <summary>
        /// Indicates the details of the slow SQL query.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDrdsSlowSqlsResponseBodyItems Items { get; set; }
        public class DescribeDrdsSlowSqlsResponseBodyItems : TeaModel {
            [NameInMap("Item")]
            [Validation(Required=false)]
            public List<DescribeDrdsSlowSqlsResponseBodyItemsItem> Item { get; set; }
            public class DescribeDrdsSlowSqlsResponseBodyItemsItem : TeaModel {
                /// <summary>
                /// Indicates the IP address of the execution machine.
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// Indicates the response time. Unit: ms.
                /// </summary>
                [NameInMap("ResponseTime")]
                [Validation(Required=false)]
                public long? ResponseTime { get; set; }

                /// <summary>
                /// Indicates the name of the database.
                /// </summary>
                [NameInMap("Schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

                /// <summary>
                /// Indicates the time when the slow SQL query was sent. Unit: ms.
                /// </summary>
                [NameInMap("SendTime")]
                [Validation(Required=false)]
                public long? SendTime { get; set; }

                /// <summary>
                /// Indicates the content of the slow SQL query.
                /// </summary>
                [NameInMap("Sql")]
                [Validation(Required=false)]
                public string Sql { get; set; }

            }

        }

        /// <summary>
        /// Indicates the page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Indicates the number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// Indicates the total number of entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
