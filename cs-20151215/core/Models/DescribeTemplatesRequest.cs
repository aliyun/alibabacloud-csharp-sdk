// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplatesRequest : TeaModel {
        /// <summary>
        /// 模板类型，部署模板类型，目前一共有2种类型，取值为：kubernetes或compose。
        /// </summary>
        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// 对查询结果进行分页处理，指定返回第几页的数据。  默认值为 1
        /// </summary>
        [NameInMap("page_num")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// 对查询结果进行分页处理，指定每页包含的数据条数。  默认值为 10
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
