// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectResultRequest : TeaModel {
        /// <summary>
        /// An array that consists of the identifiers of files. Only MD5 hash values are supported.
        /// </summary>
        [NameInMap("HashKeyList")]
        [Validation(Required=false)]
        public List<string> HashKeyList { get; set; }

        /// <summary>
        /// The source IP address of the request.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the file. Valid values:
        /// 
        /// *   **0**: unknown file
        /// *   **1**: binary file
        /// *   **2**: webshell file
        /// *   **4**: script file
        /// 
        /// >  If you do not know the type of the file, set this parameter to 0.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
