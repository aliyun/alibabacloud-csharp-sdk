// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class BatchEventMigrateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The list of events.</para>
        /// </summary>
        [NameInMap("EventInfos")]
        [Validation(Required=false)]
        public List<BatchEventMigrateInstanceRequestEventInfos> EventInfos { get; set; }
        public class BatchEventMigrateInstanceRequestEventInfos : TeaModel {
            /// <summary>
            /// <para>The data migration policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>abandon: Does not migrate data. This is the default value.</description></item>
            /// <item><description>force_transfer: Performs forcible migration of EPS resource data.</description></item>
            /// <item><description>try_transfer: Migrates data on a best-effort basis.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>abandon</para>
            /// </summary>
            [NameInMap("DataPolicy")]
            [Validation(Required=false)]
            public string DataPolicy { get; set; }

            /// <summary>
            /// <para>The event ID, in the format of e-*.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e-d71ff150945b9c02eb6ebc0016328468</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The O&amp;M task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>immediate: immediate execution.</description></item>
            /// <item><description>scheduled: scheduled execution.</description></item>
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
            /// <para>The instance password. This parameter is optional. If you do not specify this parameter, a random password is used.</para>
            /// <para>The password must be 8 to 30 characters in length and must contain uppercase letters, lowercase letters, and digits.</para>
            /// <para>Note: Password specification is not supported for scheduled execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAaa1234</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The scheduled execution time. The value is a timestamp in milliseconds.
            /// This parameter is required when OpsType is set to scheduled.</para>
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
            /// <para>The resource ID, in the format of i-*.</para>
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

}
