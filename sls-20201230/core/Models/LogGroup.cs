// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogGroup : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LogItems")]
        [Validation(Required=false)]
        public List<LogItem> LogItems { get; set; }

        [NameInMap("LogTags")]
        [Validation(Required=false)]
        public List<LogTag> LogTags { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>192.1.1.1</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>topic-test</para>
        /// </summary>
        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
