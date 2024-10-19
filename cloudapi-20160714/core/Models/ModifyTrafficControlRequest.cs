// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyTrafficControlRequest : TeaModel {
        /// <summary>
        /// <para>The default throttling value for each API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ApiDefault")]
        [Validation(Required=false)]
        public int? ApiDefault { get; set; }

        /// <summary>
        /// <para>The default throttling value for each app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("AppDefault")]
        [Validation(Required=false)]
        public int? AppDefault { get; set; }

        /// <summary>
        /// <para>The description of the throttling policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ThrottlingTestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The security token included in the WebSocket request header. The system uses this token to authenticate the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4223a10e-eed3-46a6-8b7c-23003f488153</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the throttling policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf123456</para>
        /// </summary>
        [NameInMap("TrafficControlId")]
        [Validation(Required=false)]
        public string TrafficControlId { get; set; }

        /// <summary>
        /// <para>The throttling policy name. The name must be 4 to 50 characters in length and can contain letters, digits, and underscores (_). It cannot start with an underscore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ThrottlingTest</para>
        /// </summary>
        [NameInMap("TrafficControlName")]
        [Validation(Required=false)]
        public string TrafficControlName { get; set; }

        /// <summary>
        /// <para>The unit to be used in the throttling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SECOND</b></description></item>
        /// <item><description><b>MINUTE</b></description></item>
        /// <item><description><b>HOUR</b></description></item>
        /// <item><description><b>DAY</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HOUR</para>
        /// </summary>
        [NameInMap("TrafficControlUnit")]
        [Validation(Required=false)]
        public string TrafficControlUnit { get; set; }

        /// <summary>
        /// <para>The default throttling value for each user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("UserDefault")]
        [Validation(Required=false)]
        public int? UserDefault { get; set; }

    }

}
