// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AddInstanceRequest : TeaModel {
        [NameInMap("DataLinkName")]
        [Validation(Required=false)]
        public string DataLinkName { get; set; }

        [NameInMap("DatabasePassword")]
        [Validation(Required=false)]
        public string DatabasePassword { get; set; }

        [NameInMap("DatabaseUser")]
        [Validation(Required=false)]
        public string DatabaseUser { get; set; }

        [NameInMap("DbaId")]
        [Validation(Required=false)]
        public long? DbaId { get; set; }

        [NameInMap("DdlOnline")]
        [Validation(Required=false)]
        public int? DdlOnline { get; set; }

        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

        [NameInMap("EcsRegion")]
        [Validation(Required=false)]
        public string EcsRegion { get; set; }

        [NameInMap("EnableSellCommon")]
        [Validation(Required=false)]
        public string EnableSellCommon { get; set; }

        [NameInMap("EnableSellSitd")]
        [Validation(Required=false)]
        public string EnableSellSitd { get; set; }

        [NameInMap("EnableSellStable")]
        [Validation(Required=false)]
        public string EnableSellStable { get; set; }

        [NameInMap("EnableSellTrust")]
        [Validation(Required=false)]
        public string EnableSellTrust { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("ExportTimeout")]
        [Validation(Required=false)]
        public int? ExportTimeout { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("InstanceSource")]
        [Validation(Required=false)]
        public string InstanceSource { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("QueryTimeout")]
        [Validation(Required=false)]
        public int? QueryTimeout { get; set; }

        [NameInMap("SafeRule")]
        [Validation(Required=false)]
        public string SafeRule { get; set; }

        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        [NameInMap("SkipTest")]
        [Validation(Required=false)]
        public bool? SkipTest { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        [NameInMap("UseDsql")]
        [Validation(Required=false)]
        public int? UseDsql { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
