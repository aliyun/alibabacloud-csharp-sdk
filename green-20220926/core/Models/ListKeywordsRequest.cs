// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListKeywordsRequest : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Library ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom_xxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Sort field.</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public Dictionary<string, string> Sort { get; set; }

        /// <summary>
        /// <para>Keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试词</para>
        /// </summary>
        [NameInMap("Word")]
        [Validation(Required=false)]
        public string Word { get; set; }

    }

}
