// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ExportBillDetailDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The download path of the exported file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://test-oss.com/image_01.jpeg">http://test-oss.com/image_01.jpeg</a></para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA05990-B90D-594F-8C8E-650AEEB94C5D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
