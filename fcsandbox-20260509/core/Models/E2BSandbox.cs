// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class E2BSandbox : TeaModel {
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("allowInternetAccess")]
        [Validation(Required=false)]
        public bool? AllowInternetAccess { get; set; }

        [NameInMap("clientID")]
        [Validation(Required=false)]
        public string ClientID { get; set; }

        [NameInMap("cpuCount")]
        [Validation(Required=false)]
        public int? CpuCount { get; set; }

        [NameInMap("diskSizeMB")]
        [Validation(Required=false)]
        public int? DiskSizeMB { get; set; }

        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("endAt")]
        [Validation(Required=false)]
        public string EndAt { get; set; }

        [NameInMap("envdAccessToken")]
        [Validation(Required=false)]
        public string EnvdAccessToken { get; set; }

        [NameInMap("envdVersion")]
        [Validation(Required=false)]
        public string EnvdVersion { get; set; }

        [NameInMap("fcFunctionName")]
        [Validation(Required=false)]
        public string FcFunctionName { get; set; }

        [NameInMap("fcInstanceID")]
        [Validation(Required=false)]
        public string FcInstanceID { get; set; }

        [NameInMap("fcSessionID")]
        [Validation(Required=false)]
        public string FcSessionID { get; set; }

        [NameInMap("lifecycle")]
        [Validation(Required=false)]
        public E2BLifecycle Lifecycle { get; set; }

        [NameInMap("memoryMB")]
        [Validation(Required=false)]
        public int? MemoryMB { get; set; }

        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

        [NameInMap("network")]
        [Validation(Required=false)]
        public E2BNetwork Network { get; set; }

        [NameInMap("sandboxID")]
        [Validation(Required=false)]
        public string SandboxID { get; set; }

        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("volumeMounts")]
        [Validation(Required=false)]
        public List<E2BVolumeMount> VolumeMounts { get; set; }

    }

}
