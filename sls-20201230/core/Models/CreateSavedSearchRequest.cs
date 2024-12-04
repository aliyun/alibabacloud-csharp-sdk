// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateSavedSearchRequest : TeaModel {
        /// <summary>
        /// <para>The display name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>displayname</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The name of the Logstore to which the saved search belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-test-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the saved search. The name must be 3 to 63 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv in minutes</para>
        /// </summary>
        [NameInMap("savedsearchName")]
        [Validation(Required=false)]
        public string SavedsearchName { get; set; }

        /// <summary>
        /// <para>The query statement of the saved search. A query statement consists of a search statement and an analytic statement in the <c>Search statement|Analytic statement</c> format. For more information, see <a href="https://help.aliyun.com/document_detail/43772.html">Log search overview</a> and <a href="https://help.aliyun.com/document_detail/53608.html">Log analysis overview</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em>|select date_format(<b>time</b>-<b>time</b>%60, \&quot;%H:%i:%s\&quot;) as time, COUNT(</em>) as pv group by time</para>
        /// </summary>
        [NameInMap("searchQuery")]
        [Validation(Required=false)]
        public string SearchQuery { get; set; }

        /// <summary>
        /// <para>The topic of the logs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>theme</para>
        /// </summary>
        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
