// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListInstancesOfUserResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public ListInstancesOfUserResponseBodyInstances Instances { get; set; }
        public class ListInstancesOfUserResponseBodyInstances : TeaModel {
            [NameInMap("CallCenterInstance")]
            [Validation(Required=false)]
            public List<ListInstancesOfUserResponseBodyInstancesCallCenterInstance> CallCenterInstance { get; set; }
            public class ListInstancesOfUserResponseBodyInstancesCallCenterInstance : TeaModel {
                public ListInstancesOfUserResponseBodyInstancesCallCenterInstanceAdmin Admin { get; set; }
                public class ListInstancesOfUserResponseBodyInstancesCallCenterInstanceAdmin : TeaModel {
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public List<ListInstancesOfUserResponseBodyInstancesCallCenterInstanceAdminUser> User { get; set; }
                    public class ListInstancesOfUserResponseBodyInstancesCallCenterInstanceAdminUser : TeaModel {
                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public ListInstancesOfUserResponseBodyInstancesCallCenterInstanceAdminUserDetail Detail { get; set; }
                        public class ListInstancesOfUserResponseBodyInstancesCallCenterInstanceAdminUserDetail : TeaModel {
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
                public string ConsoleUrl { get; set; }
                public long? CreatedTime { get; set; }
                public string DirectoryId { get; set; }
                public string DomainName { get; set; }
                public string InstanceDescription { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public int? MaxOnlineAgents { get; set; }
                public string Owner { get; set; }
                public ListInstancesOfUserResponseBodyInstancesCallCenterInstancePhoneNumbers PhoneNumbers { get; set; }
                public class ListInstancesOfUserResponseBodyInstancesCallCenterInstancePhoneNumbers : TeaModel {
                    [NameInMap("PhoneNumber")]
                    [Validation(Required=false)]
                    public List<ListInstancesOfUserResponseBodyInstancesCallCenterInstancePhoneNumbersPhoneNumber> PhoneNumber { get; set; }
                    public class ListInstancesOfUserResponseBodyInstancesCallCenterInstancePhoneNumbersPhoneNumber : TeaModel {
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
                public string Status { get; set; }
                public string StorageBucket { get; set; }
                public int? StorageMaxDays { get; set; }
                public int? StorageMaxSize { get; set; }
                public string TenantId { get; set; }
            }
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
