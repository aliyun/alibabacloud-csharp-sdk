// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class CreateBroadcastVideoFromTemplateRequest : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BS1b2WNnRMu4ouRzT4clY9Jhg</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<TemplateVariable> Variables { get; set; }

        [NameInMap("videoOptions")]
        [Validation(Required=false)]
        public CreateBroadcastVideoFromTemplateRequestVideoOptions VideoOptions { get; set; }
        public class CreateBroadcastVideoFromTemplateRequestVideoOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("fps")]
            [Validation(Required=false)]
            public int? Fps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>720p</para>
            /// </summary>
            [NameInMap("resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("watermark")]
            [Validation(Required=false)]
            public bool? Watermark { get; set; }

        }

    }

}
