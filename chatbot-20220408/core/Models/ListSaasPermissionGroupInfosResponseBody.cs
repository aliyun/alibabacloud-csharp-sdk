// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSaasPermissionGroupInfosResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListSaasPermissionGroupInfosResponseBodyData> Data { get; set; }
        public class ListSaasPermissionGroupInfosResponseBodyData : TeaModel {
            [NameInMap("EnName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PgInfos")]
            [Validation(Required=false)]
            public List<ListSaasPermissionGroupInfosResponseBodyDataPgInfos> PgInfos { get; set; }
            public class ListSaasPermissionGroupInfosResponseBodyDataPgInfos : TeaModel {
                [NameInMap("PgCode")]
                [Validation(Required=false)]
                public string PgCode { get; set; }

                [NameInMap("PgEnName")]
                [Validation(Required=false)]
                public string PgEnName { get; set; }

                [NameInMap("PgName")]
                [Validation(Required=false)]
                public string PgName { get; set; }

            }

            [NameInMap("SaasCode")]
            [Validation(Required=false)]
            public string SaasCode { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
