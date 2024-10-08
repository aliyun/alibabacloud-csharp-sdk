// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSitesRequest : TeaModel {
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        [NameInMap("Coverage")]
        [Validation(Required=false)]
        public string Coverage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("OnlyEnterprise")]
        [Validation(Required=false)]
        public bool? OnlyEnterprise { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PlanSubscribeType")]
        [Validation(Required=false)]
        public string PlanSubscribeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-aekzd3styujvyei</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fuzzy</para>
        /// </summary>
        [NameInMap("SiteSearchType")]
        [Validation(Required=false)]
        public string SiteSearchType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public List<ListSitesRequestTagFilter> TagFilter { get; set; }
        public class ListSitesRequestTagFilter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>tag1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
