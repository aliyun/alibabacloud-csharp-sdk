// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleMetaVerifyV2Request : TeaModel {
        /// <summary>
        /// <para>The ID card number.</para>
        /// <para>This parameter is required when VerifyMetaType is set to VEHICLE_3_META.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, enter the plaintext value.</description></item>
        /// <item><description>If ParamType is set to md5, enter the first 6 digits of the ID card number in plaintext + the MD5-encrypted date of birth (32-bit lowercase MD5) + the last 4 digits of the ID card number.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4****************1</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: not encrypted.</description></item>
        /// <item><description>md5: MD5-encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, enter the plaintext value.</description></item>
        /// <item><description>If ParamType is set to md5, enter the MD5-encrypted first character of the name (32-bit lowercase MD5) + the remaining characters of the name in plaintext.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The license plate number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, enter the plaintext value.</description></item>
        /// <item><description>If ParamType is set to md5, enter the license plate number excluding the last two characters in plaintext + the MD5-encrypted last two characters (32-bit lowercase MD5).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>陕A9****</para>
        /// </summary>
        [NameInMap("VehicleNum")]
        [Validation(Required=false)]
        public string VehicleNum { get; set; }

        /// <summary>
        /// <para>The vehicle type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("VehicleType")]
        [Validation(Required=false)]
        public string VehicleType { get; set; }

        /// <summary>
        /// <para>The verification type.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>VEHICLE_2_META: two-element verification. Verifies the name and license plate number.</description></item>
        /// <item><description>VEHICLE_3_META: three-element verification. Verifies the name, license plate number, and ID card number.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VEHICLE_3_META</para>
        /// </summary>
        [NameInMap("VerifyMetaType")]
        [Validation(Required=false)]
        public string VerifyMetaType { get; set; }

    }

}
