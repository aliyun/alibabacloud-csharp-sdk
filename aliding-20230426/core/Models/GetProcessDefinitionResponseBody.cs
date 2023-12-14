// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetProcessDefinitionResponseBody : TeaModel {
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetProcessDefinitionResponseBodyOriginator Originator { get; set; }
        public class GetProcessDefinitionResponseBodyOriginator : TeaModel {
            [NameInMap("DepartmentDescription")]
            [Validation(Required=false)]
            public string DepartmentDescription { get; set; }

            [NameInMap("DisplayEnName")]
            [Validation(Required=false)]
            public string DisplayEnName { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("MasterDataDepartments")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments> MasterDataDepartments { get; set; }
            public class GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments : TeaModel {
                [NameInMap("DeptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("DeptNameInEnglish")]
                [Validation(Required=false)]
                public string DeptNameInEnglish { get; set; }

                [NameInMap("DeptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

                [NameInMap("DeptPath")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

                [NameInMap("HumanSourceGroupOrderNumber")]
                [Validation(Required=false)]
                public string HumanSourceGroupOrderNumber { get; set; }

                [NameInMap("HumanSourceGroupWorkNo")]
                [Validation(Required=false)]
                public string HumanSourceGroupWorkNo { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("MasterWorkNo")]
                [Validation(Required=false)]
                public string MasterWorkNo { get; set; }

            }

            [NameInMap("OrderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }

            [NameInMap("PersonalPhoto")]
            [Validation(Required=false)]
            public string PersonalPhoto { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TbWang")]
            [Validation(Required=false)]
            public string TbWang { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

        [NameInMap("outResult")]
        [Validation(Required=false)]
        public string OutResult { get; set; }

        [NameInMap("owners")]
        [Validation(Required=false)]
        public List<GetProcessDefinitionResponseBodyOwners> Owners { get; set; }
        public class GetProcessDefinitionResponseBodyOwners : TeaModel {
            [NameInMap("DepartmentDescription")]
            [Validation(Required=false)]
            public string DepartmentDescription { get; set; }

            [NameInMap("DisplayEnName")]
            [Validation(Required=false)]
            public string DisplayEnName { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("MasterDataDepartments")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyOwnersMasterDataDepartments> MasterDataDepartments { get; set; }
            public class GetProcessDefinitionResponseBodyOwnersMasterDataDepartments : TeaModel {
                [NameInMap("DeptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                [NameInMap("DeptNameInEnglish")]
                [Validation(Required=false)]
                public string DeptNameInEnglish { get; set; }

                [NameInMap("DeptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

                [NameInMap("DeptPath")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

                [NameInMap("HumanSourceGroupOrderNumber")]
                [Validation(Required=false)]
                public string HumanSourceGroupOrderNumber { get; set; }

                [NameInMap("HumanSourceGroupWorkNo")]
                [Validation(Required=false)]
                public string HumanSourceGroupWorkNo { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("MasterWorkNo")]
                [Validation(Required=false)]
                public string MasterWorkNo { get; set; }

            }

            [NameInMap("OrderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }

            [NameInMap("PersonalPhoto")]
            [Validation(Required=false)]
            public string PersonalPhoto { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TbWang")]
            [Validation(Required=false)]
            public string TbWang { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

        [NameInMap("processId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<GetProcessDefinitionResponseBodyTasks> Tasks { get; set; }
        public class GetProcessDefinitionResponseBodyTasks : TeaModel {
            [NameInMap("ActionerId")]
            [Validation(Required=false)]
            public string ActionerId { get; set; }

            [NameInMap("Activity")]
            [Validation(Required=false)]
            public GetProcessDefinitionResponseBodyTasksActivity Activity { get; set; }
            public class GetProcessDefinitionResponseBodyTasksActivity : TeaModel {
                [NameInMap("ActivityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("ActivityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                [NameInMap("ActivityNameInEnglish")]
                [Validation(Required=false)]
                public string ActivityNameInEnglish { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
