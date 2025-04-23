// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListAuthorizationsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>auth-433aead756057ffec22d5b1ef27ac</para>
        /// </summary>
        [NameInMap("authorizationId")]
        [Validation(Required=false)]
        public string AuthorizationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>others</para>
        /// </summary>
        [NameInMap("authorizationType")]
        [Validation(Required=false)]
        public string AuthorizationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
