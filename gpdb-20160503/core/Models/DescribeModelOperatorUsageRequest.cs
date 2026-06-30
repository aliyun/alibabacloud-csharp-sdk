// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeModelOperatorUsageRequest : TeaModel {
        [NameInMap("ApiKeyIds")]
        [Validation(Required=false)]
        public List<int?> ApiKeyIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-06-02T00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public string GroupBy { get; set; }

        [NameInMap("Keys")]
        [Validation(Required=false)]
        public List<string> Keys { get; set; }

        [NameInMap("ModelNames")]
        [Validation(Required=false)]
        public List<string> ModelNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-06-01T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
