// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DistApplicationDataResponseBody : TeaModel {
        /// <summary>
        /// The list of ENS instance IDs.
        /// </summary>
        [NameInMap("DistInstanceIds")]
        [Validation(Required=false)]
        public DistApplicationDataResponseBodyDistInstanceIds DistInstanceIds { get; set; }
        public class DistApplicationDataResponseBodyDistInstanceIds : TeaModel {
            [NameInMap("DistInstanceId")]
            [Validation(Required=false)]
            public List<string> DistInstanceId { get; set; }

        }

        /// <summary>
        /// The total number of ENS instance IDs.
        /// </summary>
        [NameInMap("DistInstanceTotalCount")]
        [Validation(Required=false)]
        public int? DistInstanceTotalCount { get; set; }

        /// <summary>
        /// The distribution result of the data file.
        /// </summary>
        [NameInMap("DistResults")]
        [Validation(Required=false)]
        public DistApplicationDataResponseBodyDistResults DistResults { get; set; }
        public class DistApplicationDataResponseBodyDistResults : TeaModel {
            [NameInMap("DistResult")]
            [Validation(Required=false)]
            public List<DistApplicationDataResponseBodyDistResultsDistResult> DistResult { get; set; }
            public class DistApplicationDataResponseBodyDistResultsDistResult : TeaModel {
                /// <summary>
                /// The name of the data file.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The error code. The value is of the enumerated data type.
                /// </summary>
                [NameInMap("ResultCode")]
                [Validation(Required=false)]
                public int? ResultCode { get; set; }

                /// <summary>
                /// The description of the distribution result.
                /// </summary>
                [NameInMap("ResultDescrip")]
                [Validation(Required=false)]
                public string ResultDescrip { get; set; }

                /// <summary>
                /// The version number of the data file.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
