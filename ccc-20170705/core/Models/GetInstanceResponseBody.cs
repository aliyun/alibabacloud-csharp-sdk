// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("StorageMaxSize")]
            [Validation(Required=false)]
            public int? StorageMaxSize { get; set; }
            [NameInMap("StorageMaxDays")]
            [Validation(Required=false)]
            public int? StorageMaxDays { get; set; }
            [NameInMap("MaxOnlineAgents")]
            [Validation(Required=false)]
            public int? MaxOnlineAgents { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }
            [NameInMap("PhoneNumbers")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstancePhoneNumbers PhoneNumbers { get; set; }
            public class GetInstanceResponseBodyInstancePhoneNumbers : TeaModel {
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public List<GetInstanceResponseBodyInstancePhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                public class GetInstanceResponseBodyInstancePhoneNumbersPhoneNumber : TeaModel {
                    [NameInMap("TestOnly")]
                    [Validation(Required=false)]
                    public bool? TestOnly { get; set; }

                    [NameInMap("Trunks")]
                    [Validation(Required=false)]
                    public int? Trunks { get; set; }

                    [NameInMap("RemainingTime")]
                    [Validation(Required=false)]
                    public int? RemainingTime { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                    [NameInMap("AllowOutbound")]
                    [Validation(Required=false)]
                    public bool? AllowOutbound { get; set; }

                    [NameInMap("PhoneNumberDescription")]
                    [Validation(Required=false)]
                    public string PhoneNumberDescription { get; set; }

                    [NameInMap("PhoneNumberId")]
                    [Validation(Required=false)]
                    public string PhoneNumberId { get; set; }

                }

            }
            [NameInMap("ConsoleUrl")]
            [Validation(Required=false)]
            public string ConsoleUrl { get; set; }
            [NameInMap("StorageBucket")]
            [Validation(Required=false)]
            public string StorageBucket { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }
            [NameInMap("Admin")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceAdmin Admin { get; set; }
            public class GetInstanceResponseBodyInstanceAdmin : TeaModel {
                [NameInMap("User")]
                [Validation(Required=false)]
                public List<GetInstanceResponseBodyInstanceAdminUser> User { get; set; }
                public class GetInstanceResponseBodyInstanceAdminUser : TeaModel {
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("RamId")]
                    [Validation(Required=false)]
                    public string RamId { get; set; }

                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public GetInstanceResponseBodyInstanceAdminUserDetail Detail { get; set; }
                    public class GetInstanceResponseBodyInstanceAdminUserDetail : TeaModel {
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }
                        [NameInMap("Email")]
                        [Validation(Required=false)]
                        public string Email { get; set; }
                        [NameInMap("LoginName")]
                        [Validation(Required=false)]
                        public string LoginName { get; set; }
                        [NameInMap("Department")]
                        [Validation(Required=false)]
                        public string Department { get; set; }
                        [NameInMap("Phone")]
                        [Validation(Required=false)]
                        public string Phone { get; set; }
                    };

                }

            }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
