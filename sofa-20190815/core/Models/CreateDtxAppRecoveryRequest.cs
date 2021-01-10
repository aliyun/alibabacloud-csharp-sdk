// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateDtxAppRecoveryRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RecoveryJsonStr")]
        [Validation(Required=false)]
        public string RecoveryJsonStr { get; set; }

        [NameInMap("RecoveryDsArray")]
        [Validation(Required=false)]
        public List<CreateDtxAppRecoveryRequestRecoveryDsArray> RecoveryDsArray { get; set; }
        public class CreateDtxAppRecoveryRequestRecoveryDsArray : TeaModel {
            [NameInMap("IsLdc")]
            [Validation(Required=false)]
            public bool? IsLdc { get; set; }

            [NameInMap("DsIndexEnd")]
            [Validation(Required=false)]
            public long? DsIndexEnd { get; set; }

            [NameInMap("ActionTableNameFormat")]
            [Validation(Required=false)]
            public string ActionTableNameFormat { get; set; }

            [NameInMap("IsLocalDs")]
            [Validation(Required=false)]
            public bool? IsLocalDs { get; set; }

            [NameInMap("ActionTableIndexEnd")]
            [Validation(Required=false)]
            public long? ActionTableIndexEnd { get; set; }

            [NameInMap("DbConnectMin")]
            [Validation(Required=false)]
            public long? DbConnectMin { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("DbType")]
            [Validation(Required=false)]
            public long? DbType { get; set; }

            [NameInMap("DbConnMax")]
            [Validation(Required=false)]
            public long? DbConnMax { get; set; }

            [NameInMap("DsIndexStart")]
            [Validation(Required=false)]
            public long? DsIndexStart { get; set; }

            [NameInMap("DsNameFormat")]
            [Validation(Required=false)]
            public string DsNameFormat { get; set; }

            [NameInMap("ActionTableIndexStart")]
            [Validation(Required=false)]
            public long? ActionTableIndexStart { get; set; }

            [NameInMap("ActivityTableIndexEnd")]
            [Validation(Required=false)]
            public long? ActivityTableIndexEnd { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

            [NameInMap("ActivityTableNameFormat")]
            [Validation(Required=false)]
            public string ActivityTableNameFormat { get; set; }

            [NameInMap("ActivityTableIndexStart")]
            [Validation(Required=false)]
            public long? ActivityTableIndexStart { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
