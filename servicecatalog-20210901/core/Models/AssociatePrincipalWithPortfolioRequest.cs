// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class AssociatePrincipalWithPortfolioRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>port-bp1yt7582g****</para>
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24477111603637****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user/userName</para>
        /// </summary>
        [NameInMap("PrincipalPattern")]
        [Validation(Required=false)]
        public string PrincipalPattern { get; set; }

        /// <summary>
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
