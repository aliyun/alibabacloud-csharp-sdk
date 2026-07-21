// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class CostTabDTO : TeaModel {
        /// <summary>
        /// <para>Tab UUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Tab display name</para>
        /// 
        /// <b>Example:</b>
        /// <para>全部</para>
        /// </summary>
        [NameInMap("label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>List of associated model types</para>
        /// </summary>
        [NameInMap("modelTypes")]
        [Validation(Required=false)]
        public List<string> ModelTypes { get; set; }

    }

}
