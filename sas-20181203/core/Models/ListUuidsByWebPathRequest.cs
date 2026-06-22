// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListUuidsByWebPathRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page to display in a paging query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to display on each page in a paging query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the web path. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>def</b>: automatically identified by the system</description></item>
        /// <item><description><b>customize</b>: manually added.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>def</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The web path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/www****</para>
        /// </summary>
        [NameInMap("WebPath")]
        [Validation(Required=false)]
        public string WebPath { get; set; }

    }

}
