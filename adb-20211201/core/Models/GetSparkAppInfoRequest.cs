// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the application. 
        /// 
        /// >  You can call the [ListSparkApps](~~612475~~) operation to query the Spark application ID.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

    }

}
