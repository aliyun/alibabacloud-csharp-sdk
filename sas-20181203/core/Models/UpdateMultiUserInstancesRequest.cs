// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateMultiUserInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The member instances.</para>
        /// </summary>
        [NameInMap("MemberInstances")]
        [Validation(Required=false)]
        public List<UpdateMultiUserInstancesRequestMemberInstances> MemberInstances { get; set; }
        public class UpdateMultiUserInstancesRequestMemberInstances : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account UID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104675</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The anti-ransomware capacity assigned to the member. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public long? AntiRansomwareCapacity { get; set; }

            /// <summary>
            /// <para>The billing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAID</b>: upfront.</description></item>
            /// <item><description><b>POSTPAID</b> (default): pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAID</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The number of cloud platform configuration check scans assigned to the member. Unit: scans per month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public long? CspmCapacity { get; set; }

            [NameInMap("CspmInstanceCapacity")]
            [Validation(Required=false)]
            public long? CspmInstanceCapacity { get; set; }

            /// <summary>
            /// <para>The number of honeypot quotas assigned to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public long? HoneypotCapacity { get; set; }

            /// <summary>
            /// <para>The number of image scan quotas assigned to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public long? ImageScanCapacity { get; set; }

            /// <summary>
            /// <para>The Security Center instance ID purchased by the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-p0anpb26my69</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>ADD</b>: increase </description></item>
            /// <item><description><b>CHANGE</b>: update</description></item>
            /// <item><description><b>DEL</b>: delete</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHANGE</para>
            /// </summary>
            [NameInMap("OptType")]
            [Validation(Required=false)]
            public string OptType { get; set; }

            /// <summary>
            /// <para>The number of application protection quotas assigned to the member. Unit: quotas per month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public long? RaspCapacity { get; set; }

            /// <summary>
            /// <para>The number of malicious file detection SDK quotas assigned to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public long? SdkCapacity { get; set; }

            /// <summary>
            /// <para>The log storage capacity assigned to the member. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SlsCapacity")]
            [Validation(Required=false)]
            public long? SlsCapacity { get; set; }

            /// <summary>
            /// <para>The instance status of the member accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: active.</description></item>
            /// <item><description><b>2</b>: expired.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The threat analysis capacity assigned to the member. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ThreatAnalysisCapacity")]
            [Validation(Required=false)]
            public long? ThreatAnalysisCapacity { get; set; }

            /// <summary>
            /// <para>The log ingestion traffic for threat detection and response assigned to the member. Unit: GB/day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public long? ThreatAnalysisFlow { get; set; }

            /// <summary>
            /// <para>The Security Center edition to bind. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition </description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Advanced Edition</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The authorization usage information of the member accounts.</para>
            /// </summary>
            [NameInMap("VersionSummary")]
            [Validation(Required=false)]
            public List<UpdateMultiUserInstancesRequestMemberInstancesVersionSummary> VersionSummary { get; set; }
            public class UpdateMultiUserInstancesRequestMemberInstancesVersionSummary : TeaModel {
                /// <summary>
                /// <para>The number of authorized cores assigned to the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public long? CoreCount { get; set; }

                /// <summary>
                /// <para>The number of authorized instances assigned to the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public long? EcsCount { get; set; }

                /// <summary>
                /// <para>The Security Center edition of the member accounts. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition </description></item>
                /// <item><description><b>3</b>: Enterprise Edition</description></item>
                /// <item><description><b>5</b>: Premium Edition</description></item>
                /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
                /// <item><description><b>7</b>: Ultimate Edition   </description></item>
                /// <item><description><b>8</b>: multi-edition   </description></item>
                /// <item><description><b>10</b>: value-added services only</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The number of web tamper-proofing authorization quotas assigned to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("WebLockCapacity")]
            [Validation(Required=false)]
            public long? WebLockCapacity { get; set; }

        }

    }

}
