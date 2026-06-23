// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeTemplatesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeTemplatesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The list of templates.</para>
        /// </summary>
        [NameInMap("templates")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The access permissions for the deployment template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>private</c>: private.</description></item>
            /// <item><description><c>public</c>: public.</description></item>
            /// <item><description><c>shared</c>: shared.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>private</para>
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// <para>The time when the orchestration template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25T16:56:33+08:00</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <para>The description of the orchestration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a web server</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the orchestration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>874ec485-e7e6-4373-8a3b-47bde8******</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the orchestration template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>webserver</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The tag of the orchestration template. If not explicitly specified, the tag defaults to the template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kubernetes</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The template content in YAML format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiVersion: apps/v1\nkind: Deployment\nmetadata:\n  name: nginx-deployment-basic\n  labels:\n    app: nginx\nspec:\n  replicas: 2\n  selector:\n    matchLabels:\n      app: nginx\n  template:\n    metadata:\n      labels:\n        app: nginx\n    spec:\n      containers:\n      - name: nginx\n        image: busybox:latest\n        ports:\n        - containerPort: 80</para>
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// <para>The templatetype.</para>
            /// <list type="bullet">
            /// <item><description><para>If the value is set to kubernetes, the template is displayed on the Orchestration Templates page in the console.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is left empty or set to other values, the template is not displayed on the Orchestration Templates page in the console.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>kubernetes</para>
            /// </summary>
            [NameInMap("template_type")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// <para>The ID of the parent template associated with the template. This parameter is used to implement template versioning. Different versions of the same template share the same <c>template_with_hist_id</c> value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ad81d115-7c8b-47e7-a222-9c28d7******</para>
            /// </summary>
            [NameInMap("template_with_hist_id")]
            [Validation(Required=false)]
            public string TemplateWithHistId { get; set; }

            /// <summary>
            /// <para>The time when the orchestration template was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-25T16:56:33+08:00</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
