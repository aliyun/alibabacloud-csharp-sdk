// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class UpdateGatewayFileShareRequest : TeaModel {
        [NameInMap("AccessBasedEnumeration")]
        [Validation(Required=false)]
        public bool? AccessBasedEnumeration { get; set; }

        [NameInMap("BackendLimit")]
        [Validation(Required=false)]
        public int? BackendLimit { get; set; }

        [NameInMap("Browsable")]
        [Validation(Required=false)]
        public bool? Browsable { get; set; }

        [NameInMap("BypassCacheRead")]
        [Validation(Required=false)]
        public bool? BypassCacheRead { get; set; }

        [NameInMap("CacheMode")]
        [Validation(Required=false)]
        public string CacheMode { get; set; }

        [NameInMap("ClientSideCmk")]
        [Validation(Required=false)]
        public string ClientSideCmk { get; set; }

        [NameInMap("ClientSideEncryption")]
        [Validation(Required=false)]
        public bool? ClientSideEncryption { get; set; }

        [NameInMap("DirectIO")]
        [Validation(Required=false)]
        public bool? DirectIO { get; set; }

        [NameInMap("DownloadLimit")]
        [Validation(Required=false)]
        public int? DownloadLimit { get; set; }

        [NameInMap("FastReclaim")]
        [Validation(Required=false)]
        public bool? FastReclaim { get; set; }

        [NameInMap("FrontendLimit")]
        [Validation(Required=false)]
        public int? FrontendLimit { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        [NameInMap("IgnoreDelete")]
        [Validation(Required=false)]
        public bool? IgnoreDelete { get; set; }

        [NameInMap("InPlace")]
        [Validation(Required=false)]
        public bool? InPlace { get; set; }

        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        [NameInMap("KmsRotatePeriod")]
        [Validation(Required=false)]
        public long? KmsRotatePeriod { get; set; }

        [NameInMap("LagPeriod")]
        [Validation(Required=false)]
        public long? LagPeriod { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NfsV4Optimization")]
        [Validation(Required=false)]
        public bool? NfsV4Optimization { get; set; }

        [NameInMap("PollingInterval")]
        [Validation(Required=false)]
        public int? PollingInterval { get; set; }

        [NameInMap("ReadOnlyClientList")]
        [Validation(Required=false)]
        public string ReadOnlyClientList { get; set; }

        [NameInMap("ReadOnlyUserList")]
        [Validation(Required=false)]
        public string ReadOnlyUserList { get; set; }

        [NameInMap("ReadWriteClientList")]
        [Validation(Required=false)]
        public string ReadWriteClientList { get; set; }

        [NameInMap("ReadWriteUserList")]
        [Validation(Required=false)]
        public string ReadWriteUserList { get; set; }

        [NameInMap("RemoteSync")]
        [Validation(Required=false)]
        public bool? RemoteSync { get; set; }

        [NameInMap("RemoteSyncDownload")]
        [Validation(Required=false)]
        public bool? RemoteSyncDownload { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ServerSideCmk")]
        [Validation(Required=false)]
        public string ServerSideCmk { get; set; }

        [NameInMap("ServerSideEncryption")]
        [Validation(Required=false)]
        public bool? ServerSideEncryption { get; set; }

        [NameInMap("Squash")]
        [Validation(Required=false)]
        public string Squash { get; set; }

        [NameInMap("TransferAcceleration")]
        [Validation(Required=false)]
        public bool? TransferAcceleration { get; set; }

        [NameInMap("WindowsAcl")]
        [Validation(Required=false)]
        public bool? WindowsAcl { get; set; }

    }

}
