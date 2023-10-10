// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplatesRequest : TeaModel {
        /// <summary>
        /// The page number.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("page_num")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The type of template. This parameter can be set to a custom value.
        /// 
        /// *   If the parameter is set to `kubernetes`, the template is displayed on the Templates page in the console.
        /// *   If you set the parameter to `compose`, the template is not displayed on the Templates page in the console.
        /// 
        /// Default value: `kubernetes`.
        /// </summary>
        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
