// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDBTopologyResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("DBTopology")]
        [Validation(Required=false)]
        public GetDBTopologyResponseBodyDBTopology DBTopology { get; set; }
        public class GetDBTopologyResponseBodyDBTopology : TeaModel {
            [NameInMap("LogicDbId")]
            [Validation(Required=false)]
            public long? LogicDbId { get; set; }
            [NameInMap("LogicDbName")]
            [Validation(Required=false)]
            public string LogicDbName { get; set; }
            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }
            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }
            [NameInMap("DBTopologyInfoList")]
            [Validation(Required=false)]
            public List<GetDBTopologyResponseBodyDBTopologyDBTopologyInfoList> DBTopologyInfoList { get; set; }
            public class GetDBTopologyResponseBodyDBTopologyDBTopologyInfoList : TeaModel {
                public long? DbId { get; set; }
                public string SchemaName { get; set; }
                public string CatalogName { get; set; }
                public string SearchName { get; set; }
                public string DbType { get; set; }
                public string EnvType { get; set; }
                public long? InstanceId { get; set; }
                public string RegionId { get; set; }
                public string InstanceResourceId { get; set; }
                public string InstanceSource { get; set; }
            }
        };

    }

}
