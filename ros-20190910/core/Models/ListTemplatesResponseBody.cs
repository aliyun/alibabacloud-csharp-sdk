// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the template list.<br>Start value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3A8413B-1F16-4DED-AC3E-61A00718DE8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>Supplementary information for public templates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;DeploymentDuration&quot;:null,&quot;Title&quot;:&quot;Self-Built_ElasticSearch_Snapshot_Saved_To_OSS&quot;,&quot;Labels&quot;:{&quot;ResourceTypes&quot;:[&quot;ALIYUN::ECS::Instance&quot;,&quot;ALIYUN::ECS::SecurityGroup&quot;,&quot;ALIYUN::ECS::VPC&quot;,&quot;ALIYUN::ECS::VSwitch&quot;,&quot;ALIYUN::OSS::Bucket&quot;,&quot;ALIYUN::ROS::WaitCondition&quot;,&quot;ALIYUN::ROS::WaitConditionHandle&quot;],&quot;DeployTypes&quot;:[&quot;ROS&quot;],&quot;ApplicationScenes&quot;:[&quot;其他&quot;]},&quot;Provider&quot;:&quot;ROS&quot;,&quot;Categories&quot;:[&quot;Solution&quot;]}</para>
            /// </summary>
            [NameInMap("AdditionalInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> AdditionalInfo { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-15T08:17:14.000000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>ID of the Alibaba Cloud account to which the template belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151266687691****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            /// <summary>
            /// <para>Resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxazb4ph6aiy****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The sharing type of the template.</para>
            /// <para>Values:</para>
            /// <list type="bullet">
            /// <item><description>Private: The template is owned by the user themselves.</description></item>
            /// <item><description>Shared: The template is shared by other users.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Private</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>Tags of the template.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTemplatesResponseBodyTemplatesTags> Tags { get; set; }
            public class ListTemplatesResponseBodyTemplatesTags : TeaModel {
                /// <summary>
                /// <para>Tag key of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>usage</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Tag value of the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ros:<em>:151266687691</em><em><b>:template/a52f81be-496f-4e1c-a286-8852ab54</b></em>*</para>
            /// </summary>
            [NameInMap("TemplateARN")]
            [Validation(Required=false)]
            public string TemplateARN { get; set; }

            /// <summary>
            /// <para>Template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4d4f5aa2-3260-4e47-863b-763fbb12****</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>Template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>Link to the template</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://ros-public-templates.oss-cn-hangzhou.aliyuncs.com/demo.yml">https://ros-public-templates.oss-cn-hangzhou.aliyuncs.com/demo.yml</a></para>
            /// </summary>
            [NameInMap("TemplateUrl")]
            [Validation(Required=false)]
            public string TemplateUrl { get; set; }

            /// <summary>
            /// <para>Latest template version name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The last update time of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-10-15T08:17:14.000000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
