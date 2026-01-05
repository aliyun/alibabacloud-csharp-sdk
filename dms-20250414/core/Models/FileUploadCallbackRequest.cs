// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class FileUploadCallbackRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TrailCenter</para>
        /// </summary>
        [NameInMap("CallFrom")]
        [Validation(Required=false)]
        public string CallFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8110</para>
        /// </summary>
        [NameInMap("FileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conversion_metrics.csv</para>
        /// </summary>
        [NameInMap("Filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UploadLocation")]
        [Validation(Required=false)]
        public string UploadLocation { get; set; }

    }

}
