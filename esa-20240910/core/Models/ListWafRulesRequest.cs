// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafRulesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListWafRulesRequestQueryArgs QueryArgs { get; set; }
        public class ListWafRulesRequestQueryArgs : TeaModel {
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("IdNameLike")]
            [Validation(Required=false)]
            public string IdNameLike { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("NameLike")]
            [Validation(Required=false)]
            public string NameLike { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>position</para>
            /// </summary>
            [NameInMap("OrderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000001</para>
            /// </summary>
            [NameInMap("RulesetId")]
            [Validation(Required=false)]
            public long? RulesetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
