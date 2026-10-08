// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteRCInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run for this release operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Performs a dry run without releasing the instance.</description></item>
        /// <item><description><b>false</b> (default): Sends a normal request and directly releases the instance after the request passes the check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully release running instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Yes</b>: Forcefully releases the instances.</description></item>
        /// <item><description><b>No</b> (default): Does not forcefully release the instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Yes</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The instance details.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>A reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("TerminateSubscription")]
        [Validation(Required=false)]
        public bool? TerminateSubscription { get; set; }

    }

}
