// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ImportDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// The information about the imported data sources.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ImportDataSourcesResponseBodyData Data { get; set; }
        public class ImportDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the data sources failed to be imported. If the data sources were imported, this parameter is left empty.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the data sources were imported. Valid values:
            /// 
            /// *   true: All data sources were imported.
            /// *   false: Specific data sources failed to be imported. You can troubleshoot issues based on the Message parameter.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        /// <summary>
        /// The request ID. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
