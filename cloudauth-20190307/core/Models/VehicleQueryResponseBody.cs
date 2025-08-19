// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code: 200 for success, others for failure</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
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
        /// <para>D6163397-15C5-419C-9ACC-B7C83*******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Request result</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public VehicleQueryResponseBodyResultObject ResultObject { get; set; }
        public class VehicleQueryResponseBodyResultObject : TeaModel {
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
            /// <para>Vehicle information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;approvedCount&quot;: 7,
            ///     &quot;approvedLoad&quot;: 0,
            ///     &quot;axleCount&quot;: 2,
            ///     &quot;backWheelDistance&quot;: 1585,
            ///     &quot;brand&quot;: &quot;雷克萨斯&quot;,
            ///     &quot;compulsoryScrapTo&quot;: &quot;<b><b>-</b>-** <b>:</b>:<b>&quot;,
            ///     &quot;displacement&quot;: 4608,
            ///     &quot;engineNo&quot;: &quot;1UR0</b>**</b>&quot;,
            ///     &quot;engineType&quot;: &quot;1**&quot;,
            ///     &quot;frontWheelDistance&quot;: 1585,
            ///     &quot;fuelType&quot;: &quot;汽油&quot;,
            ///     &quot;high&quot;: 1860,
            ///     &quot;inspectionResultEffectiveTo&quot;: &quot;<b><b>-</b>-** <b>:</b>:<b>&quot;,
            ///     &quot;modelNo&quot;: &quot;UR</b>*</b>-<b><b><b>&quot;,
            ///     &quot;power&quot;: 228,
            ///     &quot;registrationDate&quot;: &quot;</b></b>-</b>-** <b>:</b>:<b>&quot;,
            ///     &quot;releaseDate&quot;: &quot;&quot;,
            ///     &quot;state&quot;: &quot;0&quot;,
            ///     &quot;stateDesc&quot;: &quot;正常&quot;,
            ///     &quot;totalMass&quot;: 2940,
            ///     &quot;unladenMass&quot;: 2350,
            ///     &quot;useProperty&quot;: 0,
            ///     &quot;usePropertyDesc&quot;: &quot;非营运&quot;,
            ///     &quot;long&quot;: 4890,
            ///     &quot;vin&quot;: &quot;A</b>*********&quot;,
            ///     &quot;wheelBase&quot;: 2790,
            ///     &quot;wide&quot;: 1910
            /// }</para>
            /// </summary>
            [NameInMap("VehicleInfo")]
            [Validation(Required=false)]
            public string VehicleInfo { get; set; }

        }

    }

}
