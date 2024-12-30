// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of results to return. Valid values: 1 to 100. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of marker.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NWQ1Yjk4YmI1ZDRlYmU1Y2E0YWE0NmJhYWJmODBhNDQ2NzhlMTRhMg</para>
        /// </summary>
        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The ID of the parent domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("parent_domain_id")]
        [Validation(Required=false)]
        public string ParentDomainId { get; set; }

        [NameInMap("service_code")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
