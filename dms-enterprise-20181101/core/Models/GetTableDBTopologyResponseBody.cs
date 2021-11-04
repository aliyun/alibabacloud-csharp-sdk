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
                public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseList> DatabaseList { get; set; }
                public class GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseList : TeaModel {
                    public string DbId { get; set; }
                    public string DbName { get; set; }
                    public string DbType { get; set; }
                    public string EnvType { get; set; }
                    public List<GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseListTableList> TableList { get; set; }
                    public class GetTableDBTopologyResponseBodyDBTopologyDataSourceListDatabaseListTableList : TeaModel {
                        public string TableId { get; set; }
                        public string TableName { get; set; }
                        public string TableType { get; set; }
                    }
                }
                public string DbType { get; set; }
                public string Host { get; set; }
                public int? Port { get; set; }
                public string Sid { get; set; }
            }
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }
        };

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
