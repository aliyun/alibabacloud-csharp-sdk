// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPInstancesUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryODPInstancesUsersResponseBodyData> Data { get; set; }
        public class QueryODPInstancesUsersResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

            [NameInMap("UserType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

            [NameInMap("PrivilegedSchemas")]
            [Validation(Required=false)]
            public List<QueryODPInstancesUsersResponseBodyDataPrivilegedSchemas> PrivilegedSchemas { get; set; }
            public class QueryODPInstancesUsersResponseBodyDataPrivilegedSchemas : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("Privilege")]
                [Validation(Required=false)]
                public string Privilege { get; set; }

                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

        }

    }

}
