// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListEnvironmentsRequest : TeaModel {
        /// <summary>
        /// <para>Environment alias, fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("aliasLike")]
        [Validation(Required=false)]
        public string AliasLike { get; set; }

        /// <summary>
        /// <para>Gateway ID, exact search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cptv6ktlhtgnqr73h8d1</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Gateway name, fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-gw</para>
        /// </summary>
        [NameInMap("gatewayNameLike")]
        [Validation(Required=false)]
        public string GatewayNameLike { get; set; }

        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>Environment name, fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("nameLike")]
        [Validation(Required=false)]
        public string NameLike { get; set; }

        /// <summary>
        /// <para>Page number, default is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, default is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2sy66mftleiq</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
