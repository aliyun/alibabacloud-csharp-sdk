// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryUserListRequest : TeaModel {
        /// <summary>
        /// <para>The keyword to search for organization members by username or nickname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number to return.</para>
        /// <list type="bullet">
        /// <item><description><para>Starting value: 1</para>
        /// </description></item>
        /// <item><description><para>Default value: 1</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of organization members to return per page.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 10</para>
        /// </description></item>
        /// <item><description><para>Maximum value: 1000</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
