// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240401.Models
{
    public class ListConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The field-level equality filter condition. The value is a URL-encoded JSON string (which decodes to a {&quot;fieldName&quot;: value} object). Multiple fields have an AND relationship, meaning all conditions must be met for a result to be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>%7B%22enabled%22%3Atrue%7D</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>page</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>pageSize</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
