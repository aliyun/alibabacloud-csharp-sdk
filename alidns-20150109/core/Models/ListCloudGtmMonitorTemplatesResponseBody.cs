// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ListCloudGtmMonitorTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number, starting from 1, default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of rows per page when paginating queries, with a maximum value of 100 and a default of 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Unique request identification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75446CC1-FC9A-4595-8D96-089D73D7A63D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public ListCloudGtmMonitorTemplatesResponseBodyTemplates Templates { get; set; }
        public class ListCloudGtmMonitorTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplate> Template { get; set; }
            public class ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplate : TeaModel {
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
                public ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodes IspCityNodes { get; set; }
                public class ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodes : TeaModel {
                    [NameInMap("IspCityNode")]
                    [Validation(Required=false)]
                    public List<ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodesIspCityNode> IspCityNode { get; set; }
                    public class ListCloudGtmMonitorTemplatesResponseBodyTemplatesTemplateIspCityNodesIspCityNode : TeaModel {
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

        /// <summary>
        /// <para>Total number of health check template entries retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>Total number of pages after data pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
