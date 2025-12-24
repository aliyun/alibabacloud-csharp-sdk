// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormV2StorageUsageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;AuthAction&quot;:&quot;xxx&quot;,&quot;AuthPrincipalDisplayName&quot;:&quot;222&quot;,&quot;AuthPrincipalOwnerId&quot;:&quot;111&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;,&quot;EncodedDiagnosticMessage&quot;:&quot;xxxxxx&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("CapacityByDiskCategory")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> CapacityByDiskCategory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;cn-hangzhou-i&quot;: {
        ///       &quot;diskTypeCapacity&quot;: [
        ///         {
        ///           &quot;mode&quot;: &quot;CLOUD_STORAGE&quot;,
        ///           &quot;perfLevel&quot;: &quot;PL1&quot;,
        ///           &quot;usedCapacity&quot;: 0,
        ///           &quot;category&quot;: &quot;PERF_CLOUD_ESSD_PL1&quot;,
        ///           &quot;capacity&quot;: 4000
        ///         }
        ///       ],
        ///       &quot;diskTypeUsage&quot;: [
        ///         {
        ///           &quot;usedLindormColumn3&quot;: 688935,
        ///           &quot;usedLindormTable&quot;: 1086288931872,
        ///           &quot;usedLindormTsdb&quot;: 0,
        ///           &quot;usedOther&quot;: 0,
        ///           &quot;usedLindormMessage3&quot;: 0,
        ///           &quot;diskType&quot;: &quot;PerformanceCloudStorage&quot;,
        ///           &quot;used&quot;: 1719816329046,
        ///           &quot;usedLindormSearch3&quot;: 36339905446,
        ///           &quot;usedLindormSpark&quot;: 2131936938,
        ///           &quot;capacity&quot;: 4294967296000,
        ///           &quot;usedLindormSearch&quot;: 0,
        ///           &quot;usedLindormVector3&quot;: 595054865855
        ///         }
        ///       ]
        ///     }
        ///   }</para>
        /// </summary>
        [NameInMap("InstanceStorageZoneMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> InstanceStorageZoneMap { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BDDB1954-002B-4249-B2DF-2CDDA0259668</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UsageByDiskCategory")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> UsageByDiskCategory { get; set; }

    }

}
