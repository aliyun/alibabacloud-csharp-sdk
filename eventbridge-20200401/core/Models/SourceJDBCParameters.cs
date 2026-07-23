// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SourceJDBCParameters : TeaModel {
        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public int? BatchSize { get; set; }

        [NameInMap("CustomQuery")]
        [Validation(Required=false)]
        public string CustomQuery { get; set; }

        [NameInMap("IncrementingColumn")]
        [Validation(Required=false)]
        public string IncrementingColumn { get; set; }

        [NameInMap("JdbcUrl")]
        [Validation(Required=false)]
        public string JdbcUrl { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("PollingInterval")]
        [Validation(Required=false)]
        public int? PollingInterval { get; set; }

        [NameInMap("QueryMode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        [NameInMap("QueryTimeout")]
        [Validation(Required=false)]
        public int? QueryTimeout { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("TimestampColumn")]
        [Validation(Required=false)]
        public string TimestampColumn { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
