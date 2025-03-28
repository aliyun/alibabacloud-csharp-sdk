// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>Supplementary information for the public template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DeploymentDuration&quot;:null,&quot;Title&quot;:&quot;Self-Built_ElasticSearch_Snapshot_Saved_To_OSS&quot;,&quot;Labels&quot;:{&quot;ResourceTypes&quot;:[&quot;ALIYUN::ECS::Instance&quot;,&quot;ALIYUN::ECS::SecurityGroup&quot;,&quot;ALIYUN::ECS::VPC&quot;,&quot;ALIYUN::ECS::VSwitch&quot;,&quot;ALIYUN::OSS::Bucket&quot;,&quot;ALIYUN::ROS::WaitCondition&quot;,&quot;ALIYUN::ROS::WaitConditionHandle&quot;],&quot;DeployTypes&quot;:[&quot;ROS&quot;],&quot;ApplicationScenes&quot;:[&quot;其他&quot;]},&quot;Provider&quot;:&quot;ROS&quot;,&quot;Categories&quot;:[&quot;Solution&quot;]}</para>
        /// </summary>
        [NameInMap("AdditionalInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> AdditionalInfo { get; set; }

        /// <summary>
        /// <para>The ID of the change set. This parameter is returned only if you specify ChangeSetId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e85abe0c-6528-43fb-ae93-fdf8de22****</para>
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// <para>The time when the template was created. This parameter is returned only if you specify TemplateId.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify TemplateVersion, the creation time of the template whose version is specified by TemplateVersion is returned.</description></item>
        /// <item><description>If you do not specify TemplateVersion, the creation time of the template whose version is the default version is returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-18T08:49:26</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the template. This parameter is returned only if you specify TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROS template for create ECS instance.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The description of the web UI in the ROS console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Interface")]
        [Validation(Required=false)]
        public string Interface { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the template belongs. This parameter is returned only if you specify TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151266687691****</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>Details of the sharing status of the template. This parameter is returned only if you specify TemplateId and set IncludePermission to Enabled.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If TemplateVersion is not specified or does not take effect, the details of the sharing status of the template whose version is the default version is returned.</description></item>
        /// <item><description>If TemplateVersion is specified and takes effect, the details of the sharing status of the template whose version is specified by TemplateVersion is returned.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public List<GetTemplateResponseBodyPermissions> Permissions { get; set; }
        public class GetTemplateResponseBodyPermissions : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account with which the template is shared.</para>
            /// 
            /// <b>Example:</b>
            /// <para>142437958638****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The sharing option.</para>
            /// <para>The value ShareToAccounts indicates that the template is shared with one or more Alibaba Cloud accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ShareToAccounts</para>
            /// </summary>
            [NameInMap("ShareOption")]
            [Validation(Required=false)]
            public string ShareOption { get; set; }

            /// <summary>
            /// <para>The service that is used for resource sharing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ROS: Resources are shared from ROS by using the ROS console or calling the ROS API.</description></item>
            /// <item><description>ResourceDirectory: Resources are shared with accounts in a resource directory from Resource Management by using the resource sharing feature.<remarks>
            /// <list type="bullet">
            /// <item><description>The number of accounts with which resources are shared from ROS is independent of the number of accounts with which resources are shared from the resource directory.</description></item>
            /// <item><description>The shared resources from ROS cannot override or overwrite the shared resources from the resource directory.</description></item>
            /// <item><description>The shared resources from the resource directory can overwrite the shared resources from ROS.</description></item>
            /// </list>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROS</para>
            /// </summary>
            [NameInMap("ShareSource")]
            [Validation(Required=false)]
            public string ShareSource { get; set; }

            /// <summary>
            /// <para>The version of the shared template. This parameter is returned only if you set ShareOption to ShareToAccounts and set VersionOption to Specified or Current.</para>
            /// <para>Valid values: v1 to v100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The version option for the shared template. This parameter is returned only if you set ShareOption to ShareToAccounts.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AllVersions: All template versions are shared.</description></item>
            /// <item><description>Latest: Only the latest template version is shared. When the version of the template is updated, Resource Orchestration Service (ROS) updates the shared version to the latest version.</description></item>
            /// <item><description>Current: Only the latest template version is shared. When the version of the template is updated, ROS does not update the shared version.</description></item>
            /// <item><description>Specified: Only the specified template version is shared.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AllVersions</para>
            /// </summary>
            [NameInMap("VersionOption")]
            [Validation(Required=false)]
            public string VersionOption { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the stack or stack group that uses the template. This parameter is returned only if you specify StackId, ChangeSetId, or StackGroupName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The sharing type of the template. This parameter is returned only if you specify TemplateId.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Private: The template belongs to the template owner.</description></item>
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
        /// <para>The name of the stack group. This parameter is returned only if you specify StackGroupName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the stack. This parameter is returned only if you specify StackId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The tags of the template.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetTemplateResponseBodyTags> Tags { get; set; }
        public class GetTemplateResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the template. This parameter is returned only if you specify TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ros:<em>:151266687691</em><em><b>:template/a52f81be-496f-4e1c-a286-8852ab54</b></em>*</para>
        /// </summary>
        [NameInMap("TemplateARN")]
        [Validation(Required=false)]
        public string TemplateARN { get; set; }

        /// <summary>
        /// <para>The content of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The ID of the template. This parameter is returned only if you specify TemplateId.</para>
        /// <para>If the template is a shared template, the value of this parameter is the same as the value of TemplateARN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a52f81be-496f-4e1c-a286-8852ab54****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template. This parameter is returned only if you specify TemplateId.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify TemplateVersion, the name of the template whose version is specified by TemplateVersion is returned.</description></item>
        /// <item><description>If you not specify TemplateVersion, the name of the template whose version is the default version is returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter is returned only if you specify TemplateId.\
        /// If TemplateVersion is not specified or does not take effect, the default version is used.</para>
        /// <para>If the template is a shared template, this parameter is returned only if you set VersionOption to AllVersions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>The time when the template was last updated. This parameter is returned only if you specify TemplateId.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify TemplateVersion, the last update time of the template whose version is specified by TemplateVersion is returned.</description></item>
        /// <item><description>If you do not specify TemplateVersion, the last update time of the template whose version is the default version is returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-07T06:11:48</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
