// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;FormatVersion: OOS-2019-06-01\nDescription:\n  en:  Creates an ECS image\n  zh-cn: 创建一个ECS镜像\n  name-en: Create Image\n  name-zh-cn: 创建镜像\n  categories:\n    - image_manage\n    - application_manage\nParameters:\n  regionId:\n    Type: String\n    Label:\n      en: RegionId\n      zh-cn: 地域ID\n    AssociationProperty: RegionId\n    Default: \&quot;{{ ACS::RegionId }}\&quot;\n  instanceId:\n    Label:\n      en: InstanceId\n      zh-cn: ECS实例ID\n    Type: String\n    AssociationProperty: ALIYUN::ECS::Instance::InstanceId\n    AssociationPropertyMetadata:\n      RegionId: regionId\n  imageName:\n    Label:\n      en: ImageName\n      zh-cn: 新镜像的名称\n    Type: String\n    Description:\n      en: &lt;p class=\&quot;p\&quot;&gt;Note:</para> &lt;ul class=\&quot;ul\&quot;&gt; &lt;li class=\&quot;li\&quot;&gt;Length is 2<del>128 English or Chinese characters</description></item> &lt;li class=\&quot;li\&quot;&gt;&lt;font color=\&quot;red\&quot;&gt;must start with big or small letters or Chinese, not http:// and https://. </font></description></item> &lt;li class=\&quot;li\&quot;&gt;Can contain numbers, colons (:), underscores (_), or dashes (-). </description></item> </list>\n      zh-cn: &lt;p class=\&quot;p\&quot;&gt;注意：</para> &lt;ul class=\&quot;ul\&quot;&gt; &lt;li class=\&quot;li\&quot;&gt;长度为2</del>128个英文或中文字符</description></item> &lt;li class=\&quot;li\&quot;&gt;&lt;font color=\&quot;red\&quot;&gt;必须以大小字母或中文开头，不能以http://和https://开头。</font></description></item> &lt;li class=\&quot;li\&quot;&gt;可以包含数字、半角冒号（:）、下划线（_）或者短划线（-）。</description></item> </list>\n  tags:\n    Label:\n      en: Tags\n      zh-cn: 镜像标签\n    Type: Json\n    AssociationProperty: Tags\n    AssociationPropertyMetadata:\n      ShowSystem: false\n    Default: []\n  OOSAssumeRole:\n    Label:\n      en: OOSAssumeRole\n      zh-cn: OOS扮演的RAM角色\n    Type: String\n    Default: OOSServiceRole\nRamRole: \&quot;{{ OOSAssumeRole }}\&quot;\nTasks:\n- Name: createImage\n  Action: ACS::ECS::CreateImage\n  Description:\n    en: Create new image with the specified image name and instance ID\n    zh-cn: 通过指定实例ID和镜像名称创建新的镜像\n  Properties:\n    regionId: \&quot;{{ regionId }}\&quot;\n    imageName: \&quot;{{ imageName }}_<em>on</em>{{ ACS::ExecutionId }}<em>at</em>{{ Acs::CurrentDate }}\&quot;\n    instanceId: \&quot;{{ instanceId }}\&quot;\n    tags: \&quot;{{tags}}\&quot;\n  Outputs:\n    imageId:\n      ValueSelector: imageId\n      Type: String\nOutputs:\n  imageId:\n    Type: String\n    Value: \&quot;{{ createImage.imageId }}\&quot;\nMetadata:\n  ALIYUN::OOS::Interface:\n    ParameterGroups:\n      - Parameters:\n          - regionId\n          - instanceId\n        Label:\n          default:\n            zh-cn: 选择实例\n            en: Select Ecs Instances\n      - Parameters:\n          - imageName\n          - tags\n        Label:\n          default:\n            zh-cn: 镜像设置\n            en: Image Configure\n      - Parameters:\n          - OOSAssumeRole\n        Label:\n          default:\n            zh-cn: 高级选项\n            en: Control Options&quot;</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BBE2663-A18E-5261-9BBB-F4832F5294D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The metadata of the template.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public GetTemplateResponseBodyTemplate Template { get; set; }
        public class GetTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The creator of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS</para>
            /// </summary>
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }

            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-05-16T10:26:14Z</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;en\&quot;: \&quot;Creates an ECS image\&quot;, \&quot;zh-cn\&quot;: \&quot;创建一个ECS镜像\&quot;, \&quot;name-en\&quot;: \&quot;Create Image\&quot;, \&quot;name-zh-cn\&quot;: \&quot;创建镜像\&quot;, \&quot;categories\&quot;: [\&quot;image_manage\&quot;, \&quot;application_manage\&quot;]}&quot;</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the template was configured with a trigger.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasTrigger")]
            [Validation(Required=false)]
            public bool? HasTrigger { get; set; }

            /// <summary>
            /// <para>The SHA-256 value of the template content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40fb5e3e08ef6c8a499ff7cd8441194f518028ad08338a84cb70c023a64576f1</para>
            /// </summary>
            [NameInMap("Hash")]
            [Validation(Required=false)]
            public string Hash { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmxsn4m4******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The share type of the template. The share type of a user-created template is <b>Private</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The tag keys and values. The number of key-value pairs ranges from 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;k1&quot;:&quot;k2&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, object> Tags { get; set; }

            /// <summary>
            /// <para>The format of the template. The system automatically determines whether the format is JSON or YAML.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YAML</para>
            /// </summary>
            [NameInMap("TemplateFormat")]
            [Validation(Required=false)]
            public string TemplateFormat { get; set; }

            /// <summary>
            /// <para>The ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-4bdb1745c171401883a2</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-ECS-CreateImage</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The type of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automation</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The version of the template. The name of the version consists of the letter v and a number. The number starts from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v15</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The user who last updated the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the template was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-26T08:37:07Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

            /// <summary>
            /// <para>The name of the version of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version15</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

    }

}
