// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAppNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cf77xxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The timestamp of the end time. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The difference between the start timestamp and the end timestamp cannot exceed <b>7</b> days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1650470399999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The timestamp of the start time. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The difference between the start timestamp and the end timestamp cannot exceed <b>7</b> days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1649260800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
