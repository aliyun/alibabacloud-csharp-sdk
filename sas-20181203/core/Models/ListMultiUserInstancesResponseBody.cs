// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListMultiUserInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the administrator account.</para>
        /// </summary>
        [NameInMap("DaInstance")]
        [Validation(Required=false)]
        public ListMultiUserInstancesResponseBodyDaInstance DaInstance { get; set; }
        public class ListMultiUserInstancesResponseBodyDaInstance : TeaModel {
            /// <summary>
            /// <para>The UID of the administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104675</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The usage and allocation of the anti-ransomware capacity for the administrator account.</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceAntiRansomwareCapacity AntiRansomwareCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceAntiRansomwareCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated anti-ransomware capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The total anti-ransomware capacity of the administrator account. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used anti-ransomware capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of the cloud platform configuration check scan quota for the administrator account.</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceCspmCapacity CspmCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceCspmCapacity : TeaModel {
                /// <summary>
                /// <para>The number of assigned cloud platform configuration check scans. Unit: scans/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased cloud platform configuration check scan quota. Unit: scans per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used cloud platform configuration check scan quota. Unit: scans per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31569</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The authorized instance capacity for cloud platform configuration checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Count&quot;:0,&quot;Used&quot;:0,&quot;Assigned&quot;:0}</para>
            /// </summary>
            [NameInMap("CspmInstanceCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceCspmInstanceCapacity CspmInstanceCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceCspmInstanceCapacity : TeaModel {
                /// <summary>
                /// <para>The number of assigned cloud platform configuration check instance authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The number of purchased cloud platform configuration check instance authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of authorized instances for cloud platform configuration checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of cloud honeypot authorizations for the administrator account.</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceHoneypotCapacity HoneypotCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceHoneypotCapacity : TeaModel {
                /// <summary>
                /// <para>The number of assigned cloud honeypot authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The number of purchased cloud honeypot authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used honeypot authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of image scan authorizations for the administrator account.</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceImageScanCapacity ImageScanCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceImageScanCapacity : TeaModel {
                /// <summary>
                /// <para>The number of assigned image scan authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The number of purchased image scan authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The number of used image scan authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The Security Center instance ID purchased by the administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1gmm4pnacse343nqal</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The purchase type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Self-purchased.</description></item>
            /// <item><description><b>1</b>: Allocated.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstancePurchaseType")]
            [Validation(Required=false)]
            public int? InstancePurchaseType { get; set; }

            /// <summary>
            /// <para>The usage and allocation of the application protection quota for the administrator account.</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceRaspCapacity RaspCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceRaspCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated application protection quota. Unit: quotas per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased application protection quota. Unit: quotas per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used application protection quota. Unit: quotas per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of malicious file detection SDK authorizations for the administrator account.</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceSdkCapacity SdkCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceSdkCapacity : TeaModel {
                /// <summary>
                /// <para>The number of assigned malicious file detection SDK authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The number of purchased malicious file detection SDK authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used malicious file detection SDK authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of the log storage capacity for the administrator account.</para>
            /// </summary>
            [NameInMap("SlsCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceSlsCapacity SlsCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceSlsCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated log storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The total log storage capacity of the administrator account. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used log storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The instance status of the administrator account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Valid.</description></item>
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
            /// <para>The usage and allocation of the threat analysis capacity for the administrator account.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisCapacity ThreatAnalysisCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1548</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of Cloud Threat Detection and Response log ingestion traffic for the administrator account.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisFlow ThreatAnalysisFlow { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisFlow : TeaModel {
                /// <summary>
                /// <para>The assigned Cloud Threat Detection and Response log ingestion traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased Cloud Threat Detection and Response log ingestion traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used log ingestion traffic for CTDR. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The user type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Administrator.</description></item>
            /// <item><description><b>2</b>: Regular user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

            /// <summary>
            /// <para>The purchased Security Center edition. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Advanced Edition.</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition.   </description></item>
            /// <item><description><b>8</b>: Multi-edition.   </description></item>
            /// <item><description><b>10</b>: Value-added services only.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>The authorization usage statistics information for the administrator account.</para>
            /// </summary>
            [NameInMap("VersionSummary")]
            [Validation(Required=false)]
            public List<ListMultiUserInstancesResponseBodyDaInstanceVersionSummary> VersionSummary { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceVersionSummary : TeaModel {
                /// <summary>
                /// <para>The authorization type consumed during binding. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ASSET: Consumes instance authorizations.</description></item>
                /// <item><description>CORE: Consumes core authorizations.</description></item>
                /// <item><description>ASSET_AND_CORE: Consumes both instance and core authorizations.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ASSET_AND_CORE</para>
                /// </summary>
                [NameInMap("AuthBindType")]
                [Validation(Required=false)]
                public string AuthBindType { get; set; }

                /// <summary>
                /// <para>The usage and allocation of core authorizations for the administrator account.</para>
                /// </summary>
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryCoreCount CoreCount { get; set; }
                public class ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryCoreCount : TeaModel {
                    /// <summary>
                    /// <para>The assigned authorized core quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>The number of purchased core authorizations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>150</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The used authorized core quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The usage and allocation of instance authorizations for the administrator account.</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryEcsCount EcsCount { get; set; }
                public class ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryEcsCount : TeaModel {
                    /// <summary>
                    /// <para>The allocated purchased instance quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>The number of purchased instance authorizations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The number of used instance authorizations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The purchased Security Center edition. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition. </description></item>
                /// <item><description><b>3</b>: Enterprise Edition.</description></item>
                /// <item><description><b>5</b>: Advanced Edition.</description></item>
                /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
                /// <item><description><b>7</b>: Ultimate Edition.   </description></item>
                /// <item><description><b>8</b>: Multi-edition.   </description></item>
                /// <item><description><b>10</b>: Value-added services only.</description></item>
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
            /// <para>The usage and allocation of web tamper-proofing authorizations for the administrator account.</para>
            /// </summary>
            [NameInMap("WebLockCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceWebLockCapacity WebLockCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceWebLockCapacity : TeaModel {
                /// <summary>
                /// <para>The number of assigned web tamper-proofing authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The number of purchased web tamper-proofing authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The number of used web tamper-proofing authorizations.</para>
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
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListMultiUserInstancesResponseBodyPageInfo PageInfo { get; set; }
        public class ListMultiUserInstancesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The current page number in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per batch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The NextToken value returned when the NextToken pagination method is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. This unique identifier is generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88F2A6CD-E500-5038-B992-0107B99AA88C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the member accounts.</para>
        /// </summary>
        [NameInMap("SaleInstanceList")]
        [Validation(Required=false)]
        public List<ListMultiUserInstancesResponseBodySaleInstanceList> SaleInstanceList { get; set; }
        public class ListMultiUserInstancesResponseBodySaleInstanceList : TeaModel {
            /// <summary>
            /// <para>The UID of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103784262032</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The usage of the anti-ransomware capacity for the member accounts.</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListAntiRansomwareCapacity AntiRansomwareCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListAntiRansomwareCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated anti-ransomware capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used anti-ransomware capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage of the cloud platform configuration check scan quota for the member accounts.</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListCspmCapacity CspmCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListCspmCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated cloud platform configuration check scan quota. Unit: scans per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used cloud platform configuration check scan quota. Unit: scans per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The authorized instance capacity for cloud platform configuration checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Count&quot;:0,&quot;Used&quot;:0}</para>
            /// </summary>
            [NameInMap("CspmInstanceCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListCspmInstanceCapacity CspmInstanceCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListCspmInstanceCapacity : TeaModel {
                /// <summary>
                /// <para>The authorized number of instances for cloud platform configuration checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of authorized instances for cloud platform configuration checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage of the honeypot authorization quota for the member accounts.</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListHoneypotCapacity HoneypotCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListHoneypotCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated honeypot authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used honeypot authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage of the image scan authorization quota for the member accounts.</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListImageScanCapacity ImageScanCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListImageScanCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated image scan authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used image scan authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The Security Center instance ID purchased by the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-service-spec</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The purchase type of the instance. Valid values:</para>
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
            /// <para>The usage of the application protection quota for the member accounts.</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListRaspCapacity RaspCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListRaspCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated application protection quota. Unit: quotas per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used application protection quota. Unit: quotas per month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage of the malicious file detection SDK authorization quota for the member accounts.</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListSdkCapacity SdkCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListSdkCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated malicious file detection SDK authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used malicious file detection SDK authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage of the log storage capacity for the member accounts.</para>
            /// </summary>
            [NameInMap("SlsCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListSlsCapacity SlsCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListSlsCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated log storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used log storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The instance status of the member accounts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Valid.</description></item>
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
            /// <para>The usage of the threat analysis capacity for the member accounts.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisCapacity ThreatAnalysisCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used threat analysis capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage of the log ingestion traffic for Cloud Threat Detection and Response (CTDR) for the member accounts.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisFlow ThreatAnalysisFlow { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisFlow : TeaModel {
                /// <summary>
                /// <para>The allocated log ingestion traffic for CTDR. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used log ingestion traffic for CTDR. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The user type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Administrator.</description></item>
            /// <item><description><b>2</b>: Regular user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

            /// <summary>
            /// <para>The Security Center edition of the member accounts. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Free Edition. </description></item>
            /// <item><description><b>3</b>: Enterprise Edition.</description></item>
            /// <item><description><b>5</b>: Premium Edition.</description></item>
            /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
            /// <item><description><b>7</b>: Ultimate Edition.   </description></item>
            /// <item><description><b>8</b>: Multi-edition.   </description></item>
            /// <item><description><b>10</b>: Value-added services only.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>The statistics information of authorization usage for the member accounts.</para>
            /// </summary>
            [NameInMap("VersionSummary")]
            [Validation(Required=false)]
            public List<ListMultiUserInstancesResponseBodySaleInstanceListVersionSummary> VersionSummary { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummary : TeaModel {
                /// <summary>
                /// <para>The authorization type consumed during binding. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ASSET</b>: Consumes the authorized instance quota.</description></item>
                /// <item><description><b>CORE</b>: Consumes the authorized core quota.</description></item>
                /// <item><description><b>ASSET_AND_CORE</b>: Consumes both the authorized instance quota and the authorized core quota.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ASSET_AND_CORE</para>
                /// </summary>
                [NameInMap("AuthBindType")]
                [Validation(Required=false)]
                public string AuthBindType { get; set; }

                /// <summary>
                /// <para>The usage of the core authorization quota for the member accounts.</para>
                /// </summary>
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryCoreCount CoreCount { get; set; }
                public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryCoreCount : TeaModel {
                    /// <summary>
                    /// <para>The assigned authorized core quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>The allocated authorized core quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The used authorized core quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The usage of the authorization quota for the member accounts.</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryEcsCount EcsCount { get; set; }
                public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryEcsCount : TeaModel {
                    /// <summary>
                    /// <para>The allocated purchased instance quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>The allocated authorized instance quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The used authorized instance quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The Security Center edition of the member accounts. Valid values:  </para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Free Edition. </description></item>
                /// <item><description><b>3</b>: Enterprise Edition.</description></item>
                /// <item><description><b>5</b>: Premium Edition.</description></item>
                /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
                /// <item><description><b>7</b>: Ultimate Edition.   </description></item>
                /// <item><description><b>8</b>: Multi-edition.   </description></item>
                /// <item><description><b>10</b>: Value-added services only.</description></item>
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
            /// <para>The usage of the web tamper-proofing authorization quota for the member accounts.</para>
            /// </summary>
            [NameInMap("WebLockCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListWebLockCapacity WebLockCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListWebLockCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated web tamper-proofing authorization quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used web tamper-proofing authorization quota.</para>
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
