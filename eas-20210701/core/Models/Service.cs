// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Service : TeaModel {
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public string AppConfig { get; set; }

        [NameInMap("AppSpecName")]
        [Validation(Required=false)]
        public string AppSpecName { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public int? CurrentVersion { get; set; }

        [NameInMap("ExtraData")]
        [Validation(Required=false)]
        public string ExtraData { get; set; }

        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<ServiceLabels> Labels { get; set; }
        public class ServiceLabels : TeaModel {
            [NameInMap("LabelKey")]
            [Validation(Required=false)]
            public string LabelKey { get; set; }

            [NameInMap("LabelValue")]
            [Validation(Required=false)]
            public string LabelValue { get; set; }

        }

        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public int? LatestVersion { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public string ParentUid { get; set; }

        [NameInMap("PendingInstance")]
        [Validation(Required=false)]
        public int? PendingInstance { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("ResourceAlias")]
        [Validation(Required=false)]
        public string ResourceAlias { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("RoleAttrs")]
        [Validation(Required=false)]
        public string RoleAttrs { get; set; }

        [NameInMap("RunningInstance")]
        [Validation(Required=false)]
        public int? RunningInstance { get; set; }

        [NameInMap("SafetyLock")]
        [Validation(Required=false)]
        public string SafetyLock { get; set; }

        [NameInMap("SecondaryInternetEndpoint")]
        [Validation(Required=false)]
        public string SecondaryInternetEndpoint { get; set; }

        [NameInMap("SecondaryIntranetEndpoint")]
        [Validation(Required=false)]
        public string SecondaryIntranetEndpoint { get; set; }

        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public string ServiceConfig { get; set; }

        [NameInMap("ServiceGroup")]
        [Validation(Required=false)]
        public string ServiceGroup { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("ServiceUid")]
        [Validation(Required=false)]
        public string ServiceUid { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TotalInstance")]
        [Validation(Required=false)]
        public int? TotalInstance { get; set; }

        [NameInMap("TrafficState")]
        [Validation(Required=false)]
        public string TrafficState { get; set; }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
