// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIntegrationConfigsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIntegrationConfigsResponseBodyData> Data { get; set; }
        public class ListIntegrationConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// 集成配置id
            /// </summary>
            [NameInMap("integrationConfigId")]
            [Validation(Required=false)]
            public long? IntegrationConfigId { get; set; }

            /// <summary>
            /// 是否已接受报警
            /// </summary>
            [NameInMap("isReceivedEvent")]
            [Validation(Required=false)]
            public bool? IsReceivedEvent { get; set; }

            /// <summary>
            /// 监控源id
            /// </summary>
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            /// <summary>
            /// 监控源名城
            /// </summary>
            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            /// <summary>
            /// 监控源简称
            /// </summary>
            [NameInMap("monitorSourceShortName")]
            [Validation(Required=false)]
            public string MonitorSourceShortName { get; set; }

            /// <summary>
            /// 集成配置状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
