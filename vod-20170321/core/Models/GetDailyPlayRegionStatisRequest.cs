// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDailyPlayRegionStatisRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-20</para>
        /// </summary>
        [NameInMap("Date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("MediaRegion")]
        [Validation(Required=false)]
        public string MediaRegion { get; set; }

    }

}
