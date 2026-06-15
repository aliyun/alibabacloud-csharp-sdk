// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryDeviceStatRequest : TeaModel {
        /// <summary>
        /// <para>AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23267207</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is only valid for early Android and iOS dual-platform application types. If your application is a dual-platform application, specify this parameter as iOS or ANDROID to query the number of devices for each type. By default, it queries ALL types.</para>
        /// <para>The device type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>iOS</b>: iOS devices</para>
        /// </description></item>
        /// <item><description><para><b>ANDROID</b>: Android devices</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: All device types</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>iOS</para>
        /// </summary>
        [NameInMap("DeviceType")]
        [Validation(Required=false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time format follows the ISO8601 standard and uses UTC time, in the format YYYY-MM-DDThh:mm:ssZ.</para>
        /// <remarks>
        /// <para>The statistics end date is the end time\&quot;s day.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-07-29T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Query new devices or historical cumulative devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NEW</b>: New devices</para>
        /// </description></item>
        /// <item><description><para><b>TOTAL</b>: Cumulative devices</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TOTAL</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time format follows the ISO8601 standard and uses UTC time, in the format YYYY-MM-DDThh:mm:ssZ.</para>
        /// <remarks>
        /// <para>The statistics start date is 00:00 UTC+8 on the start time\&quot;s day.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-07-28T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
