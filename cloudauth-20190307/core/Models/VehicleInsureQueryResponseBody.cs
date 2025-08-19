// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleInsureQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 indicates success, others indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response message for the request information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A6229C0-E156-48E4-B6EC-0F52********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public VehicleInsureQueryResponseBodyResultObject ResultObject { get; set; }
        public class VehicleInsureQueryResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Verification result code:</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>1: Found (charged)</description></item>
            /// <item><description>3: No record found (not charged)</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Insurance date information</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;firstInsuranceDate&quot;: &quot;<b><b>-</b>-<b>&quot;,
            ///     &quot;lastInsuranceDate&quot;: &quot;</b></b>-<b>&quot;,
            ///     &quot;latestInsuranceDate&quot;: &quot;****-</b>&quot;,
            ///     &quot;latestInsuranceDateStart&quot;: &quot;****-**&quot;
            ///   }</para>
            /// </summary>
            [NameInMap("VehicleInfo")]
            [Validation(Required=false)]
            public string VehicleInfo { get; set; }

        }

    }

}
