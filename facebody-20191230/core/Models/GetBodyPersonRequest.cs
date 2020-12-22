// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class GetBodyPersonRequest : TeaModel {
        /// <summary>
        /// 数据库ID
        /// </summary>
        [NameInMap("DbId")]
        [Validation(Required=false)]
        public long DbId { get; set; }

        /// <summary>
        /// 人员ID
        /// </summary>
        [NameInMap("PersonId")]
        [Validation(Required=false)]
        public long PersonId { get; set; }

    }

}
