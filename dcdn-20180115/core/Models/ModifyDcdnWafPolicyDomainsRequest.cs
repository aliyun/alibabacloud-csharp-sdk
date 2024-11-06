// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDcdnWafPolicyDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The domain names that you want to bind to the protection policy. You can specify up to 50 domain names. Separate multiple domain names with commas (,).</para>
        /// <remarks>
        /// <para>You can configure either <b>BindDomains</b> or <b>UnbindDomains</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,example2.com</para>
        /// </summary>
        [NameInMap("BindDomains")]
        [Validation(Required=false)]
        public string BindDomains { get; set; }

        /// <summary>
        /// <para>The association method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: replace.</description></item>
        /// <item><description>1: add.</description></item>
        /// <item><description>Default value: 0.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when you specify <b>BindDomains</b>. If you have associated a domain name indicated by <b>BindDomains</b> with the default protection policy, the <c>Policy.DefaultAndCustom.BindToSameDomain</c> error is returned.</para>
        /// </description></item>
        /// <item><description><para>You can only replace accelerated domain names that are bound to the default protection policy.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Method")]
        [Validation(Required=false)]
        public int? Method { get; set; }

        /// <summary>
        /// <para>The ID of the protection policy. You can specify only one ID in each request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000001</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        /// <summary>
        /// <para>The domain names that you want to unbind from the protection policy. You can specify up to 50 domain names. Separate multiple domain names with commas (,).</para>
        /// <remarks>
        /// <para>You can configure either <b>BindDomains</b> or <b>UnbindDomains</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example3.com</para>
        /// </summary>
        [NameInMap("UnbindDomains")]
        [Validation(Required=false)]
        public string UnbindDomains { get; set; }

    }

}
