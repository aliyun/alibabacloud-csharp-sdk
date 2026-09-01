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
            /// <para>The aliuid of the administrator account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1766185894104675</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The anti-ransomware capacity usage and allocation of the administrator account.</para>
            /// </summary>
            [NameInMap("AntiRansomwareCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceAntiRansomwareCapacity AntiRansomwareCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceAntiRansomwareCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned anti-ransomware capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The anti-ransomware capacity of the administrator account. Unit: GB.</para>
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
            /// <para>The cloud platform configuration check scan usage and allocation of the administrator account.</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceCspmCapacity CspmCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceCspmCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned number of cloud platform configuration check scans. Unit: scans/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased number of cloud platform configuration check scans. Unit: scans/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>180000</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of cloud platform configuration check scans. Unit: scans/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31569</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            [NameInMap("CspmInstanceCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceCspmInstanceCapacity CspmInstanceCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceCspmInstanceCapacity : TeaModel {
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of honeypot quotas for the administrator account.</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceHoneypotCapacity HoneypotCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceHoneypotCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned honeypot quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased honeypot quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>45</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of cloud honeypot authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of image scan quotas for the administrator account.</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceImageScanCapacity ImageScanCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceImageScanCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned image scan quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased image scan quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used image scan quota.</para>
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
            /// <para>The instance purchase type. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstancePurchaseType")]
            [Validation(Required=false)]
            public int? InstancePurchaseType { get; set; }

            /// <summary>
            /// <para>The application protection usage and allocation of the administrator account.</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceRaspCapacity RaspCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceRaspCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned number of application protection quotas. Unit: quotas/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased number of application protection quotas. Unit: quotas/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of application protection quotas. Unit: quotas/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of malicious file detection SDK quotas for the administrator account.</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceSdkCapacity SdkCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceSdkCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned malicious file detection SDK quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased malicious file detection SDK quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of malicious file detection SDK authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The log storage capacity usage and allocation of the administrator account.</para>
            /// </summary>
            [NameInMap("SlsCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceSlsCapacity SlsCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceSlsCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned log storage capacity. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The log storage capacity of the administrator account. Unit: GB.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The threat analysis capacity usage and allocation of the administrator account.</para>
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
            /// <para>The usage and allocation of threat detection and response log ingestion traffic for the administrator account.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisFlow ThreatAnalysisFlow { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceThreatAnalysisFlow : TeaModel {
                /// <summary>
                /// <para>The assigned threat detection and response log ingestion traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased threat detection and response log ingestion traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used threat detection and response log ingestion traffic. Unit: GB/day.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

            /// <summary>
            /// <para>The purchased Security Center edition. Valid values:</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>ASSET_AND_CORE</para>
                /// </summary>
                [NameInMap("AuthBindType")]
                [Validation(Required=false)]
                public string AuthBindType { get; set; }

                /// <summary>
                /// <para>The usage and allocation of authorized core quotas for the administrator account.</para>
                /// </summary>
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryCoreCount CoreCount { get; set; }
                public class ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryCoreCount : TeaModel {
                    /// <summary>
                    /// <para>The assigned number of authorized cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>The purchased authorized core quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>150</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The used number of authorized cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The usage and allocation of authorized server quotas for the administrator account.</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryEcsCount EcsCount { get; set; }
                public class ListMultiUserInstancesResponseBodyDaInstanceVersionSummaryEcsCount : TeaModel {
                    /// <summary>
                    /// <para>The assigned number of purchased authorized servers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>The purchased authorized server quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The used authorized server quota.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The purchased Security Center edition. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The usage and allocation of tamper-proofing quotas for the administrator account.</para>
            /// </summary>
            [NameInMap("WebLockCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodyDaInstanceWebLockCapacity WebLockCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodyDaInstanceWebLockCapacity : TeaModel {
                /// <summary>
                /// <para>The assigned tamper-proofing quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Assigned")]
                [Validation(Required=false)]
                public long? Assigned { get; set; }

                /// <summary>
                /// <para>The purchased tamper-proofing quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used tamper-proofing quota.</para>
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
            /// <para>The current page number in paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per batch in a batched query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The NextToken value returned when the NextToken-based pagination method is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B604532DEF982B875E8360A6EFA3B***</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in paging query.</para>
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
        /// <para>The ID of this request, which is a unique identifier generated by Alibaba Cloud for this request. It can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88F2A6CD-E500-5038-B992-0107B99AA88C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of member accounts.</para>
        /// </summary>
        [NameInMap("SaleInstanceList")]
        [Validation(Required=false)]
        public List<ListMultiUserInstancesResponseBodySaleInstanceList> SaleInstanceList { get; set; }
        public class ListMultiUserInstancesResponseBodySaleInstanceList : TeaModel {
            /// <summary>
            /// <para>The UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103784262032</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The anti-ransomware capacity usage of the member account.</para>
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
            /// <para>The cloud platform configuration check scan usage of the member account.</para>
            /// </summary>
            [NameInMap("CspmCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListCspmCapacity CspmCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListCspmCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated number of cloud platform configuration check scans. Unit: scans/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of cloud platform configuration check scans. Unit: scans/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            [NameInMap("CspmInstanceCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListCspmInstanceCapacity CspmInstanceCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListCspmInstanceCapacity : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The cloud honeypot authorization usage of the member account.</para>
            /// </summary>
            [NameInMap("HoneypotCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListHoneypotCapacity HoneypotCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListHoneypotCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated number of cloud honeypot authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of cloud honeypot authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The image scan authorization usage of the member account.</para>
            /// </summary>
            [NameInMap("ImageScanCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListImageScanCapacity ImageScanCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListImageScanCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated number of image scan authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of image scan authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The Security Center instance ID purchased by the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>api-service-spec</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance purchase type. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstancePurchaseType")]
            [Validation(Required=false)]
            public int? InstancePurchaseType { get; set; }

            /// <summary>
            /// <para>The application protection usage of the member account.</para>
            /// </summary>
            [NameInMap("RaspCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListRaspCapacity RaspCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListRaspCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated number of application protection quotas. Unit: quotas/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of application protection quotas. Unit: quotas/month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The malicious file detection SDK authorization usage of the member account.</para>
            /// </summary>
            [NameInMap("SdkCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListSdkCapacity SdkCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListSdkCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated number of malicious file detection SDK authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of malicious file detection SDK authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Used")]
                [Validation(Required=false)]
                public long? Used { get; set; }

            }

            /// <summary>
            /// <para>The log storage capacity usage of the member account.</para>
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
            /// <para>The instance status of the member account. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The threat analysis capacity usage of the member account.</para>
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
            /// <para>The threat detection and response log ingestion traffic usage of the member account.</para>
            /// </summary>
            [NameInMap("ThreatAnalysisFlow")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisFlow ThreatAnalysisFlow { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListThreatAnalysisFlow : TeaModel {
                /// <summary>
                /// <para>The allocated threat detection and response log ingestion traffic. Unit: GB/day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used threat detection and response log ingestion traffic. Unit: GB/day.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

            /// <summary>
            /// <para>The Security Center edition of the member account. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>The authorization usage statistics of the member account.</para>
            /// </summary>
            [NameInMap("VersionSummary")]
            [Validation(Required=false)]
            public List<ListMultiUserInstancesResponseBodySaleInstanceListVersionSummary> VersionSummary { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummary : TeaModel {
                /// <summary>
                /// <para>The authorization type consumed during binding. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>ASSET_AND_CORE</para>
                /// </summary>
                [NameInMap("AuthBindType")]
                [Validation(Required=false)]
                public string AuthBindType { get; set; }

                /// <summary>
                /// <para>The authorization quota usage for cores of the member account.</para>
                /// </summary>
                [NameInMap("CoreCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryCoreCount CoreCount { get; set; }
                public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryCoreCount : TeaModel {
                    /// <summary>
                    /// <para>The assigned number of authorized cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>The allocated number of authorized cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The used number of authorized cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The authorization quota usage for servers of the member account.</para>
                /// </summary>
                [NameInMap("EcsCount")]
                [Validation(Required=false)]
                public ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryEcsCount EcsCount { get; set; }
                public class ListMultiUserInstancesResponseBodySaleInstanceListVersionSummaryEcsCount : TeaModel {
                    /// <summary>
                    /// <para>The assigned number of purchased authorized servers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Assigned")]
                    [Validation(Required=false)]
                    public long? Assigned { get; set; }

                    /// <summary>
                    /// <para>The allocated number of authorized servers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The used number of authorized servers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Used")]
                    [Validation(Required=false)]
                    public long? Used { get; set; }

                }

                /// <summary>
                /// <para>The Security Center edition of the member account. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The web tamper-proofing authorization usage of the member account.</para>
            /// </summary>
            [NameInMap("WebLockCapacity")]
            [Validation(Required=false)]
            public ListMultiUserInstancesResponseBodySaleInstanceListWebLockCapacity WebLockCapacity { get; set; }
            public class ListMultiUserInstancesResponseBodySaleInstanceListWebLockCapacity : TeaModel {
                /// <summary>
                /// <para>The allocated number of web tamper-proofing authorizations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The used number of web tamper-proofing authorizations.</para>
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
