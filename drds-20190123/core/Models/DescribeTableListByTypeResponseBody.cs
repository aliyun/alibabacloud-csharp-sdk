// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeTableListByTypeResponseBody : TeaModel {
        /// <summary>
        /// Indicates the information about tables.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeTableListByTypeResponseBodyList> List { get; set; }
        public class DescribeTableListByTypeResponseBodyList : TeaModel {
            /// <summary>
            /// Indicates the property of a table.
            /// </summary>
            [NameInMap("Property")]
            [Validation(Required=false)]
            public string Property { get; set; }

            /// <summary>
            /// Indicates the name of the table.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// Indicates the page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Indicates the number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Indicates the unique ID of the request. If the request fails, provide this ID for technical support to troubleshoot the failure.
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
        /// Indicates the total number of returned tables.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
