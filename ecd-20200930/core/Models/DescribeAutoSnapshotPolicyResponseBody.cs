// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeAutoSnapshotPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the queried automatic snapshot policies.</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicies")]
        [Validation(Required=false)]
        public List<DescribeAutoSnapshotPolicyResponseBodyAutoSnapshotPolicies> AutoSnapshotPolicies { get; set; }
        public class DescribeAutoSnapshotPolicyResponseBodyAutoSnapshotPolicies : TeaModel {
            /// <summary>
            /// <para>The time when the automatic snapshot policy was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-mm-ddthh:mm:ssz</c> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-11T09:14:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The cron expression that specifies when Elastic Desktop Service creates snapshots on the cloud computers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 5,7 ? * 2/2</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <para>The number of cloud computers to which the automatic snapshot policy is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DesktopNum")]
            [Validation(Required=false)]
            public int? DesktopNum { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The ID of the automatic snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-3e3bmfcdkjfl1****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The name of the automatic snapshot policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>snapshot01</para>
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// <para>The ID of the region to which the automatic snapshot policy belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The retention period of the automatic snapshots. Unit: days. Valid values: 1 to 180.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RetentionDays")]
            [Validation(Required=false)]
            public string RetentionDays { get; set; }

            /// <summary>
            /// <para>The status of the automatic snapshot policy.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Expire: The automatic snapshot policy cannot be used because you have overdue payments in your account.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Normal: The automatic snapshot policy is normal.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The points in time at which the auto snapshots were created.</para>
            /// <para>The parameter values are a JSON array. Example: <c>[&quot;0&quot;, &quot;1&quot;, ... &quot;23&quot;]</c>. A maximum of 24 points in time are returned. The points in time are separated with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;17&quot;,&quot;18&quot;]</para>
            /// </summary>
            [NameInMap("TimePoints")]
            [Validation(Required=false)]
            public string TimePoints { get; set; }

        }

        /// <summary>
        /// <para>The token that is used to start the next query. If this parameter is empty, all results haven been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A7F6612E-59CC-59F9-9DD1-91867FCC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
