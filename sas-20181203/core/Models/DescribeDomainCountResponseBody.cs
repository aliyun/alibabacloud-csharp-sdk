// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C286491D-4A2F-589A-B63B-D2AD3DA9BD71</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of root domains in the assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RootDomainsCount")]
        [Validation(Required=false)]
        public int? RootDomainsCount { get; set; }

        /// <summary>
        /// <para>The number of subdomains in the assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("SubDomainsCount")]
        [Validation(Required=false)]
        public int? SubDomainsCount { get; set; }

        /// <summary>
        /// <para>The total number of domain name assets returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalDomainsCount")]
        [Validation(Required=false)]
        public int? TotalDomainsCount { get; set; }

    }

}
