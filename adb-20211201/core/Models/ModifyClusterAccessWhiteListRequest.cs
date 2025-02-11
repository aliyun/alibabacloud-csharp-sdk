// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyClusterAccessWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The attribute of the IP address whitelist. By default, this parameter is empty.</para>
        /// <remarks>
        /// <para>Whitelists with the hidden attribute are not displayed in the console. Those whitelists are used to access Data Transmission Service (DTS) and PolarDB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hidden</para>
        /// </summary>
        [NameInMap("DBClusterIPArrayAttribute")]
        [Validation(Required=false)]
        public string DBClusterIPArrayAttribute { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist. If you do not specify this parameter, the Default whitelist is modified.</para>
        /// <list type="bullet">
        /// <item><description>The whitelist name must be 2 to 32 characters in length. The name can contain lowercase letters, digits, and underscores (_). The name must start with a lowercase letter and end with a lowercase letter or a digit.</description></item>
        /// <item><description>Each cluster supports up to 50 IP address whitelists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBClusterIPArrayName")]
        [Validation(Required=false)]
        public string DBClusterIPArrayName { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp11q28kvl688****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The method used to modify the IP address whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b> (default)</description></item>
        /// <item><description><b>Append</b></description></item>
        /// <item><description><b>Delete</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// <para>The IP addresses in an IP address whitelist of a cluster. Separate multiple IP addresses with commas (,). You can add a maximum of 500 different IP addresses to a whitelist. The entries in the IP address whitelist must be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>IP addresses, such as 10.23.XX.XX.</description></item>
        /// <item><description>CIDR blocks, such as 10.23.xx.xx/24. In this example, 24 indicates that the prefix of each IP address in the IP whitelist is 24 bits in length. You can replace 24 with a value within the range of 1 to 32.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.23.xx.xx</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
