// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogItem : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<LogContent> Contents { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1690254376</para>
        /// </summary>
        [NameInMap("Time")]
        [Validation(Required=false)]
        public int? Time { get; set; }

    }

}
