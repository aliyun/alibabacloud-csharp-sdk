// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class CreatePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The version of the port-specific mitigation policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Not specified</b>: creates a default surf DPI engine policy.</description></item>
        /// <item><description><b>2</b>: creates a new stream DPI engine policy.<remarks>
        /// <para>Only port-specific mitigation policies support this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PortVersion")]
        [Validation(Required=false)]
        public string PortVersion { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>l3</b>: IP-specific mitigation policy.</description></item>
        /// <item><description><b>l4</b>: port-specific mitigation policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
