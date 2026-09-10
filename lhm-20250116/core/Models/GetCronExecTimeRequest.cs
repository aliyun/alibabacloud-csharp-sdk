// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetCronExecTimeRequest : TeaModel {
        /// <summary>
        /// <para>The Cron expression. Replace spaces with plus signs <c>+</c> when passing the expression as a query parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0+0+0+<em>+</em>+?</para>
        /// </summary>
        [NameInMap("cronRule")]
        [Validation(Required=false)]
        public string CronRule { get; set; }

    }

}
