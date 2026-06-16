// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListCustomDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The custom domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mydomain.com</para>
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The domain type used for filtering. Valid values: STANDARD and SANDBOX.</para>
        /// </summary>
        [NameInMap("domainType")]
        [Validation(Required=false)]
        public string DomainType { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the resource associated with the custom domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-1</para>
        /// </summary>
        [NameInMap("resourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>The type of the resource associated with the custom domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>runtime</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
