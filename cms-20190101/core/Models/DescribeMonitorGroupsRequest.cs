// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupsRequest : TeaModel {
        /// <summary>
        /// The ID of the tag rule.
        /// </summary>
        [NameInMap("DynamicTagRuleId")]
        [Validation(Required=false)]
        public string DynamicTagRuleId { get; set; }

        /// <summary>
        /// The tag key that is created for the application group by using the tag rule.
        /// </summary>
        [NameInMap("GroupFounderTagKey")]
        [Validation(Required=false)]
        public string GroupFounderTagKey { get; set; }

        /// <summary>
        /// The tag value that is created for the application group by using the tag rule.
        /// </summary>
        [NameInMap("GroupFounderTagValue")]
        [Validation(Required=false)]
        public string GroupFounderTagValue { get; set; }

        /// <summary>
        /// The ID of the application group. Separate multiple application group IDs with commas (,).
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Specifies whether to include the historical alert templates that are applied to the application group in the response. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("IncludeTemplateHistory")]
        [Validation(Required=false)]
        public bool? IncludeTemplateHistory { get; set; }

        /// <summary>
        /// The instance ID. This parameter is used to query the application group to which the specified instance belongs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The keyword that is used for the search.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Pages start from page 1. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to include the alert contact groups in the response. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("SelectContactGroups")]
        [Validation(Required=false)]
        public bool? SelectContactGroups { get; set; }

        /// <summary>
        /// The tags of the application group.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeMonitorGroupsRequestTag> Tag { get; set; }
        public class DescribeMonitorGroupsRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the application group. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the application group. Valid values of N: 1 to 5.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The type of the application group. Valid values:
        /// 
        /// *   custom: a self-managed application group
        /// *   ehpc_cluster: an application group that is synchronized from an Elastic High Performance Computing (E-HPC) cluster
        /// *   kubernetes: an application group that is synchronized from a Container Service for Kubernetes (ACK) cluster
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The type of the application group. Valid values:
        /// 
        /// *   custom: a self-managed application group
        /// *   ehpc_cluster: an application group that is synchronized from an Elastic High Performance Computing (E-HPC) cluster
        /// *   kubernetes: an application group that is synchronized from a Container Service for Kubernetes (ACK) cluster
        /// *   tag: an application group that is automatically created by using tags
        /// *   resMgr: an application group that is created by using resource groups
        /// *   ess: an application group that is synchronized from Auto Scaling (ESS)
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
