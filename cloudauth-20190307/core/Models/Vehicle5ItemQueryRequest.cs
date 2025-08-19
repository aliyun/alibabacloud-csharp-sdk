// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Vehicle5ItemQueryRequest : TeaModel {
        /// <summary>
        /// <para>Parameter type:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: Unencrypted.</description></item>
        /// <item><description><b>md5</b>: MD5 encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>License plate number</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When paramType is set to normal, enter the plain text.</description></item>
        /// <item><description>When paramType is set to md5, enter the plain text of all but the last two characters of the license plate + MD5 encryption (32-bit lowercase MD5) of the last two characters.</description></item>
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
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>02: Ordinary passenger car</description></item>
        /// <item><description>52: New energy passenger car</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("VehicleType")]
        [Validation(Required=false)]
        public string VehicleType { get; set; }

    }

}
