// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class VehicleInsureQueryRequest : TeaModel {
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
        /// <item><description>When <c>paramType</c> is set to <c>normal</c>, enter the plain text.</description></item>
        /// <item><description>When <c>paramType</c> is set to <c>md5</c>, enter the plain text of all but the last two characters of the license plate + the MD5 encryption (32 lowercase characters) of the last two characters of the license plate.</description></item>
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
        /// <para>Driver\&quot;s license vehicle type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02</para>
        /// </summary>
        [NameInMap("VehicleType")]
        [Validation(Required=false)]
        public string VehicleType { get; set; }

        /// <summary>
        /// <para>Vehicle identification code, i.e., the vehicle VIN</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is set to <c>normal</c>, enter the plain text.</description></item>
        /// <item><description>When <c>paramType</c> is set to <c>md5</c>, enter the plain text of all but the last four characters of the VIN + the MD5 encryption (32 lowercase characters) of the last four characters of the VIN.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>LB**************</para>
        /// </summary>
        [NameInMap("Vin")]
        [Validation(Required=false)]
        public string Vin { get; set; }

    }

}
