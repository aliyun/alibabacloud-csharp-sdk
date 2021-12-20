// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetJMeterSceneRunningDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DocumentUrl")]
        [Validation(Required=false)]
        public string DocumentUrl { get; set; }

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
        /// 运行中的数据
        /// </summary>
        [NameInMap("RunningData")]
        [Validation(Required=false)]
        public GetJMeterSceneRunningDataResponseBodyRunningData RunningData { get; set; }
        public class GetJMeterSceneRunningDataResponseBodyRunningData : TeaModel {
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }
            [NameInMap("AgentIdList")]
            [Validation(Required=false)]
            public List<string> AgentIdList { get; set; }
            [NameInMap("AllSampleStat")]
            [Validation(Required=false)]
            public Dictionary<string, string> AllSampleStat { get; set; }
            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public int? Concurrency { get; set; }
            [NameInMap("HasReport")]
            [Validation(Required=false)]
            public bool? HasReport { get; set; }
            [NameInMap("HoldFor")]
            [Validation(Required=false)]
            public int? HoldFor { get; set; }
            [NameInMap("IsDebugging")]
            [Validation(Required=false)]
            public bool? IsDebugging { get; set; }
            [NameInMap("SampleStatList")]
            [Validation(Required=false)]
            public List<string> SampleStatList { get; set; }
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }
            [NameInMap("StageName")]
            [Validation(Required=false)]
            public string StageName { get; set; }
            [NameInMap("StartTimeTS")]
            [Validation(Required=false)]
            public long? StartTimeTS { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Vum")]
            [Validation(Required=false)]
            public long? Vum { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
