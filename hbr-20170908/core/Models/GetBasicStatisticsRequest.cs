// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class GetBasicStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The data source type. The valid value is:</para>
        /// <list type="bullet">
        /// <item><description><b>ECS_FILE</b>: ECS File Backup.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_FILE</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
