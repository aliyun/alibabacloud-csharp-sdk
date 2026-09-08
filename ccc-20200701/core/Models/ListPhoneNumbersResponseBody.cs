// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListPhoneNumbersResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPhoneNumbersResponseBodyData Data { get; set; }
        public class ListPhoneNumbersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The phone number list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListPhoneNumbersResponseBodyDataList> List { get; set; }
            public class ListPhoneNumbersResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the number is active.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public bool? Active { get; set; }

                /// <summary>
                /// <para>The city where the number is registered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>乐山</para>
                /// </summary>
                [NameInMap("City")]
                [Validation(Required=false)]
                public string City { get; set; }

                /// <summary>
                /// <para>The IVR contact flow ID associated with the phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a3fb6c62-9b49-4942-ae5b-cf2abd4123ek</para>
                /// </summary>
                [NameInMap("ContactFlowId")]
                [Validation(Required=false)]
                public string ContactFlowId { get; set; }

                /// <summary>
                /// <para>Name of the IVR contact flow associated with the number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>默认联系流</para>
                /// </summary>
                [NameInMap("ContactFlowName")]
                [Validation(Required=false)]
                public string ContactFlowName { get; set; }

                /// <summary>
                /// <para>The number creation time, which is the time when the number was associated with the instance, in Unix timestamp format with millisecond precision.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1617958538000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>08330011****</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>Number provider name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alicom</para>
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

                /// <summary>
                /// <para>The province where the number is registered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>四川</para>
                /// </summary>
                [NameInMap("Province")]
                [Validation(Required=false)]
                public string Province { get; set; }

                /// <summary>
                /// <para>The list of skill groups associated with the number.</para>
                /// </summary>
                [NameInMap("SkillGroups")]
                [Validation(Required=false)]
                public List<ListPhoneNumbersResponseBodyDataListSkillGroups> SkillGroups { get; set; }
                public class ListPhoneNumbersResponseBodyDataListSkillGroups : TeaModel {
                    /// <summary>
                    /// <para>The display name of the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>测试技能组</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ccc-test</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The name of the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skillgroup</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The skill group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skillgroup@ccc-test</para>
                    /// </summary>
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                }

                /// <summary>
                /// <para>Business tags for the number, primarily used for labeling and extended business purposes. Ordinary customers do not need to concern themselves with this.</para>
                /// 
                /// <b>Example:</b>
                /// <para>M1</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The usage of the phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bidirection</para>
                /// </summary>
                [NameInMap("Usage")]
                [Validation(Required=false)]
                public string Usage { get; set; }

                /// <summary>
                /// <para>Agent ID. If this parameter is not empty, the number is dedicated to the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent@ccc-test</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The page number, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA03159C-E808-4FF1-B27E-A61B6E888D7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
