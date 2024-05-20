// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationConfigRequest : TeaModel {
        /// <summary>
        /// 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 0026ff7f-2b57-4127-bdd0-9bf202bb\\*\\*\\*\\*
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
