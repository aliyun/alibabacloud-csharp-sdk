// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class AddDataSourceResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddDataSourceResponseBodyData Data { get; set; }
        public class AddDataSourceResponseBodyData : TeaModel {
            /// <summary>
            /// The number of data sources that are added. The value 1 indicates that data source is added, and a value less than or equal to 0 indicates that the data source failed to be added.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The ID of the data source. The ID is an MD5 hash value that is calculated by the threat analysis feature based on specific parameters.
            /// </summary>
            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
