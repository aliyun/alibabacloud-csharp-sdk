// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeScreenScoreThreadRequest : TeaModel {
        /// <summary>
        /// <para>The end time as a timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1668064495000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The source of the security score. If left empty, the default value is Security Center. Valid values:</para>
        /// <para>0: Security Center.</para>
        /// <para>1: Alibaba Cloud ApsaraDB console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public int? Source { get; set; }

        /// <summary>
        /// <para>The start time as a timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1651290987000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
