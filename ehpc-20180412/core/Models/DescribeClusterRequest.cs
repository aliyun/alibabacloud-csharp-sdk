// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeClusterRequest : TeaModel {
        /// <summary>
        /// The type of the protocol that is used by the file system. Valid values:
        /// 
        /// *   nfs
        /// *   smb
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

    }

}
