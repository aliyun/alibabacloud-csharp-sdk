// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Chart : TeaModel {
        /// <summary>
        /// <para>The action.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public Dictionary<string, object> Action { get; set; }

        /// <summary>
        /// <para>The display configuration of the chart.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("display")]
        [Validation(Required=false)]
        public Dictionary<string, object> Display { get; set; }

        /// <summary>
        /// <para>The query statement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>(*)| SELECT date_format(<b>time</b> - <b>time</b> % 60, \&quot;%H:%i:%s\&quot;) as time, count(1) as count GROUP BY time ORDER BY time</para>
        /// </summary>
        [NameInMap("search")]
        [Validation(Required=false)]
        public Dictionary<string, object> Search { get; set; }

        /// <summary>
        /// <para>The title of the chart.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-chart</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The type of the chart.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>linepro</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
