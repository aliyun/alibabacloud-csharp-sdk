// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckTimeDimensionStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The end time in timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672285044000</para>
        /// </summary>
        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public long? EndTimeStamp { get; set; }

        /// <summary>
        /// <para>The start time in timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672385044000</para>
        /// </summary>
        [NameInMap("StartTimeStamp")]
        [Validation(Required=false)]
        public long? StartTimeStamp { get; set; }

        /// <summary>
        /// <para>The type of data statistics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CheckPassRate</b>: Check item pass rate.</description></item>
        /// <item><description><b>AssetPassRate</b>: Asset pass rate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AssetPassRate</para>
        /// </summary>
        [NameInMap("StatisticType")]
        [Validation(Required=false)]
        public string StatisticType { get; set; }

        /// <summary>
        /// <para>The list of cloud service providers.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
