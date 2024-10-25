// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDiskIopsListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the disk. Format: d-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>\*.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-5tzm9wnhzlhjzcbtxo465****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the format of yyyy-MM-dd HH:mm:ss. The time range specified by the StartTime and EndTime parameters cannot exceed one day for a query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-14 23:59:59</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the format of yyyy-MM-dd HH:mm:ss.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-14 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
