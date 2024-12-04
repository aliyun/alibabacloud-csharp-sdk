// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Schedule : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0/5 * * * *</para>
        /// </summary>
        [NameInMap("cronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("delay")]
        [Validation(Required=false)]
        public int? Delay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60s</para>
        /// </summary>
        [NameInMap("interval")]
        [Validation(Required=false)]
        public string Interval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("runImmediately")]
        [Validation(Required=false)]
        public bool? RunImmediately { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>+0800</para>
        /// </summary>
        [NameInMap("timeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FixedRate</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
