// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBaselineCheckWhiteRecordShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of check item IDs.</para>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIdsShrink { get; set; }

        /// <summary>
        /// <para>The check item name for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("CheckItemFuzzy")]
        [Validation(Required=false)]
        public string CheckItemFuzzy { get; set; }

        /// <summary>
        /// <para>The page number of the current page when using paging. The value starts from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page when using paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of whitelist record IDs.</para>
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public string RecordIdsShrink { get; set; }

        /// <summary>
        /// <para>The data source. If this parameter is left empty, host data is queried by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: host</description></item>
        /// <item><description><b>agentless</b>: agentless.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
