// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListServiceGroupMonitorSourceTemplatesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListServiceGroupMonitorSourceTemplatesResponseBodyData> Data { get; set; }
        public class ListServiceGroupMonitorSourceTemplatesResponseBodyData : TeaModel {
            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<string> Fields { get; set; }

            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            [NameInMap("templateContent")]
            [Validation(Required=false)]
            public string TemplateContent { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
