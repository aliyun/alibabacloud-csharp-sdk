// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetUserDeviceWorkloadTrendRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint device ID. You can obtain this value from the following operations:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~GetUserDevice~~">GetUserDevice</a>: Queries the details of a user endpoint device.</description></item>
        /// <item><description><a href="~~ListUserDevices~~">ListUserDevices</a>: Queries user endpoint devices in batches.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36efa42d-2c32-c4dc-e3fc-8541e33a****</para>
        /// </summary>
        [NameInMap("DeviceTag")]
        [Validation(Required=false)]
        public string DeviceTag { get; set; }

        /// <summary>
        /// <para>The start time of the query time range. This value is a UNIX timestamp in seconds. The value must be greater than or equal to 0 and less than the value of To.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1769998785</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>The end time of the query time range. This value is a UNIX timestamp in seconds. The value must be greater than the value of From.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1771986521</para>
        /// </summary>
        [NameInMap("To")]
        [Validation(Required=false)]
        public long? To { get; set; }

        /// <summary>
        /// <para>The workload type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cpu</b>: CPU usage.</description></item>
        /// <item><description><b>mem</b>: memory usage.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}
