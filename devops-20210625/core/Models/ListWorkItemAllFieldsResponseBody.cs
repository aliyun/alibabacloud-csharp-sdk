// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListWorkItemAllFieldsResponseBody : TeaModel {
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
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<ListWorkItemAllFieldsResponseBodyFields> Fields { get; set; }
        public class ListWorkItemAllFieldsResponseBodyFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>例：date</para>
            /// </summary>
            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("defaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>字段的具体信息</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>list</para>
            /// </summary>
            [NameInMap("format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1623916393000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1623916393000</para>
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
            /// <para>false</para>
            /// </summary>
            [NameInMap("isRequired")]
            [Validation(Required=false)]
            public bool? IsRequired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isShowWhenCreate")]
            [Validation(Required=false)]
            public bool? IsShowWhenCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isSystemRequired")]
            [Validation(Required=false)]
            public bool? IsSystemRequired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("linkWithService")]
            [Validation(Required=false)]
            public string LinkWithService { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19xx7043xxxxxxx914</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>负责人</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("options")]
            [Validation(Required=false)]
            public List<ListWorkItemAllFieldsResponseBodyFieldsOptions> Options { get; set; }
            public class ListWorkItemAllFieldsResponseBodyFieldsOptions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>重复的缺陷</para>
                /// </summary>
                [NameInMap("displayValue")]
                [Validation(Required=false)]
                public string DisplayValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e8bxxxxxxxxxxxxxxxx23</para>
                /// </summary>
                [NameInMap("fieldIdentifier")]
                [Validation(Required=false)]
                public string FieldIdentifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>重复的缺陷</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>重复的缺陷</para>
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
            /// <para>例：Workitem</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NativeField</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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

    }

}
