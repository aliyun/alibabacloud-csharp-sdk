// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMonitorGroupsResponseBodyResources Resources { get; set; }
        public class DescribeMonitorGroupsResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupsResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMonitorGroupsResponseBodyResourcesResource : TeaModel {
                public string BindUrl { get; set; }
                public DescribeMonitorGroupsResponseBodyResourcesResourceContactGroups ContactGroups { get; set; }
                public class DescribeMonitorGroupsResponseBodyResourcesResourceContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupsResponseBodyResourcesResourceContactGroupsContactGroup> ContactGroup { get; set; }
                    public class DescribeMonitorGroupsResponseBodyResourcesResourceContactGroupsContactGroup : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }
                public string DynamicTagRuleId { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string GroupFounderTagKey { get; set; }
                public string GroupFounderTagValue { get; set; }
                public long? GroupId { get; set; }
                public string GroupName { get; set; }
                public string ServiceId { get; set; }
                public DescribeMonitorGroupsResponseBodyResourcesResourceTags Tags { get; set; }
                public class DescribeMonitorGroupsResponseBodyResourcesResourceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupsResponseBodyResourcesResourceTagsTag> Tag { get; set; }
                    public class DescribeMonitorGroupsResponseBodyResourcesResourceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public DescribeMonitorGroupsResponseBodyResourcesResourceTemplateIds TemplateIds { get; set; }
                public class DescribeMonitorGroupsResponseBodyResourcesResourceTemplateIds : TeaModel {
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public List<string> TemplateId { get; set; }

                }
                public string Type { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
