// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkItemInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("workitem")]
        [Validation(Required=false)]
        public GetWorkItemInfoResponseBodyWorkitem Workitem { get; set; }
        public class GetWorkItemInfoResponseBodyWorkitem : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("assignedTo")]
            [Validation(Required=false)]
            public string AssignedTo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Req</para>
            /// </summary>
            [NameInMap("categoryIdentifier")]
            [Validation(Required=false)]
            public string CategoryIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<GetWorkItemInfoResponseBodyWorkitemCustomFields> CustomFields { get; set; }
            public class GetWorkItemInfoResponseBodyWorkitemCustomFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>例如：date</para>
                /// </summary>
                [NameInMap("fieldClassName")]
                [Validation(Required=false)]
                public string FieldClassName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>例：input</para>
                /// </summary>
                [NameInMap("fieldFormat")]
                [Validation(Required=false)]
                public string FieldFormat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>例：80</para>
                /// </summary>
                [NameInMap("fieldIdentifier")]
                [Validation(Required=false)]
                public string FieldIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public long? Level { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("objectValue")]
                [Validation(Required=false)]
                public string ObjectValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>例：2022-01-06 00:00:00</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("valueList")]
                [Validation(Required=false)]
                public List<GetWorkItemInfoResponseBodyWorkitemCustomFieldsValueList> ValueList { get; set; }
                public class GetWorkItemInfoResponseBodyWorkitemCustomFieldsValueList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-02-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("displayValue")]
                    [Validation(Required=false)]
                    public string DisplayValue { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-02-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("identifier")]
                    [Validation(Required=false)]
                    public string Identifier { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public long? Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-02-01 00:00:00</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>null</para>
                    /// </summary>
                    [NameInMap("valueEn")]
                    [Validation(Required=false)]
                    public string ValueEn { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5daa9a15c7fd55523996......</para>
                /// </summary>
                [NameInMap("workitemIdentifier")]
                [Validation(Required=false)]
                public string WorkitemIdentifier { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>html格式</para>
            /// </summary>
            [NameInMap("document")]
            [Validation(Required=false)]
            public string Document { get; set; }

            [NameInMap("documentFormat")]
            [Validation(Required=false)]
            public string DocumentFormat { get; set; }

            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640850318000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640850318000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e8bxxxxxxxxxxxxxxxx23</para>
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("logicalStatus")]
            [Validation(Required=false)]
            public string LogicalStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e8bxxxxxxxxxxxxxxxx24</para>
            /// </summary>
            [NameInMap("parentIdentifier")]
            [Validation(Required=false)]
            public string ParentIdentifier { get; set; }

            [NameInMap("participant")]
            [Validation(Required=false)]
            public List<string> Participant { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ABCD-1</para>
            /// </summary>
            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e8b26xxxxx6e76aa20xxxxx23</para>
            /// </summary>
            [NameInMap("spaceIdentifier")]
            [Validation(Required=false)]
            public string SpaceIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>需求项目</para>
            /// </summary>
            [NameInMap("spaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Project</para>
            /// </summary>
            [NameInMap("spaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            [NameInMap("sprint")]
            [Validation(Required=false)]
            public List<string> Sprint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>待处理</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>例：100005</para>
            /// </summary>
            [NameInMap("statusIdentifier")]
            [Validation(Required=false)]
            public string StatusIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("statusStageIdentifier")]
            [Validation(Required=false)]
            public string StatusStageIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试工作项</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            [NameInMap("tag")]
            [Validation(Required=false)]
            public List<string> Tag { get; set; }

            [NameInMap("tagDetails")]
            [Validation(Required=false)]
            public List<GetWorkItemInfoResponseBodyWorkitemTagDetails> TagDetails { get; set; }
            public class GetWorkItemInfoResponseBodyWorkitemTagDetails : TeaModel {
                [NameInMap("color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("tracker")]
            [Validation(Required=false)]
            public List<string> Tracker { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1640850328000</para>
            /// </summary>
            [NameInMap("updateStatusAt")]
            [Validation(Required=false)]
            public long? UpdateStatusAt { get; set; }

            [NameInMap("verifier")]
            [Validation(Required=false)]
            public List<string> Verifier { get; set; }

            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<GetWorkItemInfoResponseBodyWorkitemVersions> Versions { get; set; }
            public class GetWorkItemInfoResponseBodyWorkitemVersions : TeaModel {
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9uxxxxxxre573f5xxxxxx0</para>
            /// </summary>
            [NameInMap("workitemTypeIdentifier")]
            [Validation(Required=false)]
            public string WorkitemTypeIdentifier { get; set; }

        }

    }

}
