// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListKibanaPluginsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request header.</para>
        /// </summary>
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListKibanaPluginsResponseBodyHeaders Headers { get; set; }
        public class ListKibanaPluginsResponseBodyHeaders : TeaModel {
            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public int? XTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11234B4A-34CE-473B-8E61-AD95702E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the plug-ins.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListKibanaPluginsResponseBodyResult> Result { get; set; }
        public class ListKibanaPluginsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The description of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customize DSL statements to query data.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bsearch_querybuilder</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The source of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SYSTEM</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The URL of the introduction to the plug-in. The value null is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxx">https://xxxx</a></para>
            /// </summary>
            [NameInMap("specificationUrl")]
            [Validation(Required=false)]
            public string SpecificationUrl { get; set; }

            /// <summary>
            /// <para>The installation status of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INSTALLED</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

    }

}
