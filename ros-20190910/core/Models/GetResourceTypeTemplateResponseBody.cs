// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetResourceTypeTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87F54B2B-AEF0-4C33-A72A-3F8856A575E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The structure that contains the template body. The template body must be 1 to 51,200 bytes in length. For more information, see <a href="https://help.aliyun.com/document_detail/28857.html">Template syntax</a>.</para>
        /// <remarks>
        /// <para>We recommend that use TemplateContent instead of TemplateBody.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateBody { get; set; }

        /// <summary>
        /// <para>The JSON-formatted structure of the template body. For more information, see <a href="https://help.aliyun.com/document_detail/28857.html">Template syntax</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

    }

}
