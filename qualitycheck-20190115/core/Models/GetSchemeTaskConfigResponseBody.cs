// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class GetSchemeTaskConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSchemeTaskConfigResponseBodyData Data { get; set; }
        public class GetSchemeTaskConfigResponseBodyData : TeaModel {
            [NameInMap("AsrTaskPriority")]
            [Validation(Required=false)]
            public int? AsrTaskPriority { get; set; }

            [NameInMap("AssignType")]
            [Validation(Required=false)]
            public int? AssignType { get; set; }

            [NameInMap("DataConfig")]
            [Validation(Required=false)]
            public GetSchemeTaskConfigResponseBodyDataDataConfig DataConfig { get; set; }
            public class GetSchemeTaskConfigResponseBodyDataDataConfig : TeaModel {
                [NameInMap("AssignConfigs")]
                [Validation(Required=false)]
                public List<GetSchemeTaskConfigResponseBodyDataDataConfigAssignConfigs> AssignConfigs { get; set; }
                public class GetSchemeTaskConfigResponseBodyDataDataConfigAssignConfigs : TeaModel {
                    [NameInMap("AssignConfigContests")]
                    [Validation(Required=false)]
                    public List<GetSchemeTaskConfigResponseBodyDataDataConfigAssignConfigsAssignConfigContests> AssignConfigContests { get; set; }
                    public class GetSchemeTaskConfigResponseBodyDataDataConfigAssignConfigsAssignConfigContests : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public int? DataType { get; set; }

                        [NameInMap("ListObject")]
                        [Validation(Required=false)]
                        public List<object> ListObject { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>callStartTime</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("Symbol")]
                        [Validation(Required=false)]
                        public int? Symbol { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>{\&quot;start\&quot;:\&quot;2022-09-01 00:00:00\&quot;,\&quot;end\&quot;:\&quot;2022-09-30 00:00:00\&quot;}</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("DataSets")]
                [Validation(Required=false)]
                public string DataSets { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("ResultParam")]
                [Validation(Required=false)]
                public string ResultParam { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ManualReview")]
            [Validation(Required=false)]
            public int? ManualReview { get; set; }

            [NameInMap("ModeCustomizationId")]
            [Validation(Required=false)]
            public string ModeCustomizationId { get; set; }

            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("SchemeIdList")]
            [Validation(Required=false)]
            public List<long?> SchemeIdList { get; set; }

            [NameInMap("SchemeList")]
            [Validation(Required=false)]
            public List<GetSchemeTaskConfigResponseBodyDataSchemeList> SchemeList { get; set; }
            public class GetSchemeTaskConfigResponseBodyDataSchemeList : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>158</para>
                /// </summary>
                [NameInMap("SchemeId")]
                [Validation(Required=false)]
                public long? SchemeId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SchemeTaskConfigId")]
            [Validation(Required=false)]
            public long? SchemeTaskConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SourceDataType")]
            [Validation(Required=false)]
            public string SourceDataType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3CEA0495-341B-4482-9AD9-8191EF4***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
