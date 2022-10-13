// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class GenerateUploadUrlRequest : TeaModel {
        [NameInMap("CallerBid")]
        [Validation(Required=false)]
        public string CallerBid { get; set; }

        [NameInMap("CallerIp")]
        [Validation(Required=false)]
        public string CallerIp { get; set; }

        [NameInMap("CallerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        [NameInMap("CallerType")]
        [Validation(Required=false)]
        public string CallerType { get; set; }

        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public long? CallerUid { get; set; }

        [NameInMap("ClientIp")]
        [Validation(Required=false)]
        public string ClientIp { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public int? Environment { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceOwnerId")]
        [Validation(Required=false)]
        public long? InstanceOwnerId { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("MfaPresent")]
        [Validation(Required=false)]
        public bool? MfaPresent { get; set; }

        [NameInMap("ProxyOriginalSecurityTransport")]
        [Validation(Required=false)]
        public bool? ProxyOriginalSecurityTransport { get; set; }

        [NameInMap("ProxyOriginalSourceIp")]
        [Validation(Required=false)]
        public string ProxyOriginalSourceIp { get; set; }

        [NameInMap("ProxyTrustTransportInfo")]
        [Validation(Required=false)]
        public bool? ProxyTrustTransportInfo { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("SecurityTransport")]
        [Validation(Required=false)]
        public bool? SecurityTransport { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("XspaceServicerId")]
        [Validation(Required=false)]
        public long? XspaceServicerId { get; set; }

        [NameInMap("XspaceTenantBuId")]
        [Validation(Required=false)]
        public long? XspaceTenantBuId { get; set; }

    }

}
