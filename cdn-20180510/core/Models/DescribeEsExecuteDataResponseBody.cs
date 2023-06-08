// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeEsExecuteDataResponseBody : TeaModel {
        /// <summary>
        /// The content of the script.
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<DescribeEsExecuteDataResponseBodyContents> Contents { get; set; }
        public class DescribeEsExecuteDataResponseBodyContents : TeaModel {
            /// <summary>
            /// The time and column names in the table that shows the status of the script.
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            /// <summary>
            /// The name of the table that shows the status of the script.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The list of timestamps and values in the corresponding columns of the table that shows the status of the script.
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
