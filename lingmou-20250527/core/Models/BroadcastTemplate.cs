// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class BroadcastTemplate : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-28T10:11:28</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BS1b2WNnRMu4ouRzT4clY9Jhg</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-28T11:11:28</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<TemplateVariable> Variables { get; set; }

    }

}
