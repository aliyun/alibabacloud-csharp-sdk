// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class PushResourceMeasureRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BelongId")]
        [Validation(Required=false)]
        public string BelongId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("BelongIdType")]
        [Validation(Required=false)]
        public string BelongIdType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WS20250801154628000001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;MD5\&quot;:\&quot;8ba46100bd898461f0f589704f2fad25\&quot;,\&quot;driver\&quot;:\&quot;vhd\&quot;,\&quot;flag\&quot;:\&quot;769\&quot;,\&quot;imds_support\&quot;:\&quot;v1\&quot;,\&quot;io_optimized\&quot;:true,\&quot;nvme_supported\&quot;:false,\&quot;uefi_preferred\&quot;:false}</para>
        /// </summary>
        [NameInMap("MeasureData")]
        [Validation(Required=false)]
        public string MeasureData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;MD5\&quot;:\&quot;8ba46100bd898461f0f589704f2fad25\&quot;,\&quot;driver\&quot;:\&quot;vhd\&quot;,\&quot;flag\&quot;:\&quot;769\&quot;,\&quot;imds_support\&quot;:\&quot;v1\&quot;,\&quot;io_optimized\&quot;:true,\&quot;nvme_supported\&quot;:false,\&quot;uefi_preferred\&quot;:false}</para>
        /// </summary>
        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public string MetaData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InspirationTokens</para>
        /// </summary>
        [NameInMap("ResourceCode")]
        [Validation(Required=false)]
        public string ResourceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("UseTime")]
        [Validation(Required=false)]
        public string UseTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MANUAL_BIZ</para>
        /// </summary>
        [NameInMap("UseType")]
        [Validation(Required=false)]
        public string UseType { get; set; }

    }

}
