// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeTemplatesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeTemplatesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// The list of returned templates.
        /// </summary>
        [NameInMap("templates")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// The access control policy of the template. Valid values:
            /// 
            /// *   `private`: The template is private.
            /// *   `public`: The template is public.
            /// *   `shared`: The template can be shared.
            /// 
            /// Default value: `private`.
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// The time when the template was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// The description of the template.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the template.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the template.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The label of the template. By default, the value is the name of the template.
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// The template content in the YAML format.
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// The type of template. This parameter can be set to a custom value.
            /// 
            /// *   If the parameter is set to `kubernetes`, the template is displayed on the Templates page in the console.
            /// *   If the parameter is set to `compose`, the template is displayed on the Container Service - Swarm page in the console. However, Container Service for Swarm is deprecated.
            /// </summary>
            [NameInMap("template_type")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// The ID of the parent template. The value of `template_with_hist_id` is the same for each template version. This allows you to manage different template versions.
            /// </summary>
            [NameInMap("template_with_hist_id")]
            [Validation(Required=false)]
            public string TemplateWithHistId { get; set; }

            /// <summary>
            /// The time when the template was updated.
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
