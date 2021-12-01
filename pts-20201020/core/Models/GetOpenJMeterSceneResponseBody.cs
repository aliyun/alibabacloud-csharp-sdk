// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetOpenJMeterSceneResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 场景详情
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public GetOpenJMeterSceneResponseBodyScene Scene { get; set; }
        public class GetOpenJMeterSceneResponseBodyScene : TeaModel {
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }
            [NameInMap("BaseInfo")]
            [Validation(Required=false)]
            public GetOpenJMeterSceneResponseBodySceneBaseInfo BaseInfo { get; set; }
            public class GetOpenJMeterSceneResponseBodySceneBaseInfo : TeaModel {
                /// <summary>
                /// 创建人名
                /// </summary>
                [NameInMap("CreateName")]
                [Validation(Required=false)]
                public string CreateName { get; set; }

                /// <summary>
                /// 修改人名
                /// </summary>
                [NameInMap("ModifyName")]
                [Validation(Required=false)]
                public string ModifyName { get; set; }

                /// <summary>
                /// 操作类型
                /// </summary>
                [NameInMap("OperateType")]
                [Validation(Required=false)]
                public string OperateType { get; set; }

                /// <summary>
                /// 场景压测负责人
                /// </summary>
                [NameInMap("Principal")]
                [Validation(Required=false)]
                public string Principal { get; set; }

                /// <summary>
                /// 备注
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 场景来源
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }
            [NameInMap("ConstantThroughputTimerType")]
            [Validation(Required=false)]
            public string ConstantThroughputTimerType { get; set; }
            [NameInMap("DnsCacheConfig")]
            [Validation(Required=false)]
            public GetOpenJMeterSceneResponseBodySceneDnsCacheConfig DnsCacheConfig { get; set; }
            public class GetOpenJMeterSceneResponseBodySceneDnsCacheConfig : TeaModel {
                /// <summary>
                /// 是否清除缓存
                /// </summary>
                [NameInMap("ClearCacheEachIteration")]
                [Validation(Required=false)]
                public bool? ClearCacheEachIteration { get; set; }

                /// <summary>
                /// DNS服务器
                /// </summary>
                [NameInMap("DnsServers")]
                [Validation(Required=false)]
                public List<string> DnsServers { get; set; }

                /// <summary>
                /// 域名绑定
                /// </summary>
                [NameInMap("HostTable")]
                [Validation(Required=false)]
                public Dictionary<string, object> HostTable { get; set; }

            }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public int? Duration { get; set; }
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }
            [NameInMap("FileList")]
            [Validation(Required=false)]
            public List<GetOpenJMeterSceneResponseBodySceneFileList> FileList { get; set; }
            public class GetOpenJMeterSceneResponseBodySceneFileList : TeaModel {
                public string FileName { get; set; }
                public string FileOssAddress { get; set; }
                public long? FileSize { get; set; }
                public string FileType { get; set; }
                public long? Id { get; set; }
                public string Md5 { get; set; }
                public bool? SplitCsv { get; set; }
            }
            [NameInMap("IsVpcTest")]
            [Validation(Required=false)]
            public bool? IsVpcTest { get; set; }
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
            [NameInMap("SyncTimerType")]
            [Validation(Required=false)]
            public string SyncTimerType { get; set; }
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
