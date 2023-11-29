// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateOceanBaseDataSourceRequest : TeaModel {
        [NameInMap("Cluster")]
        [Validation(Required=false)]
        public string Cluster { get; set; }

        [NameInMap("ConfigUrl")]
        [Validation(Required=false)]
        public string ConfigUrl { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DrcPassword")]
        [Validation(Required=false)]
        public string DrcPassword { get; set; }

        [NameInMap("DrcUserName")]
        [Validation(Required=false)]
        public string DrcUserName { get; set; }

        [NameInMap("InnerDrcPassword")]
        [Validation(Required=false)]
        public string InnerDrcPassword { get; set; }

        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// LogProxy IP。
        /// </summary>
        [NameInMap("LogProxyIp")]
        [Validation(Required=false)]
        public string LogProxyIp { get; set; }

        [NameInMap("LogProxyPort")]
        [Validation(Required=false)]
        public string LogProxyPort { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public string Tenant { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
