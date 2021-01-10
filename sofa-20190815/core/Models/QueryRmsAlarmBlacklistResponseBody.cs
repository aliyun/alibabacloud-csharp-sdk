// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsAlarmBlacklistResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsAlarmBlacklistResponseBodyResponse Response { get; set; }
        public class QueryRmsAlarmBlacklistResponseBodyResponse : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<QueryRmsAlarmBlacklistResponseBodyResponseEntities> Entities { get; set; }
            public class QueryRmsAlarmBlacklistResponseBodyResponseEntities : TeaModel {
                public string Layer { get; set; }
                public QueryRmsAlarmBlacklistResponseBodyResponseEntitiesEntity Entity { get; set; }
                public class QueryRmsAlarmBlacklistResponseBodyResponseEntitiesEntity : TeaModel {
                    [NameInMap("ApplyTargetId")]
                    [Validation(Required=false)]
                    public string ApplyTargetId { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("ResId")]
                    [Validation(Required=false)]
                    public string ResId { get; set; }

                    [NameInMap("ResName")]
                    [Validation(Required=false)]
                    public string ResName { get; set; }

                    [NameInMap("ResType")]
                    [Validation(Required=false)]
                    public string ResType { get; set; }

                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                    [NameInMap("UtcCreated")]
                    [Validation(Required=false)]
                    public string UtcCreated { get; set; }

                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public string UtcModified { get; set; }

                    [NameInMap("ValidEndTime")]
                    [Validation(Required=false)]
                    public string ValidEndTime { get; set; }

                    [NameInMap("ValidStartTime")]
                    [Validation(Required=false)]
                    public string ValidStartTime { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }
            }
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public List<QueryRmsAlarmBlacklistResponseBodyResponseMeta> Meta { get; set; }
            public class QueryRmsAlarmBlacklistResponseBodyResponseMeta : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
