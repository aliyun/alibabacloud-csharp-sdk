// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SearchCloudGtmMonitorTemplatesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public SearchCloudGtmMonitorTemplatesResponseBodyTemplates Templates { get; set; }
        public class SearchCloudGtmMonitorTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplate> Template { get; set; }
            public class SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplate : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public int? EvaluationCount { get; set; }

                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public string ExtendInfo { get; set; }

                [NameInMap("FailureRate")]
                [Validation(Required=false)]
                public int? FailureRate { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                [NameInMap("IspCityNodes")]
                [Validation(Required=false)]
                public SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodes IspCityNodes { get; set; }
                public class SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodes : TeaModel {
                    [NameInMap("IspCityNode")]
                    [Validation(Required=false)]
                    public List<SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodesIspCityNode> IspCityNode { get; set; }
                    public class SearchCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodesIspCityNode : TeaModel {
                        [NameInMap("CityCode")]
                        [Validation(Required=false)]
                        public string CityCode { get; set; }

                        [NameInMap("CityName")]
                        [Validation(Required=false)]
                        public string CityName { get; set; }

                        [NameInMap("CountryCode")]
                        [Validation(Required=false)]
                        public string CountryCode { get; set; }

                        [NameInMap("CountryName")]
                        [Validation(Required=false)]
                        public string CountryName { get; set; }

                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        [NameInMap("GroupType")]
                        [Validation(Required=false)]
                        public string GroupType { get; set; }

                        [NameInMap("IspCode")]
                        [Validation(Required=false)]
                        public string IspCode { get; set; }

                        [NameInMap("IspName")]
                        [Validation(Required=false)]
                        public string IspName { get; set; }

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public int? Timeout { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
