// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Vehicle5ItemQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0D******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result information.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public Vehicle5ItemQueryResponseBodyResultObject ResultObject { get; set; }
        public class Vehicle5ItemQueryResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Match found (billable).</description></item>
            /// <item><description><b>3</b>: No record found (not billable).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>The vehicle information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///         &quot;engineNo&quot;: &quot;F0******&quot;,
            ///         &quot;useProperty&quot;: 0,
            ///         &quot;registrationDate&quot;: &quot;<b><b>-</b>-** <b>:</b>:<b>&quot;,
            ///         &quot;engineType&quot;: &quot;B</b>**</b>&quot;,
            ///         &quot;vin&quot;: &quot;A********&quot;,
            ///         &quot;state&quot;: &quot;0&quot;,
            ///         &quot;modelNo&quot;: &quot;B********&quot;,
            ///         &quot;type&quot;: &quot;小型轿车&quot;,
            ///         &quot;brand&quot;: &quot;宝马&quot;,
            ///         &quot;usePropertyDesc&quot;: &quot;非营运&quot;,
            ///         &quot;stateDesc&quot;: &quot;正常&quot;
            ///     }</para>
            /// </summary>
            [NameInMap("VehicleInfo")]
            [Validation(Required=false)]
            public string VehicleInfo { get; set; }

        }

    }

}
