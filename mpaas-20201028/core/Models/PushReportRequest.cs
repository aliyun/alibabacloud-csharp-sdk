// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class PushReportRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("Channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("ConnectType")]
        [Validation(Required=false)]
        public string ConnectType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeliveryToken")]
        [Validation(Required=false)]
        public string DeliveryToken { get; set; }

        [NameInMap("Imei")]
        [Validation(Required=false)]
        public string Imei { get; set; }

        [NameInMap("Imsi")]
        [Validation(Required=false)]
        public string Imsi { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public int? OsType { get; set; }

        [NameInMap("PushVersion")]
        [Validation(Required=false)]
        public string PushVersion { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ThirdChannel")]
        [Validation(Required=false)]
        public int? ThirdChannel { get; set; }

        [NameInMap("ThirdChannelDeviceToken")]
        [Validation(Required=false)]
        public string ThirdChannelDeviceToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
