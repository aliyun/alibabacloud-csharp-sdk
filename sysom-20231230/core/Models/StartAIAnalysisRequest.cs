// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class StartAIAnalysisRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs_sysom</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>python_test</para>
        /// </summary>
        [NameInMap("comms")]
        [Validation(Required=false)]
        public string Comms { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-wz9dej066kii4goqxxxx</para>
        /// </summary>
        [NameInMap("instance")]
        [Validation(Required=false)]
        public string Instance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2421,36547,10043</para>
        /// </summary>
        [NameInMap("pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
