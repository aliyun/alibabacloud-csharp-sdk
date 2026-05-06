// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListModelTemplatesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListModelTemplatesResponseBodyData> Data { get; set; }
        public class ListModelTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>OpenClaw</para>
            /// </summary>
            [NameInMap("AgentProvider")]
            [Validation(Required=false)]
            public string AgentProvider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;defaults&quot;: {
            ///         &quot;model&quot;: {
            ///             &quot;primary&quot;: &quot;bailian/qwen3.5-plus&quot;
            ///         }
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasModel")]
            [Validation(Required=false)]
            public bool? HasModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mt-xxxx</para>
            /// </summary>
            [NameInMap("ModelTemplateId")]
            [Validation(Required=false)]
            public string ModelTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model-template-001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
