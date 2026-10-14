// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class EventMigrateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The data migration policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>abandon</c>: Does not migrate data. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>force_transfer</c>: Forces data migration.</para>
        /// </description></item>
        /// <item><description><para><c>try_transfer</c>: Attempts to migrate data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>abandon</para>
        /// </summary>
        [NameInMap("DataPolicy")]
        [Validation(Required=false)]
        public string DataPolicy { get; set; }

        /// <summary>
        /// <para>The ID of the system event.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-d71ff150945b9c02eb6ebc0016328468</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The type of the O\&amp;M task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>immediate</c>: Executes the task immediately.</para>
        /// </description></item>
        /// <item><description><para><c>scheduled</c>: Executes the task at the specified time.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immediate</para>
        /// </summary>
        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        /// <summary>
        /// <para>The instance password. This parameter is optional. If you do not specify a password, the system generates a random one.</para>
        /// <para>The password must be 8 to 30 characters long and contain uppercase letters, lowercase letters, and digits.</para>
        /// <para>Note: This parameter is not supported for scheduled execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAaa1234</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The scheduled execution time. This must be a Unix timestamp in milliseconds. This parameter is required when <c>OpsType</c> is set to <c>scheduled</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742452232000</para>
        /// </summary>
        [NameInMap("PlanTime")]
        [Validation(Required=false)]
        public long? PlanTime { get; set; }

        [NameInMap("PlanUtcTime")]
        [Validation(Required=false)]
        public string PlanUtcTime { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-55qi8m11rr53c4i964md8a00l</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
