// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The description of the template. The description can be up to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>It is a demo.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.\
        /// For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">Resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the template.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestTags> Tags { get; set; }
        public class CreateTemplateRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the template.</para>
            /// <remarks>
            /// <para>Tags is optional. If you need to specify Tags, you must also specify Key.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
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
        /// <para>The structure of the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.</para>
        /// <remarks>
        /// <para>You must specify TemplateBody or TemplateURL.</para>
        /// </remarks>
        /// <para>You can create a Terraform template based on your business requirements. The following sample code provides an example on how to create a Terraform template:</para>
        /// <pre><c>{
        ///   &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;,
        ///   &quot;Transform&quot;: &quot;Aliyun::Terraform-v1.0&quot;,
        ///   &quot;Workspace&quot;: {
        ///     &quot;main.tf&quot;: &quot;variable  \\&quot;name\\&quot; {  default = \\&quot;auto_provisioning_group\\&quot;}&quot;
        ///   },
        ///   &quot;Outputs&quot;: {}
        /// }
        /// </c></pre>
        /// <para>For more information about Terraform templates, see <a href="https://help.aliyun.com/document_detail/184397.html">Structure of Terraform templates</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The name of the template.\
        /// The name can be up to 255 characters in length and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo or oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The template body must be 1 to 1,024 bytes in length. If you do not specify the region of the OSS bucket, the value of RegionId is used.</para>
        /// <remarks>
        /// <para>You must specify TemplateBody or TemplateURL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        [NameInMap("ValidationOptions")]
        [Validation(Required=false)]
        public List<string> ValidationOptions { get; set; }

    }

}
