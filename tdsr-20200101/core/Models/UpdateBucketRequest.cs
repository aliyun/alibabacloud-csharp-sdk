// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class UpdateBucketRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// bucket名称
        /// </summary>
        [NameInMap("NewBucketName")]
        [Validation(Required=false)]
        public string NewBucketName { get; set; }

    }

}
