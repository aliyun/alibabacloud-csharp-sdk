// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class AddAutoCcBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>The IP addresses that you want to manage. This parameter is a JSON string. The string contains the following field:</para>
        /// <list type="bullet">
        /// <item><description><b>src</b>: the IP address. This field is required and must be of the STRING type.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can manually add up to 2,000 IP addresses to the IP address blacklist. Separate multiple IP addresses with spaces or line breaks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;src&quot;:&quot;198.51.XX.XX&quot;},{&quot;src&quot;:&quot;198.52.XX.XX&quot;}]</para>
        /// </summary>
        [NameInMap("Blacklist")]
        [Validation(Required=false)]
        public string Blacklist { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public int? ExpireTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
