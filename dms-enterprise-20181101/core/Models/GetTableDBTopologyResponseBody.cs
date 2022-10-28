// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDBTopologyResponseBody : TeaModel {
        [NameInMap("DBTopology")]
        [Validation(Required=false)]
        public GetTableDBTopologyResponseBodyDBTopology DBTopology { get; set; }
        public class GetTableDBTopologyResponseBodyDBTopology : TeaModel {
            [NameInMap("DataSourceList")]
            [Validation(Required=false)]
            public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceList> DataSourceList { get; set; }
            public class GetTableDBTopologyResponseBodyDBTopologyDataSourceList : TeaModel {
                [NameInMap("DatabaseList")]
                [Validation(Required=false)]
                public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseList> DatabaseList { get; set; }
                public class GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseList : TeaModel {
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public string DbId { get; set; }

                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    [NameInMap("DbType")]
                    [Validation(Required=false)]
                    public string DbType { get; set; }

                    [NameInMap("EnvType")]
                    [Validation(Required=false)]
                    public string EnvType { get; set; }

                    [NameInMap("TableList")]
                    [Validation(Required=false)]
                    public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseListTableList> TableList { get; set; }
                    public class GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseListTableList : TeaModel {
                        [NameInMap("TableId")]
                        [Validation(Required=false)]
                        public string TableId { get; set; }

                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                        [NameInMap("TableType")]
                        [Validation(Required=false)]
                        public string TableType { get; set; }

                    }

                }

                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("Sid")]
                [Validation(Required=false)]
                public string Sid { get; set; }

            }

            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

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
