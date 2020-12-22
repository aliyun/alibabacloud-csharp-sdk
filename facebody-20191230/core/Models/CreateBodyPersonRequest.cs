// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class CreateBodyPersonRequest : TeaModel {
        /// <summary>
        /// 数据库ID
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long DbId { get; set; }

        /// <summary>
        /// 实体ID，可以包含数字、字母和下划线，相同db下不可以重复，长度1-64。
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
