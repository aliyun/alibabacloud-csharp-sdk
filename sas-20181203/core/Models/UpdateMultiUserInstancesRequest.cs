// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateMultiUserInstancesRequest : TeaModel {
        /// <summary>
        /// <para>Member instances.</para>
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
            /// <para>Anti-ransomware capacity allocated to the member, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public long? AntiRansomwareCapacity { get; set; }

            /// <summary>
            /// <para>Charge type, values:</para>
            /// <list type="bullet">
            /// <item><description><b>PREPAID</b>: Prepaid.</description></item>
            /// <item><description><b>POSTPAID</b> (default): Postpaid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAID</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>Cloud platform configuration check scan count allocated to the member. Unit: times per month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public long? CspmCapacity { get; set; }

            /// <summary>
            /// <para>Honeypot authorization count allocated to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public long? HoneypotCapacity { get; set; }

            /// <summary>
            /// <para>Image scan authorization count allocated to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public long? ImageScanCapacity { get; set; }

            /// <summary>
            /// <para>The Cloud Security Center instance ID purchased by the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas-p0anpb26my69</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Operation type. Values:  </para>
            /// <list type="bullet">
            /// <item><description><b>ADD</b>: Add </description></item>
            /// <item><description><b>CHANGE</b>: Change</description></item>
            /// <item><description><b>DEL</b>: Delete</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHANGE</para>
            /// </summary>
            [NameInMap("OptType")]
            [Validation(Required=false)]
            public string OptType { get; set; }

            /// <summary>
            /// <para>Application protection count allocated to the member. Unit: per month.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public long? RaspCapacity { get; set; }

            /// <summary>
            /// <para>Malicious file detection SDK authorization count allocated to the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public long? SdkCapacity { get; set; }

            /// <summary>
            /// <para>Log storage capacity allocated to the member, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SlsCapacity")]
            [Validation(Required=false)]
            public long? SlsCapacity { get; set; }

            /// <summary>
            /// <para>Status of the member account instance. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Valid. </description></item>
            /// <item><description><b>2</b>: Invalid.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Threat analysis capacity allocated to the member. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ThreatAnalysisCapacity")]
            [Validation(Required=false)]
            public long? ThreatAnalysisCapacity { get; set; }

            /// <summary>
            /// <para>Threat analysis and response log access traffic allocated to the member. Unit: GB/day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public long? ThreatAnalysisFlow { get; set; }

            /// <summary>
            /// <para>The version of Cloud Security Center protection to be bound. Values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition </description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Advanced Edition</description></item>
            /// <item><description><b>6</b>: Antivirus Edition    </description></item>
            /// <item><description><b>7</b>: Flagship Edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>Member account authorization usage information.</para>
            /// </summary>
            [NameInMap("VersionSummary")]
            [Validation(Required=false)]
            public List<UpdateMultiUserInstancesRequestMemberInstancesVersionSummary> VersionSummary { get; set; }
            public class UpdateMultiUserInstancesRequestMemberInstancesVersionSummary : TeaModel {
                /// <summary>
                /// <para>Number of cores authorized for the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public long? CoreCount { get; set; }

                /// <summary>
                /// <para>Number of authorizations allocated to the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public long? EcsCount { get; set; }

                /// <summary>
                /// <para>Version of the Cloud Security Center for the member account. Values:  </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition </description></item>
                /// <item><description><b>3</b>: Enterprise Edition</description></item>
                /// <item><description><b>5</b>: Advanced Edition</description></item>
                /// <item><description><b>6</b>: Antivirus Edition    </description></item>
                /// <item><description><b>7</b>: Flagship Edition   </description></item>
                /// <item><description><b>8</b>: Multiple Versions   </description></item>
                /// <item><description><b>10</b>: Only Purchase Value-Added Services</description></item>
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
            /// <para>Web tamper-proof authorization count allocated to the member.</para>
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
