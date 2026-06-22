// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateUnknownThreatDetectMachineRequest : TeaModel {
        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>restart_study</b>: Restarts the learning process.</para>
        /// </description></item>
        /// <item><description><para><b>increment_study</b>: Starts incremental learning.</para>
        /// </description></item>
        /// <item><description><para><b>change_status</b>: Changes the status.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>restart_study</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The target status. This parameter applies only when <c>OperateType</c> is set to <c>change_status</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>monitoring</b>: Monitoring mode.</para>
        /// </description></item>
        /// <item><description><para><b>blocking</b>: Blocking mode.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>monitoring</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A list of server UUIDs.</para>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
