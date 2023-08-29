// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class CreateLockRequest : TeaModel {
        /// <summary>
        /// LockObjList
        /// </summary>
        [NameInMap("LockObjList")]
        [Validation(Required=false)]
        public List<LockObj> LockObjList { get; set; }

    }

}
