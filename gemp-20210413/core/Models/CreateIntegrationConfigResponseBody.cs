// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateIntegrationConfigResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateIntegrationConfigResponseBodyData Data { get; set; }
        public class CreateIntegrationConfigResponseBodyData : TeaModel {
            [NameInMap("integrationConfigId")]
            [Validation(Required=false)]
            public long? IntegrationConfigId { get; set; }

        }

        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
