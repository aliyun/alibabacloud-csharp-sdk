// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableTopologyResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TableTopology")]
        [Validation(Required=false)]
        public GetTableTopologyResponseBodyTableTopology TableTopology { get; set; }
        public class GetTableTopologyResponseBodyTableTopology : TeaModel {
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }
            [NameInMap("TableTopologyInfoList")]
            [Validation(Required=false)]
            public List<GetTableTopologyResponseBodyTableTopologyTableTopologyInfoList> TableTopologyInfoList { get; set; }
            public class GetTableTopologyResponseBodyTableTopologyTableTopologyInfoList : TeaModel {
                public long? DbId { get; set; }
                public string DbName { get; set; }
                public string DbSearchName { get; set; }
                public string DbType { get; set; }
                public long? InstanceId { get; set; }
                public string InstanceResourceId { get; set; }
                public string InstanceSource { get; set; }
                public string RegionId { get; set; }
                public long? TableCount { get; set; }
                public string TableNameExpr { get; set; }
                public string TableNameList { get; set; }
            }
        };

    }

}
