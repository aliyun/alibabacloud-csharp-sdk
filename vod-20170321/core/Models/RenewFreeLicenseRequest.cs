// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RenewFreeLicenseRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppItemId")]
        [Validation(Required=false)]
        public string AppItemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LicenseItemId")]
        [Validation(Required=false)]
        public string LicenseItemId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ValidPeriod")]
        [Validation(Required=false)]
        public int? ValidPeriod { get; set; }

    }

}
