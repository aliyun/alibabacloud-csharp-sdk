// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListMultiUserInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of the administrator account.</para>
        /// </summary>
        [NameInMap("DaInstance")]
        [Validation(Required=false)]
        public ListMultiUserInstancesResponseBodyDaInstance DaInstance { get; set; }
        public class ListMultiUserInstancesResponseBodyDaInstance : TeaModel {
            /// <summary>
            /// <para>AliUid of the administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104675</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>Usage and allocation of administrator account anti-ransomware capacity.</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceAntiRansomwareCapacity AntiRansomwareCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceAntiRansomwareCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated anti-ransomware capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Administrator account anti-ransomware capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used anti-ransomware capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Usage and allocation of administrator account CSPM (Cloud Security Posture Management) scan count.</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceCspmCapacity CspmCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceCspmCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated CSPM scan count. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Purchased CSPM scan count. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used CSPM scan count. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31569</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Usage and allocation of honeypot authorization count for the administrator account.</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceHoneypotCapacity HoneypotCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceHoneypotCapacity : TeaModel {
                /// <summary>
                /// <para>Assigned number of honeypot licenses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Purchased honeypot authorization count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used honeypot authorization count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Usage and allocation of image scan authorization count for the administrator account.</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceImageScanCapacity ImageScanCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceImageScanCapacity : TeaModel {
                /// <summary>
                /// <para>Assigned image scan authorization count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Purchased image scan authorization count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used purchased image scan authorization count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Cloud Security Center instance ID purchased by the administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1gmm4pnacse343nqal</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance purchase type. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>：Self-purchased.</description></item>
            /// <item><description><b>1</b>：Allocated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstancePurchaseType")]
            [Validation(Required=false)]
            public int? InstancePurchaseType { get; set; }

            /// <summary>
            /// <para>Usage and allocation of administrator account RASP (Runtime Application Self-Protection) capacity.</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceRaspCapacity RaspCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceRaspCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated RASP capacity. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Purchased RASP capacity. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used RASP capacity. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Usage and allocation details of the malicious file detection SDK licenses for the administrator account.</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceSdkCapacity SdkCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceSdkCapacity : TeaModel {
                /// <summary>
                /// <para>Assigned number of malicious file detection SDK licenses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Purchased number of malicious file detection SDK licenses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used number of malicious file detection SDK licenses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Usage and allocation of administrator account log storage capacity.</para>
            /// </summary>
            [NameInMap("SlsCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceSlsCapacity SlsCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceSlsCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated log storage capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Administrator account log storage capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used log storage capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Administrator account instance status. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Active.</description></item>
            /// <item><description><b>2</b>: Inactive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Usage and allocation of administrator account threat analysis capacity.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisCapacity ThreatAnalysisCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisCapacity : TeaModel {
                /// <summary>
                /// <para>Assigned threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Purchased threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1548</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Usage and allocation of threat analysis and response log inbound traffic for the administrator account.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisFlow ThreatAnalysisFlow { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisFlow : TeaModel {
                /// <summary>
                /// <para>Assigned threat analysis and response log inbound traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Purchased threat analysis and response log inbound traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used threat analysis and response log inbound traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>User type. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>Administrator User</b>: 1</description></item>
            /// <item><description><b>Regular User</b>: 2</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

            /// <summary>
            /// <para>Purchased version of Cloud Security Center. Values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>：Free Edition </description></item>
            /// <item><description><b>3</b>：Enterprise Edition</description></item>
            /// <item><description><b>5</b>：Advanced Edition</description></item>
            /// <item><description><b>6</b>：Anti-Virus Edition    </description></item>
            /// <item><description><b>7</b>：Flagship Edition   </description></item>
            /// <item><description><b>8</b>：Multiple Editions   </description></item>
            /// <item><description><b>10</b>：Value-Added Services Only</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>Authorization usage statistics for the administrator account.</para>
            /// </summary>
            [NameInMap("VersionSummary")]
            [Validation(Required=false)]
            public List<ListMultiUserInstancesResponseBodyDaInstanceVersionSummary> VersionSummary { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceVersionSummary : TeaModel {
                /// <summary>
                /// <para>The type of authorization consumed during binding. Values: </para>
                /// <list type="bullet">
                /// <item><description>ASSET: consumes the number of authorized instances</description></item>
                /// <item><description>CORE: consumes the number of authorized cores</description></item>
                /// <item><description>ASSET_AND_CORE: consumes both the number of authorized instances and cores</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ASSET_AND_CORE</para>
                /// </summary>
                [NameInMap("AuthBindType")]
                [Validation(Required=false)]
                public string AuthBindType { get; set; }

                /// <summary>
                /// <para>Usage and allocation details of the core licenses for the administrator account.</para>
                /// </summary>
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryCoreCount CoreCount { get; set; }
                public class ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryCoreCount : TeaModel {
                    /// <summary>
                    /// <para>Assigned number of core licenses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>Purchased number of core licenses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>150</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>Used number of core licenses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>Usage and allocation details of the ECS instance licenses for the administrator account.</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryEcsCount EcsCount { get; set; }
                public class ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryEcsCount : TeaModel {
                    /// <summary>
                    /// <para>Assigned number of purchased ECS instance licenses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>Purchased number of ECS instance licenses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>Used number of purchased ECS instance licenses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>Purchased version of Cloud Security Center. Values:  </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition </description></item>
                /// <item><description><b>3</b>: Enterprise Edition</description></item>
                /// <item><description><b>5</b>: Advanced Edition</description></item>
                /// <item><description><b>6</b>: Antivirus Edition    </description></item>
                /// <item><description><b>7</b>: Flagship Edition   </description></item>
                /// <item><description><b>8</b>: Multiple Editions   </description></item>
                /// <item><description><b>10</b>: Only Value-Added Services Purchased</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>Usage and allocation of web lock (anti-tampering) authorization count for the administrator account.</para>
            /// </summary>
            [NameInMap("WebLockCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceWebLockCapacity WebLockCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceWebLockCapacity : TeaModel {
                /// <summary>
                /// <para>Assigned web lock (anti-tampering) authorization count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>Purchased web lock (anti-tampering) authorization count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used web lock (anti-tampering) authorization count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

        }

        /// <summary>
        /// <para>Pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListMultiUserInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class ListMultiUserInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of items to return in each batch query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The NextToken value returned when using the NextToken method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The maximum number of items to return per page in a paginated query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88F2A6CD-E500-5038-B992-0107B99AA88C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of member accounts.</para>
        /// </summary>
        [NameInMap("SaleInstanceList")]
        [Validation(Required=false)]
        public List<ListMultiUserInstancesResponseBodySaleInstanceList> SaleInstanceList { get; set; }
        public class ListMultiUserInstancesResponseBodySaleInstanceList : TeaModel {
            /// <summary>
            /// <para>UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103784262032</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>Anti-ransomware capacity usage of the member account.</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListAntiRansomwareCapacity AntiRansomwareCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListAntiRansomwareCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated anti-ransomware capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used anti-ransomware capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Member account CSPM (Cloud Security Posture Management) scan usage.</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListCspmCapacity CspmCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListCspmCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated CSPM scan count. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used CSPM scan count. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Usage details of honeypot authorizations for the member account.</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListHoneypotCapacity HoneypotCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListHoneypotCapacity : TeaModel {
                /// <summary>
                /// <para>Number of honeypot authorizations allocated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Number of honeypot authorizations used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Member account image scanning authorization usage.</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListImageScanCapacity ImageScanCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListImageScanCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated image scanning authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used image scanning authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Cloud Security Center instance ID purchased by the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-service-spec</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Instance purchase type. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Self-purchased.</description></item>
            /// <item><description><b>1</b>: Allocated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstancePurchaseType")]
            [Validation(Required=false)]
            public int? InstancePurchaseType { get; set; }

            /// <summary>
            /// <para>Member account RASP (Runtime Application Self-Protection) usage.</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListRaspCapacity RaspCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListRaspCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated RASP capacity. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used RASP capacity. Unit: per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Usage details of malicious file detection SDK authorizations for the member account.</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListSdkCapacity SdkCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListSdkCapacity : TeaModel {
                /// <summary>
                /// <para>Number of malicious file detection SDK authorizations allocated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Number of malicious file detection SDK authorizations used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Log storage capacity usage of the member account.</para>
            /// </summary>
            [NameInMap("SlsCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListSlsCapacity SlsCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListSlsCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated log storage capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used log storage capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Status of the member account instance. Values: </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Active.</description></item>
            /// <item><description><b>2</b>: Inactive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Member account threat analysis capacity usage.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisCapacity ThreatAnalysisCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisCapacity : TeaModel {
                /// <summary>
                /// <para>Allocated threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>Member account threat analysis and response log ingestion traffic usage.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisFlow ThreatAnalysisFlow { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisFlow : TeaModel {
                /// <summary>
                /// <para>Allocated threat analysis and response log ingestion traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Used threat analysis and response log ingestion traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>User type. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>Administrator User</b>：1</description></item>
            /// <item><description><b>Regular User</b>：2</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

            /// <summary>
            /// <para>Version of the Cloud Security Center for the member account. Values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition </description></item>
            /// <item><description><b>3</b>: Enterprise Edition</description></item>
            /// <item><description><b>5</b>: Advanced Edition</description></item>
            /// <item><description><b>6</b>: Anti-Virus Edition    </description></item>
            /// <item><description><b>7</b>: Flagship Edition   </description></item>
            /// <item><description><b>8</b>: Multiple Versions   </description></item>
            /// <item><description><b>10</b>: Only Purchased Value-Added Services</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>Authorization usage statistics for the member account.</para>
            /// </summary>
            [NameInMap("VersionSummary")]
            [Validation(Required=false)]
            public List<ListMultiUserInstancesResponseBodySaleInstanceListVersionSummary> VersionSummary { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummary : TeaModel {
                /// <summary>
                /// <para>Authorization type consumed during binding, with values:</para>
                /// <list type="bullet">
                /// <item><description><b>ASSET</b>：Consumes the number of authorized instances</description></item>
                /// <item><description><b>CORE</b>：Consumes the number of authorized cores</description></item>
                /// <item><description><b>ASSET_AND_CORE</b>：Consumes both the number of authorized instances and cores.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ASSET_AND_CORE</para>
                /// </summary>
                [NameInMap("AuthBindType")]
                [Validation(Required=false)]
                public string AuthBindType { get; set; }

                /// <summary>
                /// <para>Usage of core authorization for the member account.</para>
                /// </summary>
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryCoreCount CoreCount { get; set; }
                public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryCoreCount : TeaModel {
                    /// <summary>
                    /// <para>Assigned number of cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>Allocated number of cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>Number of cores used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>Usage details of ECS authorizations for the member account.</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryEcsCount EcsCount { get; set; }
                public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryEcsCount : TeaModel {
                    /// <summary>
                    /// <para>已分配已购授权台数。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>Number of ECS authorizations allocated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>Number of ECS authorizations used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>Version of the Cloud Security Center for the member account. Values:  </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition </description></item>
                /// <item><description><b>3</b>: Enterprise Edition</description></item>
                /// <item><description><b>5</b>: Advanced Edition</description></item>
                /// <item><description><b>6</b>: Anti-Virus Edition    </description></item>
                /// <item><description><b>7</b>: Flagship Edition   </description></item>
                /// <item><description><b>8</b>: Multiple Versions   </description></item>
                /// <item><description><b>10</b>: Value-Added Services Only</description></item>
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
            /// <para>Member account web lock (anti-tampering) authorization usage.</para>
            /// </summary>
            [NameInMap("WebLockCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListWebLockCapacity WebLockCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListWebLockCapacity : TeaModel {
                /// <summary>
                /// <para>Number of web tamper-proof authorizations allocated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Number of web tamper-proof authorizations used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

        }

    }

}
