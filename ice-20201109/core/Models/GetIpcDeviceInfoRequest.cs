// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetIpcDeviceInfoRequest : TeaModel {
        /// <summary>
        /// <para>Capability. Default value is understand. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>understand: understanding</para>
        /// </description></item>
        /// <item><description><para>understand-reid: understanding with reid</para>
        /// </description></item>
        /// <item><description><para>search: search</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>understand</para>
        /// </summary>
        [NameInMap("Capability")]
        [Validation(Required=false)]
        public string Capability { get; set; }

        /// <summary>
        /// <para>Device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d123</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>End Time. UTC time in the format yyyy-MM-ddTHH:mm:ssZ. The difference between EndTime and StartTime must not exceed 180 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-02-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Page number for paging. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Page size, which specifies the number of entries displayed per page. Default value is 10. Maximum value is 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Start Time. UTC time in the format yyyy-MM-ddTHH:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
