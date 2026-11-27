// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeQualityDistributionStatDataRequest : TeaModel {
        /// <summary>
        /// <para>APP ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0rbd****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>End Time of the query, expressed as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615910399</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// <para>Start Time of the query, expressed as a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1615824000</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        /// <summary>
        /// <para>Statistical dimension. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>CHANNEL_ONLINE</b>: Statistics by channel online participant count.  </description></item>
        /// <item><description><b>NETWORK</b>: Statistics by network type.  </description></item>
        /// <item><description><b>OS</b>: Statistics by operating system type.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CHANNEL_ONLINE</para>
        /// </summary>
        [NameInMap("StatDim")]
        [Validation(Required=false)]
        public string StatDim { get; set; }

    }

}
