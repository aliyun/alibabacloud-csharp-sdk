// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class SavedSearch : TeaModel {
        /// <summary>
        /// <para>The display name of the saved search.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Method</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The name of the logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the saved search.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>savedsearch-name</para>
        /// </summary>
        [NameInMap("savedsearchName")]
        [Validation(Required=false)]
        public string SavedsearchName { get; set; }

        /// <summary>
        /// <para>The search statement or analytic statement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>status: 401 | SELECT remote_addr,COUNT(*) as pv GROUP by remote_addr ORDER by pv desc limit 5</para>
        /// </summary>
        [NameInMap("searchQuery")]
        [Validation(Required=false)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// <para>The topic of the log. The default value is an empty string (&quot;&quot;).</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic-test</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
