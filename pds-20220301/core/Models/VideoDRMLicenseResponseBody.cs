// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class VideoDRMLicenseResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cb9swCy8P50H9KePsxET3jZ1tm41bDs9HTsxbWnsjf3bsf6QGdiS4kZPhDaskimbNyAfNjmhQRmWFt3AhwNF3</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("device_info")]
        [Validation(Required=false)]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("states")]
        [Validation(Required=false)]
        public string States { get; set; }

    }

}
