// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateWorkItemRequest : TeaModel {
        /// <summary>
        /// 工作项id
        /// </summary>
        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// 更新的字段名
        /// </summary>
        [NameInMap("propertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 更新后的值
        /// </summary>
        [NameInMap("propertyValue")]
        [Validation(Required=false)]
        public string PropertyValue { get; set; }

    }

}
