// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleMetaVerifyV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code, <b>200</b> indicates successful API response.</para>
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
        /// <para>5A6229C0-E156-48E4-B6EC-0F528B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public VehicleMetaVerifyV2ResponseBodyResultObject ResultObject { get; set; }
        public class VehicleMetaVerifyV2ResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Verification result code:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Verification consistent.</description></item>
            /// <item><description><b>2</b>: Verification inconsistent.</description></item>
            /// <item><description><b>3</b>: No record found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <para>Detailed vehicle information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;approvedCount&quot;: &quot;7&quot;,
            ///     &quot;approvedLoad&quot;: &quot;0&quot;,
            ///     &quot;axleCount&quot;: &quot;2&quot;,
            ///     &quot;backWheelDistance&quot;: &quot;1585&quot;,
            ///     &quot;brand&quot;: &quot;雷克萨斯&quot;,
            ///     &quot;displacement&quot;: &quot;4608&quot;,
            ///     &quot;engineNum&quot;: &quot;1*********&quot;,
            ///     &quot;engineType&quot;: &quot;1**&quot;,
            ///     &quot;frontWheelDistance&quot;: &quot;1585&quot;,
            ///     &quot;fuelType&quot;: &quot;汽油&quot;,
            ///     &quot;inspectionDate&quot;: &quot;<b><b>-</b>-** <b>:</b>:<b>&quot;,
            ///     &quot;modelNum&quot;: &quot;UR</b>*</b>-<b><b><b>&quot;,
            ///     &quot;power&quot;: &quot;228&quot;,
            ///     &quot;registrationDate&quot;: &quot;</b></b>-</b>-** <b>:</b>:<b>&quot;,
            ///     &quot;retirementDate&quot;: &quot;****-</b>-** <b>:</b>:<b>&quot;,
            ///     &quot;totalMass&quot;: &quot;2940&quot;,
            ///     &quot;unladenMass&quot;: &quot;2350&quot;,
            ///     &quot;useProperty&quot;: &quot;非营运&quot;,
            ///     &quot;vehicleState&quot;: &quot;正常&quot;,
            ///     &quot;vin&quot;: &quot;JT</b>*************&quot;,
            ///     &quot;wheelBase&quot;: &quot;2790&quot;
            /// }</para>
            /// </summary>
            [NameInMap("VehicleInfo")]
            [Validation(Required=false)]
            public string VehicleInfo { get; set; }

        }

    }

}
