// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateVulsRequest : TeaModel {
        /// <summary>
        /// The operation on the vulnerabilities. Set the value to **vul_fix**, which indicates vulnerability fixing.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// The type of the vulnerabilities that you want to fix. Set the value to **cve**, which indicates Linux software vulnerabilities.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The UUIDs of servers for which you want to fix vulnerabilities.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

        /// <summary>
        /// The names of the vulnerabilities that you want to fix.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VulNames")]
        [Validation(Required=false)]
        public List<string> VulNames { get; set; }

    }

}
