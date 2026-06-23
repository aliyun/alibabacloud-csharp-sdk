// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The description of the deployment template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web server cluster</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the deployment template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>webserver01</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The tags of the deployment template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>web</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The template content in YAML format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: apps/v1\\nkind: Deployment\\nmetadata:\\n  name: nginx-deployment-basic\\n  labels:\\n    app: nginx\\nspec:\\n  replicas: 2\\n  selector:\\n    matchLabels:\\n      app: nginx\\n  template:\\n    metadata:\\n      labels:\\n        app: nginx\\n    spec:\\n      containers:\\n      - name: nginx\\n        image: busybox:latest\\n        ports:\\n        - containerPort: 8080</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The templatetype.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <c>kubernetes</c>, the template is displayed on the Orchestration Templates page in the console.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty or set it to other values, the template is not displayed on the Orchestration Templates page in the console.</para>
        /// </description></item>
        /// </list>
        /// <para>Settings this parameter to <c>kubernetes</c> is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes</para>
        /// </summary>
        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
