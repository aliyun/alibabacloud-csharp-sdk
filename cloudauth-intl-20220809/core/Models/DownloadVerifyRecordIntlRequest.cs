// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class DownloadVerifyRecordIntlRequest : TeaModel {
        /// <summary>
        /// <para>Business type:</para>
        /// <list type="bullet">
        /// <item><description>INVOKE_STATISTICS</description></item>
        /// <item><description>INVOKE_RECORD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INVOKE_RECORD</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>Query code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vrf_intl_verify_record_real_id_idv_invoke_statistics_query</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Download mode:</para>
        /// <list type="bullet">
        /// <item><description><b>async</b>: Asynchronous</description></item>
        /// <item><description><b>sync</b>: Synchronous</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>async</para>
        /// </summary>
        [NameInMap("DownloadMode")]
        [Validation(Required=false)]
        public string DownloadMode { get; set; }

        /// <summary>
        /// <para>Parameters related to the export and download query task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;productCode\&quot;:\&quot;FACE_LIVENESS\&quot;,\&quot;startDs\&quot;:\&quot;20251121\&quot;,\&quot;endDs\&quot;:\&quot;20251128\&quot;,\&quot;language\&quot;:\&quot;en\&quot;}</para>
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string Param { get; set; }

        /// <summary>
        /// <para>Product Code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>KYC</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
