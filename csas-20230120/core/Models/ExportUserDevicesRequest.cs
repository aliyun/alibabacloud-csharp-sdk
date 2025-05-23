// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ExportUserDevicesRequest : TeaModel {
        [NameInMap("AppStatuses")]
        [Validation(Required=false)]
        public List<string> AppStatuses { get; set; }

        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Company</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>win10-64bit</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("IaStatuses")]
        [Validation(Required=false)]
        public List<string> IaStatuses { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00:16:XX:XX:7c:46</para>
        /// </summary>
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
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SharingStatus")]
        [Validation(Required=false)]
        public bool? SharingStatus { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
