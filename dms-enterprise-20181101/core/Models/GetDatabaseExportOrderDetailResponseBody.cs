// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDatabaseExportOrderDetailResponseBody : TeaModel {
        [NameInMap("DatabaseExportOrderDetail")]
        [Validation(Required=false)]
        public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetail DatabaseExportOrderDetail { get; set; }
        public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetail : TeaModel {
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("Committer")]
            [Validation(Required=false)]
            public string Committer { get; set; }

            [NameInMap("CommitterId")]
            [Validation(Required=false)]
            public string CommitterId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("KeyInfo")]
            [Validation(Required=false)]
            public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfo KeyInfo { get; set; }
            public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfo : TeaModel {
                [NameInMap("AuditDate")]
                [Validation(Required=false)]
                public string AuditDate { get; set; }

                [NameInMap("Config")]
                [Validation(Required=false)]
                public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfig Config { get; set; }
                public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfig : TeaModel {
                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    [NameInMap("ExportContent")]
                    [Validation(Required=false)]
                    public string ExportContent { get; set; }

                    [NameInMap("ExportTypes")]
                    [Validation(Required=false)]
                    public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigExportTypes ExportTypes { get; set; }
                    public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigExportTypes : TeaModel {
                        [NameInMap("ExportTypes")]
                        [Validation(Required=false)]
                        public List<string> ExportTypes { get; set; }

                    }

                    [NameInMap("SQLExtOption")]
                    [Validation(Required=false)]
                    public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigSQLExtOption SQLExtOption { get; set; }
                    public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigSQLExtOption : TeaModel {
                        [NameInMap("SQLExtOption")]
                        [Validation(Required=false)]
                        public List<string> SQLExtOption { get; set; }

                    }

                    [NameInMap("SelectedTables")]
                    [Validation(Required=false)]
                    public GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigSelectedTables SelectedTables { get; set; }
                    public class GetDatabaseExportOrderDetailResponseBodyDatabaseExportOrderDetailKeyInfoConfigSelectedTables : TeaModel {
                        [NameInMap("SelectedTables")]
                        [Validation(Required=false)]
                        public List<string> SelectedTables { get; set; }

                    }

                    [NameInMap("TargetOption")]
                    [Validation(Required=false)]
                    public string TargetOption { get; set; }

                }

                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                [NameInMap("DownloadURL")]
                [Validation(Required=false)]
                public string DownloadURL { get; set; }

            }

            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("WorkflowStatusDesc")]
            [Validation(Required=false)]
            public string WorkflowStatusDesc { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
