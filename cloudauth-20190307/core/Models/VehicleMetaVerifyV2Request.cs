// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleMetaVerifyV2Request : TeaModel {
        /// <summary>
        /// <para>ID number.</para>
        /// <para>This is a required field when VerifyMetaType is VEHICLE_3_META.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When paramType is normal, enter plain text.</description></item>
        /// <item><description>When paramType is md5, enter the first 6 digits in plain text + MD5 (32 lowercase) of the birth date + the last 4 digits in plain text.</description></item>
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
        /// <para>Parameter type:</para>
        /// <list type="bullet">
        /// <item><description>normal: Unencrypted.</description></item>
        /// <item><description>md5: Md5 encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>Name</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When paramType is normal, enter plain text.</description></item>
        /// <item><description>When paramType is md5, enter the first character of the name as MD5 (32 lowercase) + the rest of the name in plain text.</description></item>
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
        /// <para>License plate number</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When paramType is normal, enter plain text.</description></item>
        /// <item><description>When paramType is md5, enter all but the last two characters in plain text + the last two characters as MD5 (32 lowercase).</description></item>
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
        /// <para>Vehicle type</para>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("VehicleType")]
        [Validation(Required=false)]
        public string VehicleType { get; set; }

        /// <summary>
        /// <para>Verification type</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>VEHICLE_2_META: Two-element verification, name + license plate number verification;</description></item>
        /// <item><description>VEHICLE_3_META: Three-element verification, name + license plate number + ID number verification;</description></item>
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
