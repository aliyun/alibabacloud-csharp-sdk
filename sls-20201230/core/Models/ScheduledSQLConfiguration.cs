// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ScheduledSQLConfiguration : TeaModel {
        [NameInMap("dataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        [NameInMap("destEndpoint")]
        [Validation(Required=false)]
        public string DestEndpoint { get; set; }

        [NameInMap("destLogstore")]
        [Validation(Required=false)]
        public string DestLogstore { get; set; }

        [NameInMap("destProject")]
        [Validation(Required=false)]
        public string DestProject { get; set; }

        [NameInMap("destRoleArn")]
        [Validation(Required=false)]
        public string DestRoleArn { get; set; }

        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        [NameInMap("fromTimeExpr")]
        [Validation(Required=false)]
        public string FromTimeExpr { get; set; }

        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public long? MaxRetries { get; set; }

        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public long? MaxRunTimeInSeconds { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("resourcePool")]
        [Validation(Required=false)]
        public string ResourcePool { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        [NameInMap("sourceLogstore")]
        [Validation(Required=false)]
        public string SourceLogstore { get; set; }

        [NameInMap("sqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        [NameInMap("toTimeExpr")]
        [Validation(Required=false)]
        public string ToTimeExpr { get; set; }

    }

}
