// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserDevicesRequest : TeaModel {
        [NameInMap("AppStatuses")]
        [Validation(Required=false)]
        public List<string> AppStatuses { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        [NameInMap("DeviceBelong")]
        [Validation(Required=false)]
        public string DeviceBelong { get; set; }

        [NameInMap("DeviceStatuses")]
        [Validation(Required=false)]
        public List<string> DeviceStatuses { get; set; }

        [NameInMap("DeviceTags")]
        [Validation(Required=false)]
        public List<string> DeviceTags { get; set; }

        [NameInMap("DeviceTypes")]
        [Validation(Required=false)]
        public List<string> DeviceTypes { get; set; }

        [NameInMap("DlpStatuses")]
        [Validation(Required=false)]
        public List<string> DlpStatuses { get; set; }

        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("IaStatuses")]
        [Validation(Required=false)]
        public List<string> IaStatuses { get; set; }

        [NameInMap("InnerIp")]
        [Validation(Required=false)]
        public string InnerIp { get; set; }

        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        [NameInMap("NacStatuses")]
        [Validation(Required=false)]
        public List<string> NacStatuses { get; set; }

        [NameInMap("PaStatuses")]
        [Validation(Required=false)]
        public List<string> PaStatuses { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        [NameInMap("SharingStatus")]
        [Validation(Required=false)]
        public bool? SharingStatus { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
