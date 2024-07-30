// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListSchemeTaskConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

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
                [NameInMap("AsrTaskPriority")]
                [Validation(Required=false)]
                public int? AsrTaskPriority { get; set; }

                [NameInMap("AssignType")]
                [Validation(Required=false)]
                public int? AssignType { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

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

                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Symbol")]
                                    [Validation(Required=false)]
                                    public int? Symbol { get; set; }

                                    [NameInMap("Value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                        }

                    }

                    [NameInMap("DataSets")]
                    [Validation(Required=false)]
                    public string DataSets { get; set; }

                    [NameInMap("Index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("ResultParam")]
                    [Validation(Required=false)]
                    public string ResultParam { get; set; }

                }

                [NameInMap("FinishRate")]
                [Validation(Required=false)]
                public double? FinishRate { get; set; }

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

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NumberExecuting")]
                [Validation(Required=false)]
                public int? NumberExecuting { get; set; }

                [NameInMap("NumberFail")]
                [Validation(Required=false)]
                public int? NumberFail { get; set; }

                [NameInMap("NumberSuccess")]
                [Validation(Required=false)]
                public int? NumberSuccess { get; set; }

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

                        [NameInMap("SchemeId")]
                        [Validation(Required=false)]
                        public long? SchemeId { get; set; }

                    }

                }

                [NameInMap("SchemeTaskConfigId")]
                [Validation(Required=false)]
                public long? SchemeTaskConfigId { get; set; }

                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public int? SourceDataType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public int? Type { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateUser")]
                [Validation(Required=false)]
                public long? UpdateUser { get; set; }

                [NameInMap("UserGroup")]
                [Validation(Required=false)]
                public string UserGroup { get; set; }

                [NameInMap("VocabId")]
                [Validation(Required=false)]
                public string VocabId { get; set; }

                [NameInMap("VocabName")]
                [Validation(Required=false)]
                public string VocabName { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("LastDataId")]
        [Validation(Required=false)]
        public string LastDataId { get; set; }

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

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCountId")]
        [Validation(Required=false)]
        public string ResultCountId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
