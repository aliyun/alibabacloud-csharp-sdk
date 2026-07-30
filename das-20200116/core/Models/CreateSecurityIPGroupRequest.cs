// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class CreateSecurityIPGroupRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses in the whitelist template.</para>
        /// <remarks>
        /// <para>Separate multiple IP addresses with commas (,). The IP addresses cannot be repeated. You can add up to 1,000 IP addresses.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
        /// </summary>
        [NameInMap("GIpList")]
        [Validation(Required=false)]
        public string GIpList { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Consists of lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Starts with a letter and ends with a letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>Is 2 to 120 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_123</para>
        /// </summary>
        [NameInMap("GlobalIgName")]
        [Validation(Required=false)]
        public string GlobalIgName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

    }

}
