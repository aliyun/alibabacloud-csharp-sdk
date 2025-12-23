// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListABTestExperimentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D77D0DAF-790D-F5F5-A9C0-133738165014</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The experiment details.\
        /// For more information, see <a href="https://help.aliyun.com/document_detail/173617.html">ABTestExperiment</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListABTestExperimentsResponseBodyResult> Result { get; set; }
        public class ListABTestExperimentsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the experiment was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588842080</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The experiment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12888</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The group alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the experiment is in effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            /// <summary>
            /// <para>The experiment parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public Dictionary<string, object> Params { get; set; }

            /// <summary>
            /// <para>The percentage of traffic that is routed to the experiment.</para>
            /// <para>Valid values: [0,100]</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("traffic")]
            [Validation(Required=false)]
            public int? Traffic { get; set; }

            /// <summary>
            /// <para>The time when the experiment was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588842080</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

    }

}
