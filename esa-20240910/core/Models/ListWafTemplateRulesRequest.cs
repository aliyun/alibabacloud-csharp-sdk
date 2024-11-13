// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafTemplateRulesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListWafTemplateRulesRequestQueryArgs QueryArgs { get; set; }
        public class ListWafTemplateRulesRequestQueryArgs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>http_directory_traversal</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
