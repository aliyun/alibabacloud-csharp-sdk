// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetServerlessAppAuthDetailRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3de9f2ac-f***769226df</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AppRegionId")]
        [Validation(Required=false)]
        public string AppRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RunD</para>
        /// </summary>
        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SAE</para>
        /// </summary>
        [NameInMap("VendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
