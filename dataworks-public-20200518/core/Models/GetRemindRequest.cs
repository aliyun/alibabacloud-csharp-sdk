// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetRemindRequest : TeaModel {
        /// <summary>
        /// The custom alert rule ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RemindId")]
        [Validation(Required=false)]
        public long? RemindId { get; set; }

    }

}
