// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPopTrafficStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The end time for the data. This is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681293719</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The start time for the data. This is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1681035708</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
