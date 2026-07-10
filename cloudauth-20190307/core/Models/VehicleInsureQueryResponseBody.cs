// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleInsureQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. A value of 200 indicates success. Other values indicate failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A6229C0-E156-48E4-B6EC-0F52********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public VehicleInsureQueryResponseBodyResultObject ResultObject { get; set; }
        public class VehicleInsureQueryResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>1: record found (billable).</description></item>
            /// <item><description>3: no record found (not billable).</description></item>
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
            /// <para>The insurance date information.</para>
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
