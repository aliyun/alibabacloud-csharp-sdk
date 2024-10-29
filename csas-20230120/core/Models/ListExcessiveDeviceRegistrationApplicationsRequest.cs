// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListExcessiveDeviceRegistrationApplicationsRequest : TeaModel {
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
        /// </summary>
        [NameInMap("DeviceTag")]
        [Validation(Required=false)]
        public string DeviceTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>win10-64bit</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>00:16:XX:XX:7c:46</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
