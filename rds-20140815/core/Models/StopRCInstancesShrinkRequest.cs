// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class StopRCInstancesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The batch operation mode. Set the value to <b>AllTogether</b>. In this mode, if all instances are stopped, a success message is returned. If an instance fails the verification, none of the instances can be stopped and an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AllTogether</para>
        /// </summary>
        [NameInMap("BatchOptimization")]
        [Validation(Required=false)]
        public string BatchOptimization { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully stop the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: forcefully stops the instance. If an instance fails to stop due to system or network issues, a forced stop can be triggered, <b>though it may result in data loss.</b></description></item>
        /// <item><description><b>false</b>: does not forcefully stop the instance. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// <para>The node IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/26243.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
