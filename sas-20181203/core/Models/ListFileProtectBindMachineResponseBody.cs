// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectBindMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of servers. The UUID of each server is returned.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<string> List { get; set; }

        /// <summary>
        /// <para>The paging information for the paged query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectBindMachineResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectBindMachineResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page for a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EE7B150-D67E-53FD-A52D-3E8E669A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
