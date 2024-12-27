// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetDRMLicenseResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>IEEE1284DeviceID</para>
        /// </summary>
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AESzB8SQgpACioSEJ3yqiFwruAOUgIvlCx*****</para>
        /// </summary>
        [NameInMap("License")]
        [Validation(Required=false)]
        public string License { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>896ABAD1-C452-4BED-B5E0-302955F*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("States")]
        [Validation(Required=false)]
        public long? States { get; set; }

    }

}
