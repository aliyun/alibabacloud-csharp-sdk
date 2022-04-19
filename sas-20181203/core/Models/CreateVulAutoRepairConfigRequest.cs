// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateVulAutoRepairConfigRequest : TeaModel {
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// 漏洞类型
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("VulAutoRepairConfigList")]
        [Validation(Required=false)]
        public List<CreateVulAutoRepairConfigRequestVulAutoRepairConfigList> VulAutoRepairConfigList { get; set; }
        public class CreateVulAutoRepairConfigRequestVulAutoRepairConfigList : TeaModel {
            /// <summary>
            /// 漏洞别名
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// 漏洞名称
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
