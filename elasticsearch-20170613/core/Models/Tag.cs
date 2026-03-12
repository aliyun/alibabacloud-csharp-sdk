// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class Tag : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>env</para>
        /// </summary>
        [NameInMap("tagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("tagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
