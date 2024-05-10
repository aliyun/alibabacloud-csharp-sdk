// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ScheduledSQLConfiguration : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("destEndpoint")]
        [Validation(Required=false)]
        public string DestEndpoint { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("destLogstore")]
        [Validation(Required=false)]
        public string DestLogstore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("destProject")]
        [Validation(Required=false)]
        public string DestProject { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("destRoleArn")]
        [Validation(Required=false)]
        public string DestRoleArn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fromTimeExpr")]
        [Validation(Required=false)]
        public string FromTimeExpr { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public long? MaxRetries { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public long? MaxRunTimeInSeconds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourcePool")]
        [Validation(Required=false)]
        public string ResourcePool { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sourceLogstore")]
        [Validation(Required=false)]
        public string SourceLogstore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("toTimeExpr")]
        [Validation(Required=false)]
        public string ToTimeExpr { get; set; }

    }

}
