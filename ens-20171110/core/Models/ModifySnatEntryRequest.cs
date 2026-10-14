// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifySnatEntryRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable IP affinity. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Description After you enable IP affinity, if multiple EIPs are associated with an SNAT entry, one client uses the same EIP to for communication. If IP affinity is disabled, the client uses a random EIP for communication.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EipAffinity")]
        [Validation(Required=false)]
        public bool? EipAffinity { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable carrier affinity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IspAffinity")]
        [Validation(Required=false)]
        public bool? IspAffinity { get; set; }

        /// <summary>
        /// <para>The ID of the SNAT entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>snat-5tfjp36fsrb36zs36faj0****</para>
        /// </summary>
        [NameInMap("SnatEntryId")]
        [Validation(Required=false)]
        public string SnatEntryId { get; set; }

        /// <summary>
        /// <para>The name of the SNAT entry. The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0</para>
        /// </summary>
        [NameInMap("SnatEntryName")]
        [Validation(Required=false)]
        public string SnatEntryName { get; set; }

        /// <summary>
        /// <para>Separate multiple EIPs in the SNAT entry with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>120.XXX.XXX.71</para>
        /// </summary>
        [NameInMap("SnatIp")]
        [Validation(Required=false)]
        public string SnatIp { get; set; }

    }

}
