// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class BatchEventMigrateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The details of events.</para>
        /// </summary>
        [NameInMap("EventInfos")]
        [Validation(Required=false)]
        public List<BatchEventMigrateInstanceRequestEventInfos> EventInfos { get; set; }
        public class BatchEventMigrateInstanceRequestEventInfos : TeaModel {
            /// <summary>
            /// <para>The data migration policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>abandon: does not migrate data. This is the default value.</description></item>
            /// <item><description>force_transfer: forcibly migrates data.</description></item>
            /// <item><description>try_transfer: Migrate data as much as possible.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>abandon</para>
            /// </summary>
            [NameInMap("DataPolicy")]
            [Validation(Required=false)]
            public string DataPolicy { get; set; }

            /// <summary>
            /// <para>Event ID e-\*.</para>
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
            /// <item><description>immediate</description></item>
            /// <item><description>scheduled</description></item>
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
            /// <para>The password of the instance. This parameter is optional. If you do not specify this parameter, a random password is used.</para>
            /// <para>The password must be 8 to 30 characters in length. The password must contain uppercase letters, lowercase letters, digits, and special characters.</para>
            /// <para>Note that you cannot enter a password for scheduled execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AAaa1234</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The execution time of the reservation. The timestamp is measured in milliseconds. If the OpsType parameter is set to scheduled, this parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1742452232000</para>
            /// </summary>
            [NameInMap("PlanTime")]
            [Validation(Required=false)]
            public long? PlanTime { get; set; }

            /// <summary>
            /// <para>Resource ID i-\*.</para>
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
