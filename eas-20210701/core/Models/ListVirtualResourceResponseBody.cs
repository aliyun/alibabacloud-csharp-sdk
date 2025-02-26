// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListVirtualResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The virtual resource groups.</para>
        /// </summary>
        [NameInMap("VirtualResources")]
        [Validation(Required=false)]
        public List<ListVirtualResourceResponseBodyVirtualResources> VirtualResources { get; set; }
        public class ListVirtualResourceResponseBodyVirtualResources : TeaModel {
            /// <summary>
            /// <para>The time when the virtual resource group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-16T17:52:49Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The number of deployed services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServiceCount")]
            [Validation(Required=false)]
            public int? ServiceCount { get; set; }

            /// <summary>
            /// <para>The time when the virtual resource group was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-16T19:52:49Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The ID of the virtual resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eas-vr-npovr28onap1xxxxxx</para>
            /// </summary>
            [NameInMap("VirtualResourceId")]
            [Validation(Required=false)]
            public string VirtualResourceId { get; set; }

            /// <summary>
            /// <para>The name of the virtual resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyVirtualResource</para>
            /// </summary>
            [NameInMap("VirtualResourceName")]
            [Validation(Required=false)]
            public string VirtualResourceName { get; set; }

        }

    }

}
