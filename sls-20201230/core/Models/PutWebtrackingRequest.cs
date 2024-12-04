// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PutWebtrackingRequest : TeaModel {
        /// <summary>
        /// <para>The logs. Each element is a JSON object that indicates a log.</para>
        /// <remarks>
        /// <para> <b>Note</b>: The time in a log that is collected by using the web tracking feature is the time at which Simple Log Service receives the log. You do not need to configure the <b>time</b> field for each log. If this field exists, it is overwritten by the time at which Simple Log Service receives the log.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("__logs__")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Logs { get; set; }

        /// <summary>
        /// <para>The source of the logs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source</para>
        /// </summary>
        [NameInMap("__source__")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The tags of the logs.</para>
        /// </summary>
        [NameInMap("__tags__")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>The topic of the logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>topic</para>
        /// </summary>
        [NameInMap("__topic__")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
