// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ExportMeasurementDataResponseBody : TeaModel {
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
