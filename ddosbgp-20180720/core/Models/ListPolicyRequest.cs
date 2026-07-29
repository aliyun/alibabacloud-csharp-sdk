// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ListPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test**</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Settings the page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The applicable product type. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>l3</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
