// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The end timestamp of the query. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The days between the start timestamp and the end timestamp cannot exceed <b>seven</b> days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656038940435</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start timestamp of the query. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The days between the start timestamp and the end timestamp cannot exceed <b>seven</b> days.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656038740435</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
