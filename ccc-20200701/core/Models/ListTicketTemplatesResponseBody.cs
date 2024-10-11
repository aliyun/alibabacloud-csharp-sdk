// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListTicketTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTicketTemplatesResponseBodyData Data { get; set; }
        public class ListTicketTemplatesResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListTicketTemplatesResponseBodyDataList> List { get; set; }
            public class ListTicketTemplatesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AppliedVersion")]
                [Validation(Required=false)]
                public string AppliedVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>43c2671b-*****-4223-86d0-6bd187905cc8</para>
                /// </summary>
                [NameInMap("CategoryId")]
                [Validation(Required=false)]
                public string CategoryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>creator@ccc-test</para>
                /// </summary>
                [NameInMap("Editor")]
                [Validation(Required=false)]
                public string Editor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1715780670000</para>
                /// </summary>
                [NameInMap("LatestVersion")]
                [Validation(Required=false)]
                public string LatestVersion { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ProcessDefinition")]
                [Validation(Required=false)]
                public string ProcessDefinition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>b5c21219-3a1e-4bc0-92e7-da66e057d2f6</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                [NameInMap("TicketFields")]
                [Validation(Required=false)]
                public List<ListTicketTemplatesResponseBodyDataListTicketFields> TicketFields { get; set; }
                public class ListTicketTemplatesResponseBodyDataListTicketFields : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Array")]
                    [Validation(Required=false)]
                    public bool? Array { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("Attribute")]
                    [Validation(Required=false)]
                    public string Attribute { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1715780670000</para>
                    /// </summary>
                    [NameInMap("CreatedTime")]
                    [Validation(Required=false)]
                    public long? CreatedTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>creator</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>String</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Disabled")]
                    [Validation(Required=false)]
                    public bool? Disabled { get; set; }

                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DisplayOrder")]
                    [Validation(Required=false)]
                    public int? DisplayOrder { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>textbox</para>
                    /// </summary>
                    [NameInMap("EditorType")]
                    [Validation(Required=false)]
                    public string EditorType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("MaxLength")]
                    [Validation(Required=false)]
                    public int? MaxLength { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Maximum")]
                    [Validation(Required=false)]
                    public double? Maximum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinLength")]
                    [Validation(Required=false)]
                    public int? MinLength { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Minimum")]
                    [Validation(Required=false)]
                    public double? Minimum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>^</para>
                    /// </summary>
                    [NameInMap("Pattern")]
                    [Validation(Required=false)]
                    public string Pattern { get; set; }

                    [NameInMap("PatternErrorMessage")]
                    [Validation(Required=false)]
                    public string PatternErrorMessage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ReadOnly")]
                    [Validation(Required=false)]
                    public bool? ReadOnly { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("System")]
                    [Validation(Required=false)]
                    public bool? System { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1715780670000</para>
                    /// </summary>
                    [NameInMap("UpdatedTime")]
                    [Validation(Required=false)]
                    public long? UpdatedTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1715780670000</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8707EB29-BAED-4302-B999-40BA61877437</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
