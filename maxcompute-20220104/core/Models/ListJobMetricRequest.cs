// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListJobMetricRequest : TeaModel {
        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        [NameInMap("project")]
        [Validation(Required=false)]
        public List<string> Project { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public List<string> Quota { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
