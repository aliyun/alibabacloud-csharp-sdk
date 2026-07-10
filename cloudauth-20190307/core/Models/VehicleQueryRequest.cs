// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleQueryRequest : TeaModel {
        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: not encrypted.</description></item>
        /// <item><description><b>md5</b>: MD5-encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The license plate number.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, enter the plaintext license plate number.</description></item>
        /// <item><description>If ParamType is set to md5, enter the plaintext of the license plate number excluding the last two characters, concatenated with the MD5-encrypted value of the last two characters (32-bit lowercase MD5).</description></item>
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

    }

}
