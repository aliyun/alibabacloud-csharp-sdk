// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class GetNetDeviceInfoWithSizeRequest : TeaModel {
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public long? Cursor { get; set; }

        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("Idc")]
        [Validation(Required=false)]
        public string Idc { get; set; }

        [NameInMap("LogicNetPod")]
        [Validation(Required=false)]
        public string LogicNetPod { get; set; }

        [NameInMap("Manufacturer")]
        [Validation(Required=false)]
        public string Manufacturer { get; set; }

        [NameInMap("MgnIp")]
        [Validation(Required=false)]
        public string MgnIp { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("NetPod")]
        [Validation(Required=false)]
        public string NetPod { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("ServiceTag")]
        [Validation(Required=false)]
        public string ServiceTag { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
