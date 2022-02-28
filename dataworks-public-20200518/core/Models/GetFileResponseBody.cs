// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetFileResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFileResponseBodyData Data { get; set; }
        public class GetFileResponseBodyData : TeaModel {
            [NameInMap("File")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataFile File { get; set; }
            public class GetFileResponseBodyDataFile : TeaModel {
                [NameInMap("AdvancedSettings")]
                [Validation(Required=false)]
                public string AdvancedSettings { get; set; }

                [NameInMap("AutoParsing")]
                [Validation(Required=false)]
                public bool? AutoParsing { get; set; }

                [NameInMap("BizId")]
                [Validation(Required=false)]
                public long? BizId { get; set; }

                [NameInMap("BusinessId")]
                [Validation(Required=false)]
                public long? BusinessId { get; set; }

                [NameInMap("CommitStatus")]
                [Validation(Required=false)]
                public int? CommitStatus { get; set; }

                [NameInMap("ConnectionName")]
                [Validation(Required=false)]
                public string ConnectionName { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("CreateUser")]
                [Validation(Required=false)]
                public string CreateUser { get; set; }

                [NameInMap("CurrentVersion")]
                [Validation(Required=false)]
                public int? CurrentVersion { get; set; }

                [NameInMap("DeletedStatus")]
                [Validation(Required=false)]
                public string DeletedStatus { get; set; }

                [NameInMap("FileDescription")]
                [Validation(Required=false)]
                public string FileDescription { get; set; }

                [NameInMap("FileFolderId")]
                [Validation(Required=false)]
                public string FileFolderId { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                [NameInMap("IsMaxCompute")]
                [Validation(Required=false)]
                public bool? IsMaxCompute { get; set; }

                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public long? LastEditTime { get; set; }

                [NameInMap("LastEditUser")]
                [Validation(Required=false)]
                public string LastEditUser { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }
            [NameInMap("NodeConfiguration")]
            [Validation(Required=false)]
            public GetFileResponseBodyDataNodeConfiguration NodeConfiguration { get; set; }
            public class GetFileResponseBodyDataNodeConfiguration : TeaModel {
                [NameInMap("AutoRerunIntervalMillis")]
                [Validation(Required=false)]
                public int? AutoRerunIntervalMillis { get; set; }

                [NameInMap("AutoRerunTimes")]
                [Validation(Required=false)]
                public int? AutoRerunTimes { get; set; }

                [NameInMap("CronExpress")]
                [Validation(Required=false)]
                public string CronExpress { get; set; }

                [NameInMap("CycleType")]
                [Validation(Required=false)]
                public string CycleType { get; set; }

                [NameInMap("DependentNodeIdList")]
                [Validation(Required=false)]
                public string DependentNodeIdList { get; set; }

                [NameInMap("DependentType")]
                [Validation(Required=false)]
                public string DependentType { get; set; }

                [NameInMap("EndEffectDate")]
                [Validation(Required=false)]
                public long? EndEffectDate { get; set; }

                [NameInMap("InputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationInputList> InputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationInputList : TeaModel {
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public string Input { get; set; }

                    [NameInMap("ParseType")]
                    [Validation(Required=false)]
                    public string ParseType { get; set; }

                }

                [NameInMap("OutputList")]
                [Validation(Required=false)]
                public List<GetFileResponseBodyDataNodeConfigurationOutputList> OutputList { get; set; }
                public class GetFileResponseBodyDataNodeConfigurationOutputList : TeaModel {
                    [NameInMap("Output")]
                    [Validation(Required=false)]
                    public string Output { get; set; }

                    [NameInMap("RefTableName")]
                    [Validation(Required=false)]
                    public string RefTableName { get; set; }

                }

                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

                [NameInMap("RerunMode")]
                [Validation(Required=false)]
                public string RerunMode { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public long? ResourceGroupId { get; set; }

                [NameInMap("SchedulerType")]
                [Validation(Required=false)]
                public string SchedulerType { get; set; }

                [NameInMap("StartEffectDate")]
                [Validation(Required=false)]
                public long? StartEffectDate { get; set; }

                [NameInMap("StartImmediately")]
                [Validation(Required=false)]
                public bool? StartImmediately { get; set; }

                [NameInMap("Stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

            }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
