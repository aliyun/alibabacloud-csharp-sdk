// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoDRMLicenseRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>widevine</para>
        /// </summary>
        [NameInMap("drmType")]
        [Validation(Required=false)]
        public string DrmType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CAES6B8SQgpACioSENGxDhqCLIVwwCBOyPayyWoSENGxDhqCLIVwwCBOyPayyWpI88aJmwYQARoQdRV32</para>
        /// </summary>
        [NameInMap("licenseRequest")]
        [Validation(Required=false)]
        public string LicenseRequest { get; set; }

    }

}
