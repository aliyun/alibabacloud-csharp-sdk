// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
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

        /// <summary>
        /// <para>The resources that are associated with the application group.</para>
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
                /// <para>The URL of the ACK cluster from which the application group is synchronized.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com">https://aliyun.com</a></para>
                /// </summary>
                [NameInMap("BindUrl")]
                [Validation(Required=false)]
                public string BindUrl { get; set; }

                /// <summary>
                /// <para>The alert contact groups.</para>
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
                        /// <para>The name of the alert contact group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CloudMonitor</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the tag rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6b882d9a-5117-42e2-9d0c-4749a0c6****</para>
                /// </summary>
                [NameInMap("DynamicTagRuleId")]
                [Validation(Required=false)]
                public string DynamicTagRuleId { get; set; }

                /// <summary>
                /// <para>The timestamp when the application group was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1603181891000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The timestamp when the application group was modified. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1603181891000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The tag key that is created for the application group by using the tag rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GroupKey1</para>
                /// </summary>
                [NameInMap("GroupFounderTagKey")]
                [Validation(Required=false)]
                public string GroupFounderTagKey { get; set; }

                /// <summary>
                /// <para>The tag value that is created for the application group by using the tag rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GroupValue1</para>
                /// </summary>
                [NameInMap("GroupFounderTagValue")]
                [Validation(Required=false)]
                public string GroupFounderTagValue { get; set; }

                /// <summary>
                /// <para>The ID of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                /// <summary>
                /// <para>The name of the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The resource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aek2hopjh*******</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49****</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The tags that are attached to the application group.</para>
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
                        /// <para>The tag key of the application group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tagKey1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value of the application group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tagValue1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the template.</para>
                /// </summary>
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

                /// <summary>
                /// <para>The type of the application group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>custom: a self-managed application group</description></item>
                /// <item><description>ehpc_cluster: an application group that is synchronized from an E-HPC cluster</description></item>
                /// <item><description>kubernetes: an application group that is synchronized from an ACK cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
