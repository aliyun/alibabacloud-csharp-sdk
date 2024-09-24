// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBClusterMaintainTimeRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-bp1r053byu48p****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The maintenance window of the cluster. It must be in the hh:mmZ-hh:mmZ format.</para>
        /// <remarks>
        /// <para>The interval must be 1 hour and start and end at the beginning of an hour.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22:00Z-23:00Z</para>
        /// </summary>
        [NameInMap("MaintainTime")]
        [Validation(Required=false)]
        public string MaintainTime { get; set; }

    }

}
