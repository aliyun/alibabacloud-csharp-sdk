// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAppNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster to which the container belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the IDs of container clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cf77xxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The end timestamp of the query. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The days between the start timestamp and the end timestamp cannot exceed <b>seven</b> days.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1650470399999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The start timestamp of the query. Unit: milliseconds.</para>
        /// <remarks>
        /// <para>The days between the start timestamp and the end timestamp cannot exceed <b>seven</b> days.</para>
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
