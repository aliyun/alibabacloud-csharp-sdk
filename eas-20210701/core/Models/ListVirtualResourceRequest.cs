// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListVirtualResourceRequest : TeaModel {
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

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
