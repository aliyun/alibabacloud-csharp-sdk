// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUsersInGroupResponseBody : TeaModel {
        [NameInMap("EndUsers")]
        [Validation(Required=false)]
        public List<DescribeUsersInGroupResponseBodyEndUsers> EndUsers { get; set; }
        public class DescribeUsersInGroupResponseBodyEndUsers : TeaModel {
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("EndUserEmail")]
            [Validation(Required=false)]
            public string EndUserEmail { get; set; }

            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("EndUserName")]
            [Validation(Required=false)]
            public string EndUserName { get; set; }

            [NameInMap("EndUserPhone")]
            [Validation(Required=false)]
            public string EndUserPhone { get; set; }

            [NameInMap("EndUserType")]
            [Validation(Required=false)]
            public string EndUserType { get; set; }

            [NameInMap("ExternalInfo")]
            [Validation(Required=false)]
            public DescribeUsersInGroupResponseBodyEndUsersExternalInfo ExternalInfo { get; set; }
            public class DescribeUsersInGroupResponseBodyEndUsersExternalInfo : TeaModel {
                [NameInMap("ExternalName")]
                [Validation(Required=false)]
                public string ExternalName { get; set; }

                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

            }

            [NameInMap("UserDesktopId")]
            [Validation(Required=false)]
            public string UserDesktopId { get; set; }

            [NameInMap("UserSetPropertiesModels")]
            [Validation(Required=false)]
            public List<DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModels> UserSetPropertiesModels { get; set; }
            public class DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModels : TeaModel {
                [NameInMap("PropertyId")]
                [Validation(Required=false)]
                public long? PropertyId { get; set; }

                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                [NameInMap("PropertyType")]
                [Validation(Required=false)]
                public int? PropertyType { get; set; }

                [NameInMap("PropertyValues")]
                [Validation(Required=false)]
                public List<DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModelsPropertyValues> PropertyValues { get; set; }
                public class DescribeUsersInGroupResponseBodyEndUsersUserSetPropertiesModelsPropertyValues : TeaModel {
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                    [NameInMap("PropertyValueId")]
                    [Validation(Required=false)]
                    public long? PropertyValueId { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OnlineUsersCount")]
        [Validation(Required=false)]
        public int? OnlineUsersCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsersCount")]
        [Validation(Required=false)]
        public int? UsersCount { get; set; }

    }

}
