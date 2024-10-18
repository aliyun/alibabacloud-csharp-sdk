// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetProcessDefinitionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>FORM-EF6Y4xxx</para>
        /// </summary>
        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        [NameInMap("originator")]
        [Validation(Required=false)]
        public GetProcessDefinitionResponseBodyOriginator Originator { get; set; }
        public class GetProcessDefinitionResponseBodyOriginator : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>开发部成立于2000年</para>
            /// </summary>
            [NameInMap("DepartmentDescription")]
            [Validation(Required=false)]
            public string DepartmentDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZhangSan</para>
            /// </summary>
            [NameInMap("DisplayEnName")]
            [Validation(Required=false)]
            public string DisplayEnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试应用</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("MasterDataDepartments")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments> MasterDataDepartments { get; set; }
            public class GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>开发部</para>
                /// </summary>
                [NameInMap("DeptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>development department</para>
                /// </summary>
                [NameInMap("DeptNameInEnglish")]
                [Validation(Required=false)]
                public string DeptNameInEnglish { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>develop-A</para>
                /// </summary>
                [NameInMap("DeptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>总部-开发部</para>
                /// </summary>
                [NameInMap("DeptPath")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxafafaf</para>
                /// </summary>
                [NameInMap("HumanSourceGroupOrderNumber")]
                [Validation(Required=false)]
                public string HumanSourceGroupOrderNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123311221</para>
                /// </summary>
                [NameInMap("HumanSourceGroupWorkNo")]
                [Validation(Required=false)]
                public string HumanSourceGroupWorkNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1732245789</para>
                /// </summary>
                [NameInMap("MasterWorkNo")]
                [Validation(Required=false)]
                public string MasterWorkNo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>o-YDJKINSxxx</para>
            /// </summary>
            [NameInMap("OrderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://abc.com/a.png">https://abc.com/a.png</a></para>
            /// </summary>
            [NameInMap("PersonalPhoto")]
            [Validation(Required=false)]
            public string PersonalPhoto { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wang123</para>
            /// </summary>
            [NameInMap("TbWang")]
            [Validation(Required=false)]
            public string TbWang { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agree</para>
        /// </summary>
        [NameInMap("outResult")]
        [Validation(Required=false)]
        public string OutResult { get; set; }

        [NameInMap("owners")]
        [Validation(Required=false)]
        public List<GetProcessDefinitionResponseBodyOwners> Owners { get; set; }
        public class GetProcessDefinitionResponseBodyOwners : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>开发部成立于2000年</para>
            /// </summary>
            [NameInMap("DepartmentDescription")]
            [Validation(Required=false)]
            public string DepartmentDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ZhangSan</para>
            /// </summary>
            [NameInMap("DisplayEnName")]
            [Validation(Required=false)]
            public string DisplayEnName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试应用</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("MasterDataDepartments")]
            [Validation(Required=false)]
            public List<GetProcessDefinitionResponseBodyOwnersMasterDataDepartments> MasterDataDepartments { get; set; }
            public class GetProcessDefinitionResponseBodyOwnersMasterDataDepartments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>开发部</para>
                /// </summary>
                [NameInMap("DeptName")]
                [Validation(Required=false)]
                public string DeptName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>development department</para>
                /// </summary>
                [NameInMap("DeptNameInEnglish")]
                [Validation(Required=false)]
                public string DeptNameInEnglish { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>develop-A</para>
                /// </summary>
                [NameInMap("DeptNo")]
                [Validation(Required=false)]
                public string DeptNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>总部-开发部</para>
                /// </summary>
                [NameInMap("DeptPath")]
                [Validation(Required=false)]
                public string DeptPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxafafaf</para>
                /// </summary>
                [NameInMap("HumanSourceGroupOrderNumber")]
                [Validation(Required=false)]
                public string HumanSourceGroupOrderNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123311221</para>
                /// </summary>
                [NameInMap("HumanSourceGroupWorkNo")]
                [Validation(Required=false)]
                public string HumanSourceGroupWorkNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1732245789</para>
                /// </summary>
                [NameInMap("MasterWorkNo")]
                [Validation(Required=false)]
                public string MasterWorkNo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>o-YDJKINSxxx</para>
            /// </summary>
            [NameInMap("OrderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://abc.com/a.png">https://abc.com/a.png</a></para>
            /// </summary>
            [NameInMap("PersonalPhoto")]
            [Validation(Required=false)]
            public string PersonalPhoto { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>wang123</para>
            /// </summary>
            [NameInMap("TbWang")]
            [Validation(Required=false)]
            public string TbWang { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public string UserInfo { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>proc-123</para>
        /// </summary>
        [NameInMap("processId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f30233fb-72e1-4xxx</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<GetProcessDefinitionResponseBodyTasks> Tasks { get; set; }
        public class GetProcessDefinitionResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("ActionerId")]
            [Validation(Required=false)]
            public string ActionerId { get; set; }

            [NameInMap("Activity")]
            [Validation(Required=false)]
            public GetProcessDefinitionResponseBodyTasksActivity Activity { get; set; }
            public class GetProcessDefinitionResponseBodyTasksActivity : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>act-xxaanfaf</para>
                /// </summary>
                [NameInMap("ActivityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("ActivityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>activity-124</para>
                /// </summary>
                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>redirect task</para>
                /// </summary>
                [NameInMap("ActivityNameInEnglish")]
                [Validation(Required=false)]
                public string ActivityNameInEnglish { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>792</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>李四发起的请购单</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
