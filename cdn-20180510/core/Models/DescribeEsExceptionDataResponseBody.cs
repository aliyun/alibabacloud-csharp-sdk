// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeEsExceptionDataResponseBody : TeaModel {
        /// <summary>
        /// The content of the script for which an error was reported.
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<DescribeEsExceptionDataResponseBodyContents> Contents { get; set; }
        public class DescribeEsExceptionDataResponseBodyContents : TeaModel {
            /// <summary>
            /// Information about the time column and the error column name.
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// The name of the table that shows the errors of the script.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The time columns and error column names.
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public List<string> Points { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
