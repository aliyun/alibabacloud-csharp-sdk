// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>A value of 200 indicates that the operation was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F02B299A-D374-4595-9F55-7534D604F132</para>
        /// </summary>
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
                [NameInMap("BindUrl")]
                [Validation(Required=false)]
                public string BindUrl { get; set; }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
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

                [NameInMap("DynamicTagRuleId")]
                [Validation(Required=false)]
                public string DynamicTagRuleId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("GroupFounderTagKey")]
                [Validation(Required=false)]
                public string GroupFounderTagKey { get; set; }

                [NameInMap("GroupFounderTagValue")]
                [Validation(Required=false)]
                public string GroupFounderTagValue { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("TemplateIds")]
                [Validation(Required=false)]
                public DescribeMonitorGroupsResponseBodyResourcesResourceTemplateIds TemplateIds { get; set; }
                public class DescribeMonitorGroupsResponseBodyResourcesResourceTemplateIds : TeaModel {
                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public List<string> TemplateId { get; set; }

                }

                [NameInMap("TemplateInfos")]
                [Validation(Required=false)]
                public DescribeMonitorGroupsResponseBodyResourcesResourceTemplateInfos TemplateInfos { get; set; }
                public class DescribeMonitorGroupsResponseBodyResourcesResourceTemplateInfos : TeaModel {
                    [NameInMap("TemplateInfo")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupsResponseBodyResourcesResourceTemplateInfosTemplateInfo> TemplateInfo { get; set; }
                    public class DescribeMonitorGroupsResponseBodyResourcesResourceTemplateInfosTemplateInfo : TeaModel {
                        [NameInMap("EffectTime")]
                        [Validation(Required=false)]
                        public long? EffectTime { get; set; }

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        [NameInMap("Ver")]
                        [Validation(Required=false)]
                        public string Ver { get; set; }

                    }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
