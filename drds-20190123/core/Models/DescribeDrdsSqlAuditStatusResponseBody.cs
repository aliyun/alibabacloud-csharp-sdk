// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsSqlAuditStatusResponseBody : TeaModel {
        /// <summary>
        /// The returned data set.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDrdsSqlAuditStatusResponseBodyData Data { get; set; }
        public class DescribeDrdsSqlAuditStatusResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeDrdsSqlAuditStatusResponseBodyDataData> Data { get; set; }
            public class DescribeDrdsSqlAuditStatusResponseBodyDataData : TeaModel {
                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// Indicates whether the complete report of the SQL audit is supported. Valid values: true and false.
                /// </summary>
                [NameInMap("Detailed")]
                [Validation(Required=false)]
                public string Detailed { get; set; }

                /// <summary>
                /// Indicates whether the SQL audit feature is enabled for the database. Valid values: true and false.
                /// </summary>
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// The UID of the external delivery.
                /// 
                /// > This parameter is returned only if external log delivery is enabled.
                /// </summary>
                [NameInMap("ExtraAliUid")]
                [Validation(Required=false)]
                public long? ExtraAliUid { get; set; }

                /// <summary>
                /// The Log Service Logstore from which logs are delivered.
                /// 
                /// > This parameter is returned only if external log delivery is enabled.
                /// </summary>
                [NameInMap("ExtraSlsLogStore")]
                [Validation(Required=false)]
                public string ExtraSlsLogStore { get; set; }

                /// <summary>
                /// The Log Service project from which logs are delivered.
                /// 
                /// > This parameter is returned only if external log delivery is enabled.
                /// </summary>
                [NameInMap("ExtraSlsProject")]
                [Validation(Required=false)]
                public string ExtraSlsProject { get; set; }

                /// <summary>
                /// Indicates whether external log delivery is enabled. Valid values: true and false.
                /// </summary>
                [NameInMap("ExtraWriteEnabled")]
                [Validation(Required=false)]
                public bool? ExtraWriteEnabled { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the request.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
