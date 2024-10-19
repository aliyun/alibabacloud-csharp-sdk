// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateTrafficControlRequest : TeaModel {
        /// <summary>
        /// <para>The default throttling value for each API.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>436fa39b-b3b9-40c5-ae5d-ce3e000e38c5</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The name of the throttling policy. The name must be 4 to 50 characters in length and can contain letters, digits, and underscores (_). It cannot start with an underscore.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MINUTE</para>
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
