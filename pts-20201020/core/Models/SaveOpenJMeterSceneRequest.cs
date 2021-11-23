// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class SaveOpenJMeterSceneRequest : TeaModel {
        /// <summary>
        /// 场景详情
        /// </summary>
        [NameInMap("OpenJMeterScene")]
        [Validation(Required=false)]
        public SaveOpenJMeterSceneRequestOpenJMeterScene OpenJMeterScene { get; set; }
        public class SaveOpenJMeterSceneRequestOpenJMeterScene : TeaModel {
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }
            [NameInMap("ConstantThroughputTimers")]
            [Validation(Required=false)]
            public string ConstantThroughputTimers { get; set; }
            [NameInMap("DnsCacheConfig")]
            [Validation(Required=false)]
            public SaveOpenJMeterSceneRequestOpenJMeterSceneDnsCacheConfig DnsCacheConfig { get; set; }
            public class SaveOpenJMeterSceneRequestOpenJMeterSceneDnsCacheConfig : TeaModel {
                [NameInMap("ClearCacheEachIteration")]
                [Validation(Required=false)]
                public bool? ClearCacheEachIteration { get; set; }

                [NameInMap("DnsServers")]
                [Validation(Required=false)]
                public List<string> DnsServers { get; set; }

                [NameInMap("HostTable")]
                [Validation(Required=false)]
                public Dictionary<string, string> HostTable { get; set; }

            }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }
            [NameInMap("EnviromentId")]
            [Validation(Required=false)]
            public string EnviromentId { get; set; }
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<SaveOpenJMeterSceneRequestOpenJMeterSceneFileList> FileList { get; set; }
            public class SaveOpenJMeterSceneRequestOpenJMeterSceneFileList : TeaModel {
                public long? FileId { get; set; }
                public string FileName { get; set; }
                public string FileOssAddress { get; set; }
                public long? FileSize { get; set; }
                public string Md5 { get; set; }
                public bool? SplitCsv { get; set; }
                public string Tags { get; set; }
            }
            [NameInMap("IsVpcTest")]
            [Validation(Required=false)]
            public bool? IsVpcTest { get; set; }
            [NameInMap("JMeterProperties")]
            [Validation(Required=false)]
            public List<SaveOpenJMeterSceneRequestOpenJMeterSceneJMeterProperties> JMeterProperties { get; set; }
            public class SaveOpenJMeterSceneRequestOpenJMeterSceneJMeterProperties : TeaModel {
                public string Name { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("RampUp")]
            [Validation(Required=false)]
            public int? RampUp { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }
            [NameInMap("Steps")]
            [Validation(Required=false)]
            public int? Steps { get; set; }
            [NameInMap("SyncTimers")]
            [Validation(Required=false)]
            public string SyncTimers { get; set; }
            [NameInMap("TestFile")]
            [Validation(Required=false)]
            public string TestFile { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }
        };

    }

}
