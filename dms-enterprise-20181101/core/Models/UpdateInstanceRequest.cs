// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class UpdateInstanceRequest : TeaModel {
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        [NameInMap("EcsRegion")]
        [Validation(Required=false)]
        public string EcsRegion { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        [NameInMap("DatabaseUser")]
        [Validation(Required=false)]
        public string DatabaseUser { get; set; }

        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("DbaId")]
        [Validation(Required=false)]
        public string DbaId { get; set; }

        [NameInMap("SafeRuleId")]
        [Validation(Required=false)]
        public string SafeRuleId { get; set; }

        [NameInMap("QueryTimeout")]
        [Validation(Required=false)]
        public int? QueryTimeout { get; set; }

        [NameInMap("ExportTimeout")]
        [Validation(Required=false)]
        public int? ExportTimeout { get; set; }

        [NameInMap("DataLinkName")]
        [Validation(Required=false)]
        public string DataLinkName { get; set; }

        [NameInMap("DdlOnline")]
        [Validation(Required=false)]
        public int? DdlOnline { get; set; }

        [NameInMap("UseDsql")]
        [Validation(Required=false)]
        public int? UseDsql { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("SkipTest")]
        [Validation(Required=false)]
        public bool? SkipTest { get; set; }

    }

}
