// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceApiTestResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApiTestResponseBodyData Data { get; set; }
        public class GetDataServiceApiTestResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the API on which the test is performed.
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// The time consumed for the test.
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public string CostTime { get; set; }

            /// <summary>
            /// The debugging information.
            /// </summary>
            [NameInMap("DebugInfo")]
            [Validation(Required=false)]
            public string DebugInfo { get; set; }

            [NameInMap("NodesDebugInfo")]
            [Validation(Required=false)]
            public string NodesDebugInfo { get; set; }

            /// <summary>
            /// The request parameters configured for the test.
            /// </summary>
            [NameInMap("ParamMap")]
            [Validation(Required=false)]
            public string ParamMap { get; set; }

            /// <summary>
            /// The status code returned for the test. If the test is not complete, this parameter is not returned.
            /// </summary>
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public long? RetCode { get; set; }

            /// <summary>
            /// The result returned for the test.
            /// </summary>
            [NameInMap("RetResult")]
            [Validation(Required=false)]
            public string RetResult { get; set; }

            /// <summary>
            /// The status of the test. Valid values: RUNNING and FINISHED.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
