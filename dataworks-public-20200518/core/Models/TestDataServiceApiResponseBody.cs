// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TestDataServiceApiResponseBody : TeaModel {
        /// <summary>
        /// The information about the test.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TestDataServiceApiResponseBodyData Data { get; set; }
        public class TestDataServiceApiResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the test.
            /// </summary>
            [NameInMap("TestId")]
            [Validation(Required=false)]
            public string TestId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
