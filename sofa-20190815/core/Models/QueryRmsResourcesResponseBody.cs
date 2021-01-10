// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsResourcesResponseBody : TeaModel {
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
        public QueryRmsResourcesResponseBodyResponse Response { get; set; }
        public class QueryRmsResourcesResponseBodyResponse : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryRmsResourcesResponseBodyResponseData> Data { get; set; }
            public class QueryRmsResourcesResponseBodyResponseData : TeaModel {
                public long? Capacity { get; set; }
                public string ContainerId { get; set; }
                public long? CreatedDateTime { get; set; }
                public string DatabaseType { get; set; }
                public string DataAccessLevel { get; set; }
                public string HostIp { get; set; }
                public string IaasId { get; set; }
                public string IdcName { get; set; }
                public string InstanceType { get; set; }
                public string Ip { get; set; }
                public string PrivateIp { get; set; }
                public string PublicIp { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
                public string Status { get; set; }
                public string WorkspaceId { get; set; }
                public List<string> VipAddress { get; set; }
                public List<QueryRmsResourcesResponseBodyResponseDataListeners> Listeners { get; set; }
                public class QueryRmsResourcesResponseBodyResponseDataListeners : TeaModel {
                    public long? BackendServerPort { get; set; }
                    public string IaasId { get; set; }
                    public string IdcId { get; set; }
                    public string IdcName { get; set; }
                    public string Ip { get; set; }
                    public long? ListenerPort { get; set; }
                    public string MasterId { get; set; }
                    public string PaasId { get; set; }
                    public string Port { get; set; }
                    public string ProviderId { get; set; }
                    public string RegionId { get; set; }
                    public string ResourceId { get; set; }
                    public string ResourceName { get; set; }
                    public string ResourceType { get; set; }
                    public string Sn { get; set; }
                    public string Status { get; set; }
                    public string TenantId { get; set; }
                    public string UtcCreated { get; set; }
                    public string Version { get; set; }
                    public string WorkspaceId { get; set; }
                    public string ZoneId { get; set; }
                    public List<string> AppServiceIds { get; set; }
                    public List<string> AssignedAppIds { get; set; }
                    public List<QueryRmsResourcesResponseBodyResponseDataListenersCells> Cells { get; set; }
                    public class QueryRmsResourcesResponseBodyResponseDataListenersCells : TeaModel {
                        public string CellId { get; set; }
                        public string CellName { get; set; }
                    }
                    public List<QueryRmsResourcesResponseBodyResponseDataListenersOptions> Options { get; set; }
                    public class QueryRmsResourcesResponseBodyResponseDataListenersOptions : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                }
                public List<QueryRmsResourcesResponseBodyResponseDataListenerConfigs> ListenerConfigs { get; set; }
                public class QueryRmsResourcesResponseBodyResponseDataListenerConfigs : TeaModel {
                    [NameInMap("AlertState")]
                    [Validation(Required=false)]
                    public bool? AlertState { get; set; }

                    [NameInMap("ItemTypeAlerting")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeAlerting { get; set; }

                    [NameInMap("ItemTypeConfig")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeConfig { get; set; }

                    [NameInMap("ItemTypeNoneConfig")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeNoneConfig { get; set; }

                }
                public QueryRmsResourcesResponseBodyResponseDataAlertRuleConfigurationStatusVo AlertRuleConfigurationStatusVo { get; set; }
                public class QueryRmsResourcesResponseBodyResponseDataAlertRuleConfigurationStatusVo : TeaModel {
                    [NameInMap("ItemTypeAlerting")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeAlerting { get; set; }

                    [NameInMap("ItemTypeConfigured")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeConfigured { get; set; }

                    [NameInMap("ItemTypeNotConfigured")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeNotConfigured { get; set; }

                }
                public QueryRmsResourcesResponseBodyResponseDataAlertRuleInfoVo AlertRuleInfoVo { get; set; }
                public class QueryRmsResourcesResponseBodyResponseDataAlertRuleInfoVo : TeaModel {
                    [NameInMap("AlertState")]
                    [Validation(Required=false)]
                    public bool? AlertState { get; set; }

                    [NameInMap("ItemTypeAlerting")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeAlerting { get; set; }

                    [NameInMap("ItemTypeConfig")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeConfig { get; set; }

                    [NameInMap("ItemTypeNoneConfig")]
                    [Validation(Required=false)]
                    public List<string> ItemTypeNoneConfig { get; set; }

                }
            }
        };

    }

}
