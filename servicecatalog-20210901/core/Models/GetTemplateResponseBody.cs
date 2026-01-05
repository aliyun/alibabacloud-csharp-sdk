// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The content of the template.</para>
        /// <para>For more information about the template syntax, see <a href="https://help.aliyun.com/document_detail/184397.html">Structure of Terraform templates</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;,
        ///   &quot;Transform&quot;: &quot;Aliyun::Terraform-v1.1&quot;,
        ///   &quot;Workspace&quot;: {
        ///     &quot;main.tf&quot;: &quot;variable  \&quot;name\&quot; {  default = \&quot;auto_provisioning_group\&quot;}&quot;
        ///   },
        ///   &quot;Outputs&quot;: {}
        /// }</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

    }

}
