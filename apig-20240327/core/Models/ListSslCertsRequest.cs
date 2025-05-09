// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListSslCertsRequest : TeaModel {
        /// <summary>
        /// <para>Name matching keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("certNameLike")]
        [Validation(Required=false)]
        public string CertNameLike { get; set; }

        /// <summary>
        /// <para>Domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fun.iot.evideocloud.com.cn</para>
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Page number, default is 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, default is 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
