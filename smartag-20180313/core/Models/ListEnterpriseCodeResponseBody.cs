// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListEnterpriseCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about enterprise codes.</para>
        /// </summary>
        [NameInMap("EnterpriseCodes")]
        [Validation(Required=false)]
        public List<ListEnterpriseCodeResponseBodyEnterpriseCodes> EnterpriseCodes { get; set; }
        public class ListEnterpriseCodeResponseBodyEnterpriseCodes : TeaModel {
            /// <summary>
            /// <para>The enterprise code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12P**</para>
            /// </summary>
            [NameInMap("EnterpriseCode")]
            [Validation(Required=false)]
            public string EnterpriseCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the enterprise code is the default one.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for returning the next page when the data is returned in more than one page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0*****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A57EF84-D587-4CF9-B0C8-307488BF52C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
