// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The list of application IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       &quot;5657d271-<b><b>-4f03-9bb2-431f942886bb&quot;,
        ///       &quot;5657d271-</b></b>-4f03-9bb2-431f942bbddd&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public string AppIds { get; set; }

        /// <summary>
        /// <para>Filters the application list by application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testapp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Filters the application list by cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c37aec2a-bcca-4ec1-<b><b>-</b></b>********</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The number of the page to return in a paged query. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Filters the application list by microservices namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>Filters applications by exact match of the microservices namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("LogicalRegionIdFilter")]
        [Validation(Required=false)]
        public string LogicalRegionIdFilter { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters the application list by resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek24j4s4b*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
