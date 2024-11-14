// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListSchemeTaskConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSchemeTaskConfigResponseBodyData Data { get; set; }
        public class ListSchemeTaskConfigResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListSchemeTaskConfigResponseBodyDataData> Data { get; set; }
            public class ListSchemeTaskConfigResponseBodyDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AsrTaskPriority")]
                [Validation(Required=false)]
                public int? AsrTaskPriority { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AssignType")]
                [Validation(Required=false)]
                public int? AssignType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1650418039000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public long? CreateUser { get; set; }

                [NameInMap("DataConfig")]
                [Validation(Required=false)]
                public ListSchemeTaskConfigResponseBodyDataDataDataConfig DataConfig { get; set; }
                public class ListSchemeTaskConfigResponseBodyDataDataDataConfig : TeaModel {
                    [NameInMap("AssignConfigs")]
                    [Validation(Required=false)]
                    public ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigs AssignConfigs { get; set; }
                    public class ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigs : TeaModel {
                        [NameInMap("AssignConfig")]
                        [Validation(Required=false)]
                        public List<ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigsAssignConfig> AssignConfig { get; set; }
                        public class ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigsAssignConfig : TeaModel {
                            [NameInMap("AssignConfigContests")]
                            [Validation(Required=false)]
                            public ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigsAssignConfigAssignConfigContests AssignConfigContests { get; set; }
                            public class ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigsAssignConfigAssignConfigContests : TeaModel {
                                [NameInMap("AssignConfigContest")]
                                [Validation(Required=false)]
                                public List<ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigsAssignConfigAssignConfigContestsAssignConfigContest> AssignConfigContest { get; set; }
                                public class ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigsAssignConfigAssignConfigContestsAssignConfigContest : TeaModel {
                                    /// <summary>
                                    /// <b>Example:</b>
                                    /// <para>3</para>
                                    /// </summary>
                                    [NameInMap("DataType")]
                                    [Validation(Required=false)]
                                    public int? DataType { get; set; }

                                    [NameInMap("ListObject")]
                                    [Validation(Required=false)]
                                    public ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigsAssignConfigAssignConfigContestsAssignConfigContestListObject ListObject { get; set; }
                                    public class ListSchemeTaskConfigResponseBodyDataDataDataConfigAssignConfigsAssignConfigAssignConfigContestsAssignConfigContestListObject : TeaModel {
                                        [NameInMap("ListObject")]
                                        [Validation(Required=false)]
                                        public List<object> ListObject { get; set; }

                                    }

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
                    public int? Index { get; set; }

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
                /// <para>100</para>
                /// </summary>
                [NameInMap("FinishRate")]
                [Validation(Required=false)]
                public double? FinishRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ManualReview")]
                [Validation(Required=false)]
                public int? ManualReview { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cdae396590b*****ec40f3476e274fc</para>
                /// </summary>
                [NameInMap("ModeCustomizationId")]
                [Validation(Required=false)]
                public string ModeCustomizationId { get; set; }

                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NumberExecuting")]
                [Validation(Required=false)]
                public int? NumberExecuting { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NumberFail")]
                [Validation(Required=false)]
                public int? NumberFail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("NumberSuccess")]
                [Validation(Required=false)]
                public int? NumberSuccess { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("NumberSum")]
                [Validation(Required=false)]
                public int? NumberSum { get; set; }

                [NameInMap("SchemeIdList")]
                [Validation(Required=false)]
                public ListSchemeTaskConfigResponseBodyDataDataSchemeIdList SchemeIdList { get; set; }
                public class ListSchemeTaskConfigResponseBodyDataDataSchemeIdList : TeaModel {
                    [NameInMap("SchemeIdList")]
                    [Validation(Required=false)]
                    public List<long?> SchemeIdList { get; set; }

                }

                [NameInMap("SchemeList")]
                [Validation(Required=false)]
                public ListSchemeTaskConfigResponseBodyDataDataSchemeList SchemeList { get; set; }
                public class ListSchemeTaskConfigResponseBodyDataDataSchemeList : TeaModel {
                    [NameInMap("SchemeList")]
                    [Validation(Required=false)]
                    public List<ListSchemeTaskConfigResponseBodyDataDataSchemeListSchemeList> SchemeList { get; set; }
                    public class ListSchemeTaskConfigResponseBodyDataDataSchemeListSchemeList : TeaModel {
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
                /// <para>2</para>
                /// </summary>
                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public int? SourceDataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1650418039000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UpdateUser")]
                [Validation(Required=false)]
                public long? UpdateUser { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UserGroup")]
                [Validation(Required=false)]
                public string UserGroup { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9f90b3efa2****0a49acec226eafc17</para>
                /// </summary>
                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public string VocabId { get; set; }

                [NameInMap("VocabName")]
                [Validation(Required=false)]
                public string VocabName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("LastDataId")]
        [Validation(Required=false)]
        public string LastDataId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Messages")]
        [Validation(Required=false)]
        public ListSchemeTaskConfigResponseBodyMessages Messages { get; set; }
        public class ListSchemeTaskConfigResponseBodyMessages : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public List<string> Message { get; set; }

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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4B0A8DCD-0DDF-5E80-8B9C-0A2F68B3403B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
