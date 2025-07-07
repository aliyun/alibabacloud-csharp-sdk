// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseTodoQueryAccountTodoListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EnterpriseTodoQueryAccountTodoListResponseBodyData Data { get; set; }
        public class EnterpriseTodoQueryAccountTodoListResponseBodyData : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("TodoList")]
            [Validation(Required=false)]
            public List<EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoList> TodoList { get; set; }
            public class EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoList : TeaModel {
                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                [NameInMap("ApplicantAliyunId")]
                [Validation(Required=false)]
                public string ApplicantAliyunId { get; set; }

                [NameInMap("ApplicantPk")]
                [Validation(Required=false)]
                public string ApplicantPk { get; set; }

                [NameInMap("ApplyRemark")]
                [Validation(Required=false)]
                public string ApplyRemark { get; set; }

                [NameInMap("ApplyTime")]
                [Validation(Required=false)]
                public long? ApplyTime { get; set; }

                [NameInMap("AuditorAliyunId")]
                [Validation(Required=false)]
                public string AuditorAliyunId { get; set; }

                [NameInMap("AuditorPk")]
                [Validation(Required=false)]
                public string AuditorPk { get; set; }

                [NameInMap("AuditorStatus")]
                [Validation(Required=false)]
                public string AuditorStatus { get; set; }

                [NameInMap("CanceledTime")]
                [Validation(Required=false)]
                public long? CanceledTime { get; set; }

                [NameInMap("Closed")]
                [Validation(Required=false)]
                public bool? Closed { get; set; }

                [NameInMap("CurrAuditor")]
                [Validation(Required=false)]
                public bool? CurrAuditor { get; set; }

                [NameInMap("FromLe")]
                [Validation(Required=false)]
                public EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListFromLe FromLe { get; set; }
                public class EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListFromLe : TeaModel {
                    [NameInMap("EcId")]
                    [Validation(Required=false)]
                    public string EcId { get; set; }

                    [NameInMap("LeId")]
                    [Validation(Required=false)]
                    public string LeId { get; set; }

                    [NameInMap("LicenseNumber")]
                    [Validation(Required=false)]
                    public string LicenseNumber { get; set; }

                    [NameInMap("ManageableAccountCount")]
                    [Validation(Required=false)]
                    public long? ManageableAccountCount { get; set; }

                    [NameInMap("ManagedAccountCount")]
                    [Validation(Required=false)]
                    public long? ManagedAccountCount { get; set; }

                    [NameInMap("ManagerList")]
                    [Validation(Required=false)]
                    public List<EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListFromLeManagerList> ManagerList { get; set; }
                    public class EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListFromLeManagerList : TeaModel {
                        [NameInMap("AliyunId")]
                        [Validation(Required=false)]
                        public string AliyunId { get; set; }

                        [NameInMap("Pk")]
                        [Validation(Required=false)]
                        public string Pk { get; set; }

                        [NameInMap("PkEncoded")]
                        [Validation(Required=false)]
                        public string PkEncoded { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                    [NameInMap("NbId")]
                    [Validation(Required=false)]
                    public string NbId { get; set; }

                    [NameInMap("SubjectName")]
                    [Validation(Required=false)]
                    public string SubjectName { get; set; }

                    [NameInMap("SubjectType")]
                    [Validation(Required=false)]
                    public string SubjectType { get; set; }

                }

                [NameInMap("Pk")]
                [Validation(Required=false)]
                public string Pk { get; set; }

                [NameInMap("ProcessList")]
                [Validation(Required=false)]
                public List<EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListProcessList> ProcessList { get; set; }
                public class EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListProcessList : TeaModel {
                    [NameInMap("AliyunId")]
                    [Validation(Required=false)]
                    public string AliyunId { get; set; }

                    [NameInMap("AuditTime")]
                    [Validation(Required=false)]
                    public long? AuditTime { get; set; }

                    [NameInMap("EcId")]
                    [Validation(Required=false)]
                    public string EcId { get; set; }

                    [NameInMap("LeId")]
                    [Validation(Required=false)]
                    public string LeId { get; set; }

                    [NameInMap("NbId")]
                    [Validation(Required=false)]
                    public string NbId { get; set; }

                    [NameInMap("Pk")]
                    [Validation(Required=false)]
                    public string Pk { get; set; }

                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TimeoutTime")]
                [Validation(Required=false)]
                public long? TimeoutTime { get; set; }

                [NameInMap("ToLe")]
                [Validation(Required=false)]
                public EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListToLe ToLe { get; set; }
                public class EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListToLe : TeaModel {
                    [NameInMap("EcId")]
                    [Validation(Required=false)]
                    public string EcId { get; set; }

                    [NameInMap("LeId")]
                    [Validation(Required=false)]
                    public string LeId { get; set; }

                    [NameInMap("LicenseNumber")]
                    [Validation(Required=false)]
                    public string LicenseNumber { get; set; }

                    [NameInMap("ManageableAccountCount")]
                    [Validation(Required=false)]
                    public long? ManageableAccountCount { get; set; }

                    [NameInMap("ManagedAccountCount")]
                    [Validation(Required=false)]
                    public long? ManagedAccountCount { get; set; }

                    [NameInMap("ManagerList")]
                    [Validation(Required=false)]
                    public List<EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListToLeManagerList> ManagerList { get; set; }
                    public class EnterpriseTodoQueryAccountTodoListResponseBodyDataTodoListToLeManagerList : TeaModel {
                        [NameInMap("AliyunId")]
                        [Validation(Required=false)]
                        public string AliyunId { get; set; }

                        [NameInMap("Pk")]
                        [Validation(Required=false)]
                        public string Pk { get; set; }

                        [NameInMap("PkEncoded")]
                        [Validation(Required=false)]
                        public string PkEncoded { get; set; }

                        [NameInMap("Role")]
                        [Validation(Required=false)]
                        public string Role { get; set; }

                    }

                    [NameInMap("NbId")]
                    [Validation(Required=false)]
                    public string NbId { get; set; }

                    [NameInMap("SubjectName")]
                    [Validation(Required=false)]
                    public string SubjectName { get; set; }

                    [NameInMap("SubjectType")]
                    [Validation(Required=false)]
                    public string SubjectType { get; set; }

                }

                [NameInMap("ToLeAudit")]
                [Validation(Required=false)]
                public bool? ToLeAudit { get; set; }

                [NameInMap("TodoId")]
                [Validation(Required=false)]
                public string TodoId { get; set; }

                [NameInMap("TodoType")]
                [Validation(Required=false)]
                public string TodoType { get; set; }

                [NameInMap("TodoView")]
                [Validation(Required=false)]
                public string TodoView { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
