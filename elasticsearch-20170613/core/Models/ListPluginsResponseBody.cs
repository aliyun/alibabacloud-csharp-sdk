// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the plug-in.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListPluginsResponseBodyHeaders Headers { get; set; }
        public class ListPluginsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The address of the plug-in description document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The return results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A5D8E74-565C-43DC-B031-29289FA9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the plug-in.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListPluginsResponseBodyResult> Result { get; set; }
        public class ListPluginsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The source type of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IK analysis plug-in for Elasticsearch.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>analysis-ik</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The name of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx.html">https://xxxx.html</a></para>
            /// </summary>
            [NameInMap("specificationUrl")]
            [Validation(Required=false)]
            public string SpecificationUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INSTALLED</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
