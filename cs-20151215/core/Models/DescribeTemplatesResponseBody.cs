// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// 分页信息。
        /// </summary>
        [NameInMap("page_info")]
        [Validation(Required=false)]
        public DescribeTemplatesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeTemplatesResponseBodyPageInfo : TeaModel {
            [NameInMap("page_number")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("total_count")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        /// <summary>
        /// 模板列表。
        /// </summary>
        [NameInMap("templates")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// 模板访问权限，取值为：private、pubilc或shared。。
            /// </summary>
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            /// <summary>
            /// 模板创建时间。
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 模板描述信息。
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 模板ID。会模板随着更新而变化。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 模板名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 模板标签，如果不显式指定了，默认为模板名称。
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// 模板详情。
            /// </summary>
            [NameInMap("template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            /// <summary>
            /// 部署模板类型。
            /// </summary>
            [NameInMap("template_type")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// 模板唯一ID。
            /// </summary>
            [NameInMap("template_with_hist_id")]
            [Validation(Required=false)]
            public string TemplateWithHistId { get; set; }

            /// <summary>
            /// 模板修改时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
