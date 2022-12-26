// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClientUserDefineRuleRequest : TeaModel {
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        [NameInMap("Cmdline")]
        [Validation(Required=false)]
        public string Cmdline { get; set; }

        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Md5List")]
        [Validation(Required=false)]
        public string Md5List { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NewFilePath")]
        [Validation(Required=false)]
        public string NewFilePath { get; set; }

        [NameInMap("ParentCmdline")]
        [Validation(Required=false)]
        public string ParentCmdline { get; set; }

        [NameInMap("ParentProcPath")]
        [Validation(Required=false)]
        public string ParentProcPath { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("PortStr")]
        [Validation(Required=false)]
        public string PortStr { get; set; }

        [NameInMap("ProcPath")]
        [Validation(Required=false)]
        public string ProcPath { get; set; }

        [NameInMap("RegistryContent")]
        [Validation(Required=false)]
        public string RegistryContent { get; set; }

        [NameInMap("RegistryKey")]
        [Validation(Required=false)]
        public string RegistryKey { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
