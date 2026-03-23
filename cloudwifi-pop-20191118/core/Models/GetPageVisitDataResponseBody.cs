// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudwifi_pop20191118.Models
{
    public class GetPageVisitDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;totalPv&quot;: 535,
        ///       &quot;totalUv&quot;: 246,
        ///       &quot;detailVo&quot;: [
        /// {
        /// &quot;uv&quot;:17,
        /// &quot;pv&quot;:56,
        /// &quot;ds&quot;:&quot;20230710&quot;
        /// }
        /// ]
        /// }</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>the status of ap is not online</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>76F569F1-078E-5A08-881D-810B97C502A5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
