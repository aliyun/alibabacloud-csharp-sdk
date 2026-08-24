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
        /// <para>Separate multiple IP addresses with commas (,). IP addresses cannot be duplicated. A maximum of 1000 IP addresses are supported.</para>
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
        /// <para>The name of the IP whitelist template. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Contains only lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Starts with a letter and ends with a letter or digit.</para>
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
