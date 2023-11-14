// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLogMetaRequest : TeaModel {
        /// <summary>
        /// The name of the dedicated Logstore in which logs are stored.
        /// 
        /// >  You can call the [DescribeLogMeta](~~DescribeLogMeta~~) operation to query the name of the Logstore.
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

    }

}
