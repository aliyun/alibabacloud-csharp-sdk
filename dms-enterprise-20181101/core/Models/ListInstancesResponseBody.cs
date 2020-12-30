// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public ListInstancesResponseBodyInstanceList InstanceList { get; set; }
        public class ListInstancesResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<ListInstancesResponseBodyInstanceListInstance> Instance { get; set; }
            public class ListInstancesResponseBodyInstanceListInstance : TeaModel {
                public string VpcId { get; set; }
                public string Host { get; set; }
                public string DatabaseUser { get; set; }
                public string State { get; set; }
                public string DbaId { get; set; }
                public string DataLinkName { get; set; }
                public int? ExportTimeout { get; set; }
                public string InstanceId { get; set; }
                public int? UseDsql { get; set; }
                public string InstanceType { get; set; }
                public int? Port { get; set; }
                public string EcsInstanceId { get; set; }
                public string DatabasePassword { get; set; }
                public string EnvType { get; set; }
                public string Sid { get; set; }
                public string InstanceAlias { get; set; }
                public int? DdlOnline { get; set; }
                public string SafeRuleId { get; set; }
                public string EcsRegion { get; set; }
                public string DbaNickName { get; set; }
                public int? QueryTimeout { get; set; }
                public string InstanceSource { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
