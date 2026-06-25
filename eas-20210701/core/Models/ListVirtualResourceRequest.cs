// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListVirtualResourceRequest : TeaModel {
        /// <summary>
        /// <para>The sorting order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Desc: Descending order.</para>
        /// </description></item>
        /// <item><description><para>Asc: Ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The page number for the list of virtual resource groups. The value starts from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of virtual resource groups to display on each page. The default value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field that is used to sort the results. By default, the results are sorted by timestamp in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
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
