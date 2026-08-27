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
        /// <para>The ID of the resource group.
        /// For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.html">What is a resource group?</a>.</para>
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
            /// <para>Tags is an optional parameter. If you specify Tags, you must specify \<c>Tags.N.Key\\</c>.</para>
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
        /// <para>The structure of the template body. The template body must be 1 to 524,288 bytes in length. If the template body is large, specify the parameter in the request body to prevent request failures caused by an excessively long URL.</para>
        /// <remarks>
        /// <para>You can specify only one of the \<c>TemplateBody\\</c>, \<c>TemplateURL\\</c>, and \<c>TemplateId\\</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The name of the template. The name can be up to 255 characters in length. It must start with a digit, letter, or Chinese character. It can contain digits, letters, Chinese characters, hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on a web server (HTTP or HTTPS) or in an Alibaba Cloud Object Storage Service (OSS) bucket, such as oss\://ros/stack-policy/demo or oss\://ros/stack-policy/demo?RegionId=cn-hangzhou. The template body must be 1 to 1,024 bytes in length. If you do not specify the region of the OSS bucket, the value of the RegionId parameter is used.</para>
        /// <remarks>
        /// <para>You must specify only one of the \<c>TemplateBody\\</c> and \<c>TemplateURL\\</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The validation options.</para>
        /// <para>By default, no options are enabled and strict validation is performed.</para>
        /// </summary>
        [NameInMap("ValidationOptions")]
        [Validation(Required=false)]
        public List<string> ValidationOptions { get; set; }

    }

}
