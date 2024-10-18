// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetMeCorpSubmissionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetMeCorpSubmissionResponseBodyData> Data { get; set; }
        public class GetMeCorpSubmissionResponseBodyData : TeaModel {
            [NameInMap("Actioner")]
            [Validation(Required=false)]
            public List<GetMeCorpSubmissionResponseBodyDataActioner> Actioner { get; set; }
            public class GetMeCorpSubmissionResponseBodyDataActioner : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>某研究部</para>
                /// </summary>
                [NameInMap("BuName")]
                [Validation(Required=false)]
                public string BuName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:abc@alimail.com">abc@alimail.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>正式</para>
                /// </summary>
                [NameInMap("EmployeeType")]
                [Validation(Required=false)]
                public string EmployeeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>official</para>
                /// </summary>
                [NameInMap("EmployeeTypeInformation")]
                [Validation(Required=false)]
                public string EmployeeTypeInformation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123311221</para>
                /// </summary>
                [NameInMap("HumanResourceGroupWorkNumber")]
                [Validation(Required=false)]
                public string HumanResourceGroupWorkNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSystemAdmin")]
                [Validation(Required=false)]
                public bool? IsSystemAdmin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>P7</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>请购单</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>与心</para>
                /// </summary>
                [NameInMap("NickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

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
                /// <para><a href="https://oss/zhangsan.png">https://oss/zhangsan.png</a></para>
                /// </summary>
                [NameInMap("PersonalPhotoUrl")]
                [Validation(Required=false)]
                public string PersonalPhotoUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>XIAOHONG</para>
                /// </summary>
                [NameInMap("PinyinNameAll")]
                [Validation(Required=false)]
                public string PinyinNameAll { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xiaohong</para>
                /// </summary>
                [NameInMap("PinyinNickName")]
                [Validation(Required=false)]
                public string PinyinNickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager123</para>
                /// </summary>
                [NameInMap("SuperUserId")]
                [Validation(Required=false)]
                public string SuperUserId { get; set; }

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

            }

            [NameInMap("ActionerId")]
            [Validation(Required=false)]
            public List<string> ActionerId { get; set; }

            [NameInMap("ActionerName")]
            [Validation(Required=false)]
            public List<string> ActionerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>APP_PBKT0xxx</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01</para>
            /// </summary>
            [NameInMap("CreateTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("CurrentActivityInstances")]
            [Validation(Required=false)]
            public List<GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances> CurrentActivityInstances { get; set; }
            public class GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances : TeaModel {
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
                [NameInMap("ActivityNameEn")]
                [Validation(Required=false)]
                public string ActivityNameEn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("DataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> DataMap { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>edit</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01</para>
            /// </summary>
            [NameInMap("FinishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FINST-NJYJxxx</para>
            /// </summary>
            [NameInMap("FormInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-EF6xxx</para>
            /// </summary>
            [NameInMap("FormUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>符合宜搭表单实例格式的json数据</para>
            /// </summary>
            [NameInMap("InstanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-01-01</para>
            /// </summary>
            [NameInMap("ModifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>zhangsan@mediaId</para>
            /// </summary>
            [NameInMap("OriginatorAvatar")]
            [Validation(Required=false)]
            public string OriginatorAvatar { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("OriginatorDisplayName")]
            [Validation(Required=false)]
            public string OriginatorDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager123</para>
            /// </summary>
            [NameInMap("OriginatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("ProcessApprovedResult")]
            [Validation(Required=false)]
            public string ProcessApprovedResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>通过</para>
            /// </summary>
            [NameInMap("ProcessApprovedResultText")]
            [Validation(Required=false)]
            public string ProcessApprovedResultText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TPROC--X1Gxxx</para>
            /// </summary>
            [NameInMap("ProcessCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>52330</para>
            /// </summary>
            [NameInMap("ProcessId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>f30233fb-72e1-xxx</para>
            /// </summary>
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>finished</para>
            /// </summary>
            [NameInMap("ProcessInstanceStatus")]
            [Validation(Required=false)]
            public string ProcessInstanceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>已同意</para>
            /// </summary>
            [NameInMap("ProcessInstanceStatusText")]
            [Validation(Required=false)]
            public string ProcessInstanceStatusText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小红的单子</para>
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小红发起的请购单</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

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
