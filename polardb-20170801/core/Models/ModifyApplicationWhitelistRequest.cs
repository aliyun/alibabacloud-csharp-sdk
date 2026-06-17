// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyApplicationWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The ID of the application subcomponent. If you specify this parameter, the whitelist modification takes effect only for this subcomponent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pac-*******************</para>
        /// </summary>
        [NameInMap("ComponentId")]
        [Validation(Required=false)]
        public string ComponentId { get; set; }

        /// <summary>
        /// <para>The method to modify the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Cover</b>: Overwrites the original IP address whitelist. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>Append</b>: Appends IP addresses.</para>
        /// </description></item>
        /// <item><description><para><b>Delete</b>: Deletes IP addresses.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Append</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// <para>The list of security group IDs. Separate multiple IDs with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-**************</para>
        /// </summary>
        [NameInMap("SecurityGroups")]
        [Validation(Required=false)]
        public string SecurityGroups { get; set; }

        /// <summary>
        /// <para>The name of the IP address group. The default value is <c>default</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("SecurityIPArrayName")]
        [Validation(Required=false)]
        public string SecurityIPArrayName { get; set; }

        /// <summary>
        /// <para>The IP addresses for the whitelist. Separate multiple IP addresses with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1,172.17.0.0/24</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

    }

}
