// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class DisassociatePrincipalFromPortfolioRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the product portfolio.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>port-bp1yt7582g****</para>
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// <para>The ID of the RAM entity.</para>
        /// <para>For more information about how to obtain the ID of a RAM user, see <a href="https://help.aliyun.com/document_detail/28681.html">GetUser</a>.</para>
        /// <para>For more information about how to obtain the ID of a RAM role, see <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24477111603637****</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The type of the Resource Access Management (RAM) entity. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RamUser: a RAM user</description></item>
        /// <item><description>RamRole: a RAM role</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RamUser</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

    }

}
