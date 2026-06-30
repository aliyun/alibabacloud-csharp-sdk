// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetSchemeTaskConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Result code. <b>200</b> means success.</para>
        /// <remarks>
        /// <para>Any other value means failure. The caller can use this field to identify the cause.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data. See the additional notes below.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSchemeTaskConfigResponseBodyData Data { get; set; }
        public class GetSchemeTaskConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Task priority:</para>
            /// <list type="bullet">
            /// <item><description><para>0 (low)</para>
            /// </description></item>
            /// <item><description><para>1 (medium)</para>
            /// </description></item>
            /// <item><description><para>2 (high)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AsrTaskPriority")]
            [Validation(Required=false)]
            public int? AsrTaskPriority { get; set; }

            /// <summary>
            /// <para>Assignment type</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AssignType")]
            [Validation(Required=false)]
            public int? AssignType { get; set; }

            /// <summary>
            /// <para>Data configuration</para>
            /// </summary>
            [NameInMap("DataConfig")]
            [Validation(Required=false)]
            public GetSchemeTaskConfigResponseBodyDataDataConfig DataConfig { get; set; }
            public class GetSchemeTaskConfigResponseBodyDataDataConfig : TeaModel {
                /// <summary>
                /// <para>Data screening items for on-the-fly recording</para>
                /// </summary>
                [NameInMap("AssignConfigs")]
                [Validation(Required=false)]
                public List<GetSchemeTaskConfigResponseBodyDataDataConfigAssignConfigs> AssignConfigs { get; set; }
                public class GetSchemeTaskConfigResponseBodyDataDataConfigAssignConfigs : TeaModel {
                    /// <summary>
                    /// <para>Parameter matching configurations for on-the-fly recording</para>
                    /// </summary>
                    [NameInMap("AssignConfigContests")]
                    [Validation(Required=false)]
                    public List<GetSchemeTaskConfigResponseBodyDataDataConfigAssignConfigsAssignConfigContests> AssignConfigContests { get; set; }
                    public class GetSchemeTaskConfigResponseBodyDataDataConfigAssignConfigsAssignConfigContests : TeaModel {
                        /// <summary>
                        /// <para>Type of the value</para>
                        /// <list type="bullet">
                        /// <item><description><para>0: String</para>
                        /// </description></item>
                        /// <item><description><para>1: Number</para>
                        /// </description></item>
                        /// <item><description><para>2: List (use list type for all parameter values when using =)</para>
                        /// </description></item>
                        /// <item><description><para>3: Date</para>
                        /// </description></item>
                        /// <item><description><para>4: List_Json</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public int? DataType { get; set; }

                        /// <summary>
                        /// <para>List of on-the-fly recording data</para>
                        /// </summary>
                        [NameInMap("ListObject")]
                        [Validation(Required=false)]
                        public List<object> ListObject { get; set; }

                        /// <summary>
                        /// <para>Check item name</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>callStartTime</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Operator</para>
                        /// <list type="bullet">
                        /// <item><description><para>1: ==</para>
                        /// </description></item>
                        /// <item><description><para>2: &gt;</para>
                        /// </description></item>
                        /// <item><description><para>3: &lt;</para>
                        /// </description></item>
                        /// <item><description><para>4: range</para>
                        /// </description></item>
                        /// <item><description><para>5: &gt;=</para>
                        /// </description></item>
                        /// <item><description><para>6: &lt;=</para>
                        /// </description></item>
                        /// <item><description><para>7: !=</para>
                        /// </description></item>
                        /// <item><description><para>8: null</para>
                        /// </description></item>
                        /// <item><description><para>9: not null</para>
                        /// </description></item>
                        /// <item><description><para>10: contains</para>
                        /// </description></item>
                        /// <item><description><para>11: does not contain</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Symbol")]
                        [Validation(Required=false)]
                        public int? Symbol { get; set; }

                        /// <summary>
                        /// <para>Matching value for on-the-fly recording data</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{\&quot;start\&quot;:\&quot;2022-09-01 00:00:00\&quot;,\&quot;end\&quot;:\&quot;2022-09-30 00:00:00\&quot;}</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>Dataset task. Manage datasets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("DataSets")]
                [Validation(Required=false)]
                public string DataSets { get; set; }

                /// <summary>
                /// <para>Index number</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// <para>JSON text for filtering conditions used in secondary quality inspection. For details, see the request parameters of the GetResult API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ResultParam")]
                [Validation(Required=false)]
                public string ResultParam { get; set; }

            }

            /// <summary>
            /// <para>Quality inspection task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Manual review</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ManualReview")]
            [Validation(Required=false)]
            public int? ManualReview { get; set; }

            /// <summary>
            /// <para>Language model ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cdae396590b*****ec40f3476e274fc</para>
            /// </summary>
            [NameInMap("ModeCustomizationId")]
            [Validation(Required=false)]
            public string ModeCustomizationId { get; set; }

            /// <summary>
            /// <para>Language model name</para>
            /// 
            /// <b>Example:</b>
            /// <para>自定义模型</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>Quality inspection task name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Quality inspection scheme IDs</para>
            /// </summary>
            [NameInMap("SchemeIdList")]
            [Validation(Required=false)]
            public List<long?> SchemeIdList { get; set; }

            /// <summary>
            /// <para>Quality inspection schemes</para>
            /// </summary>
            [NameInMap("SchemeList")]
            [Validation(Required=false)]
            public List<GetSchemeTaskConfigResponseBodyDataSchemeList> SchemeList { get; set; }
            public class GetSchemeTaskConfigResponseBodyDataSchemeList : TeaModel {
                /// <summary>
                /// <para>Quality inspection scheme name</para>
                /// 
                /// <b>Example:</b>
                /// <para>质检方案B</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Quality inspection scheme ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>158</para>
                /// </summary>
                [NameInMap("SchemeId")]
                [Validation(Required=false)]
                public long? SchemeId { get; set; }

            }

            /// <summary>
            /// <para>Quality inspection task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SchemeTaskConfigId")]
            [Validation(Required=false)]
            public long? SchemeTaskConfigId { get; set; }

            /// <summary>
            /// <para>Quality inspection result type:</para>
            /// <list type="bullet">
            /// <item><description><para>1: offline voice</para>
            /// </description></item>
            /// <item><description><para>2: offline text</para>
            /// </description></item>
            /// <item><description><para>3: real-time voice</para>
            /// </description></item>
            /// <item><description><para>4: real-time text</para>
            /// </description></item>
            /// <item><description><para>5: contact center secondary quality inspection</para>
            /// </description></item>
            /// <item><description><para>51: call center voice secondary quality inspection</para>
            /// </description></item>
            /// <item><description><para>52: call center text secondary quality inspection</para>
            /// </description></item>
            /// <item><description><para>11: dataset voice</para>
            /// </description></item>
            /// <item><description><para>12: dataset text</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceDataType")]
            [Validation(Required=false)]
            public string SourceDataType { get; set; }

            /// <summary>
            /// <para>Enable status. Valid values: 0 (disabled) or 1 (enabled)</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error details if the request failed. Returns successful if the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Use this field to check the result: true means success, false or null means failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
