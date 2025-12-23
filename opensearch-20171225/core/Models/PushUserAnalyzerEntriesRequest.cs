// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class PushUserAnalyzerEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The entries of the custom analyzer.</para>
        /// </summary>
        [NameInMap("entries")]
        [Validation(Required=false)]
        public List<PushUserAnalyzerEntriesRequestEntries> Entries { get; set; }
        public class PushUserAnalyzerEntriesRequestEntries : TeaModel {
            /// <summary>
            /// <para>The operation to be performed on the entries.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>add</description></item>
            /// <item><description>delete</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;add&quot;</para>
            /// </summary>
            [NameInMap("cmd")]
            [Validation(Required=false)]
            public string Cmd { get; set; }

            /// <summary>
            /// <para>The key to be used to query entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;testvalue&quot;</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Specifies whether to further analyze the terms that are generated after the search query is analyzed.</para>
            /// <para>Default value: true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("splitEnabled")]
            [Validation(Required=false)]
            public bool? SplitEnabled { get; set; }

            /// <summary>
            /// <para>The analysis result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;test value&quot;</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. This parameter is only used to check whether the data source is valid. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
