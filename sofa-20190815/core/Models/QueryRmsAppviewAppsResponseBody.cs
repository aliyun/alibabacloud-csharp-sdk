// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAppviewAppsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsAppviewAppsResponseBodyResponse Response { get; set; }
        public class QueryRmsAppviewAppsResponseBodyResponse : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QueryRmsAppviewAppsResponseBodyResponseResult> Result { get; set; }
            public class QueryRmsAppviewAppsResponseBodyResponseResult : TeaModel {
                public string AppId { get; set; }
                public string AppName { get; set; }
                public string LevelId { get; set; }
                public string LevelName { get; set; }
                public string OwnerId { get; set; }
                public string OwnerName { get; set; }
                public string StackId { get; set; }
                public string StackName { get; set; }
                public List<QueryRmsAppviewAppsResponseBodyResponseResultAppDomains> AppDomains { get; set; }
                public class QueryRmsAppviewAppsResponseBodyResponseResultAppDomains : TeaModel {
                    public string Id { get; set; }
                    public string Name { get; set; }
                }
                public List<QueryRmsAppviewAppsResponseBodyResponseResultDataByResourceType> DataByResourceType { get; set; }
                public class QueryRmsAppviewAppsResponseBodyResponseResultDataByResourceType : TeaModel {
                    public string ResourceAlertCount { get; set; }
                    public string ResourceAllCount { get; set; }
                    public string ResourceNormalCount { get; set; }
                    public string ResourceType { get; set; }
                    public string ResourceUnconfigedCount { get; set; }
                    public List<string> AlertResourceIds { get; set; }
                    public List<string> AllResourceIds { get; set; }
                    public List<string> MonitorPorts { get; set; }
                    public List<string> NormalResourceIds { get; set; }
                    public List<string> UnconfigedResourceIds { get; set; }
                    public QueryRmsAppviewAppsResponseBodyResponseResultDataByResourceTypeData Data { get; set; }
                    public class QueryRmsAppviewAppsResponseBodyResponseResultDataByResourceTypeData : TeaModel {
                        [NameInMap("AppId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        [NameInMap("MonitorEnable")]
                        [Validation(Required=false)]
                        public bool? MonitorEnable { get; set; }

                        [NameInMap("MonitorPort")]
                        [Validation(Required=false)]
                        public string MonitorPort { get; set; }

                        [NameInMap("NormalResourceIds")]
                        [Validation(Required=false)]
                        public string NormalResourceIds { get; set; }

                        [NameInMap("ResourcesAlertCount")]
                        [Validation(Required=false)]
                        public string ResourcesAlertCount { get; set; }

                        [NameInMap("ResourcesCount")]
                        [Validation(Required=false)]
                        public string ResourcesCount { get; set; }

                        [NameInMap("ResourcesNormalCount")]
                        [Validation(Required=false)]
                        public string ResourcesNormalCount { get; set; }

                        [NameInMap("ResourcesUnconfigedCount")]
                        [Validation(Required=false)]
                        public string ResourcesUnconfigedCount { get; set; }

                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                        [NameInMap("AlertResourceIds")]
                        [Validation(Required=false)]
                        public List<string> AlertResourceIds { get; set; }

                        [NameInMap("ItemTypeConfig")]
                        [Validation(Required=false)]
                        public List<string> ItemTypeConfig { get; set; }

                        [NameInMap("ItemTypeNoneConfig")]
                        [Validation(Required=false)]
                        public List<string> ItemTypeNoneConfig { get; set; }

                        [NameInMap("ItemTypePartialConfig")]
                        [Validation(Required=false)]
                        public List<string> ItemTypePartialConfig { get; set; }

                        [NameInMap("ResourceIds")]
                        [Validation(Required=false)]
                        public List<string> ResourceIds { get; set; }

                        [NameInMap("UnconfigedResourceIds")]
                        [Validation(Required=false)]
                        public List<string> UnconfigedResourceIds { get; set; }

                    }
                }
                public List<QueryRmsAppviewAppsResponseBodyResponseResultItemTypeAlerting> ItemTypeAlerting { get; set; }
                public class QueryRmsAppviewAppsResponseBodyResponseResultItemTypeAlerting : TeaModel {
                    public string Key { get; set; }
                    public List<string> Values { get; set; }
                }
                public List<QueryRmsAppviewAppsResponseBodyResponseResultItemTypeConfigured> ItemTypeConfigured { get; set; }
                public class QueryRmsAppviewAppsResponseBodyResponseResultItemTypeConfigured : TeaModel {
                    public string Key { get; set; }
                    public List<string> Values { get; set; }
                }
                public List<QueryRmsAppviewAppsResponseBodyResponseResultResourceIds> ResourceIds { get; set; }
                public class QueryRmsAppviewAppsResponseBodyResponseResultResourceIds : TeaModel {
                    public string Key { get; set; }
                    public List<string> Values { get; set; }
                }
            }
        };

    }

}
