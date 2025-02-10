// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListPagesRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Valid values: <b>1 to 100000</b>. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public ListPagesRequestQueryArgs QueryArgs { get; set; }
        public class ListPagesRequestQueryArgs : TeaModel {
            [NameInMap("NameDescriptionLike")]
            [Validation(Required=false)]
            public string NameDescriptionLike { get; set; }

        }

    }

}
