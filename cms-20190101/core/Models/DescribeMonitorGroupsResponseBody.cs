// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources that are associated with the application group.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMonitorGroupsResponseBodyResources Resources { get; set; }
        public class DescribeMonitorGroupsResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupsResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMonitorGroupsResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// The URL of the ACK cluster from which the application group is synchronized.
                /// </summary>
                [NameInMap("BindUrl")]
                [Validation(Required=false)]
                public string BindUrl { get; set; }

                /// <summary>
                /// The alert contact groups.
                /// </summary>
                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public DescribeMonitorGroupsResponseBodyResourcesResourceContactGroups ContactGroups { get; set; }
                public class DescribeMonitorGroupsResponseBodyResourcesResourceContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupsResponseBodyResourcesResourceContactGroupsContactGroup> ContactGroup { get; set; }
                    public class DescribeMonitorGroupsResponseBodyResourcesResourceContactGroupsContactGroup : TeaModel {
                        /// <summary>
                        /// The name of the alert contact group.
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the tag rule.
                /// </summary>
                [NameInMap("DynamicTagRuleId")]
                [Validation(Required=false)]
                public string DynamicTagRuleId { get; set; }

                /// <summary>
                /// The timestamp when the application group was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// The timestamp when the application group was modified. Unit: milliseconds.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

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
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// The name of the application group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The resource ID.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud service.
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// The tags that are attached to the application group.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeMonitorGroupsResponseBodyResourcesResourceTags Tags { get; set; }
                public class DescribeMonitorGroupsResponseBodyResourcesResourceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupsResponseBodyResourcesResourceTagsTag> Tag { get; set; }
                    public class DescribeMonitorGroupsResponseBodyResourcesResourceTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key of the application group.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value of the application group.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the template.
                /// </summary>
                [NameInMap("TemplateIds")]
                [Validation(Required=false)]
                public DescribeMonitorGroupsResponseBodyResourcesResourceTemplateIds TemplateIds { get; set; }
                public class DescribeMonitorGroupsResponseBodyResourcesResourceTemplateIds : TeaModel {
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public List<string> TemplateId { get; set; }

                }

                /// <summary>
                /// The type of the application group. Valid values:
                /// 
                /// *   custom: a self-managed application group
                /// *   ehpc_cluster: an application group that is synchronized from an E-HPC cluster
                /// *   kubernetes: an application group that is synchronized from an ACK cluster
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
