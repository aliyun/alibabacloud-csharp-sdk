// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListFlowProjectClusterSettingResponseBody : TeaModel {
        [NameInMap("ClusterSettings")]
        [Validation(Required=false)]
        public ListFlowProjectClusterSettingResponseBodyClusterSettings ClusterSettings { get; set; }
        public class ListFlowProjectClusterSettingResponseBodyClusterSettings : TeaModel {
            [NameInMap("ClusterSetting")]
            [Validation(Required=false)]
            public List<ListFlowProjectClusterSettingResponseBodyClusterSettingsClusterSetting> ClusterSetting { get; set; }
            public class ListFlowProjectClusterSettingResponseBodyClusterSettingsClusterSetting : TeaModel {
                public string ClusterId { get; set; }
                public string ClusterName { get; set; }
                public string DefaultQueue { get; set; }
                public string DefaultUser { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public ListFlowProjectClusterSettingResponseBodyClusterSettingsClusterSettingHostList HostList { get; set; }
                public class ListFlowProjectClusterSettingResponseBodyClusterSettingsClusterSettingHostList : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public List<string> Host { get; set; }

                }
                public string K8sClusterId { get; set; }
                public string ProjectId { get; set; }
                public ListFlowProjectClusterSettingResponseBodyClusterSettingsClusterSettingQueueList QueueList { get; set; }
                public class ListFlowProjectClusterSettingResponseBodyClusterSettingsClusterSettingQueueList : TeaModel {
                    [NameInMap("Queue")]
                    [Validation(Required=false)]
                    public List<string> Queue { get; set; }

                }
                public ListFlowProjectClusterSettingResponseBodyClusterSettingsClusterSettingUserList UserList { get; set; }
                public class ListFlowProjectClusterSettingResponseBodyClusterSettingsClusterSettingUserList : TeaModel {
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public List<string> User { get; set; }

                }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
