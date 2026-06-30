// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetQualityCheckSchemeResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code. A value of 200 indicates success. Other values indicate failure. Use this code to determine the cause of a failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The QualityCheckScheme object. This is the JSON object of the quality check plan. For more information, see <a href="https://help.aliyun.com/document_detail/453292.html"><c>Description of quality check task objects</c></a>.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetQualityCheckSchemeResponseBodyData Data { get; set; }
        public class GetQualityCheckSchemeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616113198000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The username of the creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            /// <summary>
            /// <para>The data type of the quality check plan. Valid values: 0 (text) and 1 (audio).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public int? DataType { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>售前使用</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The total score of the quality check plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InitScore")]
            [Validation(Required=false)]
            public string InitScore { get; set; }

            /// <summary>
            /// <para>The name of the quality check plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of associated rule IDs.</para>
            /// </summary>
            [NameInMap("RuleIds")]
            [Validation(Required=false)]
            public List<string> RuleIds { get; set; }

            /// <summary>
            /// <para>The list of rules.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<RulesInfo> RuleList { get; set; }

            /// <summary>
            /// <para>The list of quality check dimensions.</para>
            /// </summary>
            [NameInMap("SchemeCheckTypeList")]
            [Validation(Required=false)]
            public List<GetQualityCheckSchemeResponseBodyDataSchemeCheckTypeList> SchemeCheckTypeList { get; set; }
            public class GetQualityCheckSchemeResponseBodyDataSchemeCheckTypeList : TeaModel {
                /// <summary>
                /// <para>The name of the quality check dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>服务规范性检测</para>
                /// </summary>
                [NameInMap("CheckName")]
                [Validation(Required=false)]
                public string CheckName { get; set; }

                /// <summary>
                /// <para>The ID of the quality check dimension type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CheckType")]
                [Validation(Required=false)]
                public long? CheckType { get; set; }

                /// <summary>
                /// <para>The status. Valid values: 0 (disabled) and 1 (enabled).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public int? Enable { get; set; }

                /// <summary>
                /// <para>The quality check plan ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("SchemeId")]
                [Validation(Required=false)]
                public long? SchemeId { get; set; }

                /// <summary>
                /// <para>The score of the quality check dimension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public int? Score { get; set; }

                /// <summary>
                /// <para>The original score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("SourceScore")]
                [Validation(Required=false)]
                public int? SourceScore { get; set; }

            }

            /// <summary>
            /// <para>The quality check plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112**</para>
            /// </summary>
            [NameInMap("SchemeId")]
            [Validation(Required=false)]
            public long? SchemeId { get; set; }

            /// <summary>
            /// <para>The quality check plan template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SchemeTemplateId")]
            [Validation(Required=false)]
            public long? SchemeTemplateId { get; set; }

            /// <summary>
            /// <para>The status. Valid values: 0 (deleted), 1 (published), 2 (unpublished), and 3 (updated but not published). Default value: 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The type of the quality check plan template. Valid values: 1 (system-built) and 2 (custom).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public int? TemplateType { get; set; }

            /// <summary>
            /// <para>The type of the quality check plan. Valid values: 0 (system-built) and 1 (custom).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The time when the plan was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616113198000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The username of the user who last updated the plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("UpdateUserName")]
            [Validation(Required=false)]
            public string UpdateUserName { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1616113198000</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

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
        /// <para>If an error occurs, this field provides details about the error. If the request is successful, the value is <b>successful</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of returned messages.</para>
        /// </summary>
        [NameInMap("Messages")]
        [Validation(Required=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>96138D8D-8D26-4E41-BFF4-77AED1088BBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates success. A value of false or null indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
