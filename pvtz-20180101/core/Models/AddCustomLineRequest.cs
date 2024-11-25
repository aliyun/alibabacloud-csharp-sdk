// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddCustomLineRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is not available. You can ignore it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INTRANET</para>
        /// </summary>
        [NameInMap("DnsCategory")]
        [Validation(Required=false)]
        public string DnsCategory { get; set; }

        /// <summary>
        /// <para>The IPv4 CIDR blocks.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ipv4s")]
        [Validation(Required=false)]
        public List<string> Ipv4s { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the custom line.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is not available. You can ignore it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL</para>
        /// </summary>
        [NameInMap("ShareScope")]
        [Validation(Required=false)]
        public string ShareScope { get; set; }

    }

}
