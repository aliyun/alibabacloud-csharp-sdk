// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListDataDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The query request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListQuery")]
        [Validation(Required=false)]
        public ListDataDomainsRequestListQuery ListQuery { get; set; }
        public class ListDataDomainsRequestListQuery : TeaModel {
            /// <summary>
            /// <para>The IDs of the business units to which the data domains belong.</para>
            /// </summary>
            [NameInMap("BizUnitIdList")]
            [Validation(Required=false)]
            public List<long?> BizUnitIdList { get; set; }

            /// <summary>
            /// <para>The search keyword. You can search by data domain name, code, or description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            /// <summary>
            /// <para>The IDs of the parent data domains.</para>
            /// </summary>
            [NameInMap("ParentIdList")]
            [Validation(Required=false)]
            public List<long?> ParentIdList { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

    }

}
