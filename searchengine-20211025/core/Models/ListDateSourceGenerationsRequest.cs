// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDateSourceGenerationsRequest : TeaModel {
        /// <summary>
        /// <para>The data center where the data source is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj_vpc_domain_1</para>
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Specifies the index versions to be returned. Valid values:</para>
        /// <ol>
        /// <item><description>true (default): returns the index versions that are complete and not expired.</description></item>
        /// <item><description>false: returns all index versions.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("validStatus")]
        [Validation(Required=false)]
        public bool? ValidStatus { get; set; }

    }

}
