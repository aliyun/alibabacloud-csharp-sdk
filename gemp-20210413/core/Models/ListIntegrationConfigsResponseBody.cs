// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIntegrationConfigsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIntegrationConfigsResponseBodyData> Data { get; set; }
        public class ListIntegrationConfigsResponseBodyData : TeaModel {
            [NameInMap("integrationConfigId")]
            [Validation(Required=false)]
            public long? IntegrationConfigId { get; set; }

            [NameInMap("isReceivedEvent")]
            [Validation(Required=false)]
            public bool? IsReceivedEvent { get; set; }

            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            [NameInMap("monitorSourceShortName")]
            [Validation(Required=false)]
            public string MonitorSourceShortName { get; set; }

            [NameInMap("monitorSourceType")]
            [Validation(Required=false)]
            public int? MonitorSourceType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
