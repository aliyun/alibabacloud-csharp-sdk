// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeImageInfosRequest : TeaModel {
        /// <summary>
        /// The operating system (OS). You can specify only one OS in a request. If you do not specify a value for this parameter, images for all supported OSs are queried. Valid values:
        /// 
        /// *   linux
        /// *   windows
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

    }

}
