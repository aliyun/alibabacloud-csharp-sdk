// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DataResultValue : TeaModel {
        /// <summary>
        /// <para>The SQL ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad78a4e7d3ce81590c9dc2d5f4bc****</para>
        /// </summary>
        [NameInMap("sqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of failed executions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
