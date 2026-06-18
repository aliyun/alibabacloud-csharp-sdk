// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class E2BTemplate : TeaModel {
        [NameInMap("aliases")]
        [Validation(Required=false)]
        public List<string> Aliases { get; set; }

        [NameInMap("buildStatus")]
        [Validation(Required=false)]
        public string BuildStatus { get; set; }

        [NameInMap("builds")]
        [Validation(Required=false)]
        public E2BTemplateBuild Builds { get; set; }

        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("lastSpawnedAt")]
        [Validation(Required=false)]
        public string LastSpawnedAt { get; set; }

        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        [NameInMap("memoryMB")]
        [Validation(Required=false)]
        public int? MemoryMB { get; set; }

        [NameInMap("names")]
        [Validation(Required=false)]
        public List<string> Names { get; set; }

        [NameInMap("public")]
        [Validation(Required=false)]
        public bool? Public { get; set; }

        [NameInMap("spawnCount")]
        [Validation(Required=false)]
        public string SpawnCount { get; set; }

        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<E2BTemplateTag> Tags { get; set; }

        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("userID")]
        [Validation(Required=false)]
        public string UserID { get; set; }

    }

}
