// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyUserIPSWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The traffic direction for the Internet Border.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public long? Direction { get; set; }

        /// <summary>
        /// <para>The IP version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of address in the Internet Border whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public long? ListType { get; set; }

        /// <summary>
        /// <para>The value of the Internet Border whitelist.</para>
        /// <list type="bullet">
        /// <item><description><para>If ListType is set to <c>Custom</c>: the name of the address book.</para>
        /// </description></item>
        /// <item><description><para>If ListType is set to <c>Address book</c>: the IPv4 address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>115.236.36.114/32</para>
        /// </summary>
        [NameInMap("ListValue")]
        [Validation(Required=false)]
        public string ListValue { get; set; }

        /// <summary>
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.100.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of source or destination for which the Internet Border whitelist takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("WhiteType")]
        [Validation(Required=false)]
        public long? WhiteType { get; set; }

    }

}
