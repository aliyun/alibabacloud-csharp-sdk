// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyVpcFirewallIPSWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The type of the list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: user-defined</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: address book</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ListType")]
        [Validation(Required=false)]
        public long? ListType { get; set; }

        /// <summary>
        /// <para>The value that corresponds to the list type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.130.0.0/20,10.130.17.11/32</para>
        /// </summary>
        [NameInMap("ListValue")]
        [Validation(Required=false)]
        public string ListValue { get; set; }

        /// <summary>
        /// <para>The UID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1415189284827022</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <para>The instance ID of the VPC firewall.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vfw-d7b8ce273791475b9b0b</para>
        /// </summary>
        [NameInMap("VpcFirewallId")]
        [Validation(Required=false)]
        public string VpcFirewallId { get; set; }

        /// <summary>
        /// <para>The type of the whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: destination</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: source</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WhiteType")]
        [Validation(Required=false)]
        public long? WhiteType { get; set; }

    }

}
