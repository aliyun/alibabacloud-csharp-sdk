// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListUserAdOrganizationUnitsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAAAAA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The OUs of the AD domain.</para>
        /// </summary>
        [NameInMap("OUNames")]
        [Validation(Required=false)]
        public List<ListUserAdOrganizationUnitsResponseBodyOUNames> OUNames { get; set; }
        public class ListUserAdOrganizationUnitsResponseBodyOUNames : TeaModel {
            /// <summary>
            /// <para>The name of the OU.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wuying_computers</para>
            /// </summary>
            [NameInMap("DisplayOUName")]
            [Validation(Required=false)]
            public string DisplayOUName { get; set; }

            /// <summary>
            /// <para>The canonical name (CNAME) of the OU in the AD domain controller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com/wuying_computers</para>
            /// </summary>
            [NameInMap("OUName")]
            [Validation(Required=false)]
            public string OUName { get; set; }

            /// <summary>
            /// <para>The enterprise AD office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-485361****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
