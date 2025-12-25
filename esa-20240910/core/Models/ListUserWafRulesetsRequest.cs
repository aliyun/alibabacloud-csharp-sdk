// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListUserWafRulesetsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-xxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListUserWafRulesetsRequestQueryArgs QueryArgs { get; set; }
        public class ListUserWafRulesetsRequestQueryArgs : TeaModel {
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("NameLike")]
            [Validation(Required=false)]
            public string NameLike { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("OrderBy")]
            [Validation(Required=false)]
            public string OrderBy { get; set; }

        }

    }

}
