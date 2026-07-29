// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyAttachmentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of protected objects.</para>
        /// </summary>
        [NameInMap("IpPortProtocolList")]
        [Validation(Required=false)]
        public string IpPortProtocolListShrink { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of rows per page in a paging query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f38f6520-92b7-451e-b520-9ab3********</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: default mitigation policy.</description></item>
        /// <item><description><b>l3</b>: IP-specific mitigation policy.</description></item>
        /// <item><description><b>l4</b>: port-specific mitigation policy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>l3</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The version of the port-specific mitigation policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Not specified</b>: queries the policy associations that attach to the default surf DPI engine.</description></item>
        /// <item><description><b>2</b>: queries the policy associations that attach to the new stream DPI engine.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PortVersion")]
        [Validation(Required=false)]
        public string PortVersion { get; set; }

    }

}
