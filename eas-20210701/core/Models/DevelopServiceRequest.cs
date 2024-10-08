// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DevelopServiceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to exit development mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: exits development mode.</description></item>
        /// <item><description>false (default): enters development mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Exit")]
        [Validation(Required=false)]
        public string Exit { get; set; }

    }

}
