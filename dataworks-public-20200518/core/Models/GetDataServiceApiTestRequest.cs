// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDataServiceApiTestRequest : TeaModel {
        /// <summary>
        /// The ID of the test. You can obtain the test ID from the response of the asynchronous operation TestDataServiceApi. You can also call the ListDataServiceApiTest operation to obtain the ID of the latest test.
        /// </summary>
        [NameInMap("TestId")]
        [Validation(Required=false)]
        public long? TestId { get; set; }

    }

}
