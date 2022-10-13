// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class ListSummaryAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SummaryAppInfos")]
        [Validation(Required=false)]
        public ListSummaryAppsResponseBodySummaryAppInfos SummaryAppInfos { get; set; }
        public class ListSummaryAppsResponseBodySummaryAppInfos : TeaModel {
            [NameInMap("SummaryAppInfo")]
            [Validation(Required=false)]
            public List<ListSummaryAppsResponseBodySummaryAppInfosSummaryAppInfo> SummaryAppInfo { get; set; }
            public class ListSummaryAppsResponseBodySummaryAppInfosSummaryAppInfo : TeaModel {
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public long? AppKey { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

            }

        }

    }

}
