// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class CreateInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public CreateInstanceResponseBodyInstance Instance { get; set; }
        public class CreateInstanceResponseBodyInstance : TeaModel {
            [NameInMap("Admin")]
            [Validation(Required=false)]
            public CreateInstanceResponseBodyInstanceAdmin Admin { get; set; }
            public class CreateInstanceResponseBodyInstanceAdmin : TeaModel {
                [NameInMap("User")]
                [Validation(Required=false)]
                public List<CreateInstanceResponseBodyInstanceAdminUser> User { get; set; }
                public class CreateInstanceResponseBodyInstanceAdminUser : TeaModel {
                    [NameInMap("Detail")]
                    [Validation(Required=false)]
                    public CreateInstanceResponseBodyInstanceAdminUserDetail Detail { get; set; }
                    public class CreateInstanceResponseBodyInstanceAdminUserDetail : TeaModel {
                        [NameInMap("Department")]
                        [Validation(Required=false)]
                        public string Department { get; set; }
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }
                        [NameInMap("Email")]
                        [Validation(Required=false)]
                        public string Email { get; set; }
                        [NameInMap("LoginName")]
                        [Validation(Required=false)]
                        public string LoginName { get; set; }
                        [NameInMap("Phone")]
                        [Validation(Required=false)]
                        public string Phone { get; set; }
                    };

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("RamId")]
                    [Validation(Required=false)]
                    public string RamId { get; set; }

                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

            }
            [NameInMap("ConsoleUrl")]
            [Validation(Required=false)]
            public string ConsoleUrl { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("FailLoginNames")]
            [Validation(Required=false)]
            public CreateInstanceResponseBodyInstanceFailLoginNames FailLoginNames { get; set; }
            public class CreateInstanceResponseBodyInstanceFailLoginNames : TeaModel {
                [NameInMap("FailLoginName")]
                [Validation(Required=false)]
                public List<string> FailLoginName { get; set; }

            }
            [NameInMap("FailPhoneNumbers")]
            [Validation(Required=false)]
            public CreateInstanceResponseBodyInstanceFailPhoneNumbers FailPhoneNumbers { get; set; }
            public class CreateInstanceResponseBodyInstanceFailPhoneNumbers : TeaModel {
                [NameInMap("FailPhoneNumber")]
                [Validation(Required=false)]
                public List<string> FailPhoneNumber { get; set; }

            }
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }
            [NameInMap("MaxOnlineAgents")]
            [Validation(Required=false)]
            public int? MaxOnlineAgents { get; set; }
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }
            [NameInMap("PhoneNumbers")]
            [Validation(Required=false)]
            public CreateInstanceResponseBodyInstancePhoneNumbers PhoneNumbers { get; set; }
            public class CreateInstanceResponseBodyInstancePhoneNumbers : TeaModel {
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public List<CreateInstanceResponseBodyInstancePhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                public class CreateInstanceResponseBodyInstancePhoneNumbersPhoneNumber : TeaModel {
                    [NameInMap("AllowOutbound")]
                    [Validation(Required=false)]
                    public bool? AllowOutbound { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Number")]
                    [Validation(Required=false)]
                    public string Number { get; set; }

                    [NameInMap("PhoneNumberDescription")]
                    [Validation(Required=false)]
                    public string PhoneNumberDescription { get; set; }

                    [NameInMap("PhoneNumberId")]
                    [Validation(Required=false)]
                    public string PhoneNumberId { get; set; }

                    [NameInMap("RemainingTime")]
                    [Validation(Required=false)]
                    public int? RemainingTime { get; set; }

                    [NameInMap("TestOnly")]
                    [Validation(Required=false)]
                    public bool? TestOnly { get; set; }

                    [NameInMap("Trunks")]
                    [Validation(Required=false)]
                    public int? Trunks { get; set; }

                    [NameInMap("Usage")]
                    [Validation(Required=false)]
                    public string Usage { get; set; }

                }

            }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StorageBucket")]
            [Validation(Required=false)]
            public string StorageBucket { get; set; }
            [NameInMap("StorageMaxDays")]
            [Validation(Required=false)]
            public int? StorageMaxDays { get; set; }
            [NameInMap("StorageMaxSize")]
            [Validation(Required=false)]
            public int? StorageMaxSize { get; set; }
            [NameInMap("SuccessLoginNames")]
            [Validation(Required=false)]
            public CreateInstanceResponseBodyInstanceSuccessLoginNames SuccessLoginNames { get; set; }
            public class CreateInstanceResponseBodyInstanceSuccessLoginNames : TeaModel {
                [NameInMap("SuccessLoginName")]
                [Validation(Required=false)]
                public List<string> SuccessLoginName { get; set; }

            }
            [NameInMap("SuccessPhoneNumbers")]
            [Validation(Required=false)]
            public CreateInstanceResponseBodyInstanceSuccessPhoneNumbers SuccessPhoneNumbers { get; set; }
            public class CreateInstanceResponseBodyInstanceSuccessPhoneNumbers : TeaModel {
                [NameInMap("SuccessPhoneNumber")]
                [Validation(Required=false)]
                public List<string> SuccessPhoneNumber { get; set; }

            }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
