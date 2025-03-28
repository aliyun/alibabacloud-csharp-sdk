// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The description of the template. The maximum length is 256 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>It is a demo.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether to update the Draft (draft) version. Values:</para>
        /// <list type="bullet">
        /// <item><description>false (default): If template content is provided, a new version is created, and the Draft version is cleared. Otherwise, the current latest version is modified.</description></item>
        /// <item><description>true: Modifies the Draft version. The Draft version can only be retrieved via the GetTemplate interface. The ListTemplateVersions interface will not return it. The TemplateVersion parameter in other interfaces cannot specify Draft.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDraft")]
        [Validation(Required=false)]
        public bool? IsDraft { get; set; }

        /// <summary>
        /// <para>Template version rotation strategy. Values:</para>
        /// <list type="bullet">
        /// <item><description>None (default): No rotation. An error occurs when the version limit is reached.</description></item>
        /// <item><description>DeleteOldestNonSharedVersionWhenLimitExceeded: Rotates and deletes non-shared template versions.<remarks>
        /// <list type="bullet">
        /// <item><description>If all versions of the template are shared, they cannot be rotated and deleted.</description></item>
        /// <item><description>The current latest version will not be rotated and deleted.</description></item>
        /// <item><description>Regardless of whether rotation deletion is used, the template version number cannot exceed v65000.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("RotateStrategy")]
        [Validation(Required=false)]
        public string RotateStrategy { get; set; }

        /// <summary>
        /// <para>The structure of the template body. The length should be between 1 and 524,288 bytes. If the content is long, it is recommended to use HTTP POST + Body Param to pass the parameter in the request body to avoid request failure due to an overly long URL.</para>
        /// <remarks>
        /// <para>You must and can only specify one of <c>TemplateBody</c>, <c>TemplateURL</c>, <c>TemplateId</c>, or <c>TemplateScratchId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. Supports both shared and private templates.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The name of the template.<br>The length should not exceed 255 characters (utf-8 encoding), and it must start with a number, letter, or Chinese character. It can include numbers, letters, Chinese characters, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The location of the file containing the template body. The URL must point to a template located on a web server (HTTP or HTTPS) or in an Alibaba Cloud OSS bucket (e.g., oss://ros/template/demo, oss://ros/template/demo?RegionId=cn-hangzhou), with a maximum size of 524,288 bytes.   </para>
        /// <remarks>
        /// <para>If the OSS region is not specified, it defaults to the same as the <c>RegionId</c> parameter in the request.</para>
        /// </remarks>
        /// <para>You can only specify one of <c>TemplateBody</c> or <c>TemplateURL</c>.<br>The maximum length of the URL is 1,024 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>Validation options.</para>
        /// <para>By default, no options are enabled, and strict validation is performed.</para>
        /// </summary>
        [NameInMap("ValidationOptions")]
        [Validation(Required=false)]
        public List<string> ValidationOptions { get; set; }

    }

}
