// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSparkAppDiagnosisInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the request denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;PolicyType&quot;: &quot;AccountLevelIdentityBasedPolicy&quot;,
        ///     &quot;AuthPrincipalOwnerId&quot;: &quot;1**<em><b><b><b><b><b><b><b>7&quot;,
        ///     &quot;EncodedDiagnosticMessage&quot;: &quot;AQIBIAAAAOPdwKY2QLOvgMEc7SkkoJfj1kvZwsaRqNYMh10Tv0wTe0fCzaCdrvgazfNb0EnJKETgXyhR+3BIQjx9WAqZryejBsp1Bl4qI5En/D9dEhcXAtKCxCmE2kZCiEzpy8BoEUt+bs0DmlaGWO5xkEpttypLIB4rUhDvZd+zwPg4EXk4KSSWSWsurxtqDkKEMshKlQFBTKvJcKwyhk62IeYly4hQ+5IpXjkh1GQXuDRCQ==&quot;,
        ///     &quot;AuthPrincipalType&quot;: &quot;SubUser&quot;,
        ///     &quot;AuthPrincipalDisplayName&quot;: &quot;2</b></b></b></b></b></b></b></em>9&quot;,
        ///     &quot;NoPermissionType&quot;: &quot;ImplicitDeny&quot;,
        ///     &quot;AuthAction&quot;: &quot;adb:DescribeExcessivePrimaryKeys&quot;
        /// }</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The application ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/455888.html">ListSparkApps</a> operation to query all application IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>s202404141952sz6a1391200****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The CPU utilization. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("CpuUtilization")]
        [Validation(Required=false)]
        public double? CpuUtilization { get; set; }

        /// <summary>
        /// <para>The queried diagnostic information.</para>
        /// </summary>
        [NameInMap("DiagnosisInfoList")]
        [Validation(Required=false)]
        public List<Adb4MysqlSparkDiagnosisInfo> DiagnosisInfoList { get; set; }

        /// <summary>
        /// <para>The execution duration of the application. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>281063</para>
        /// </summary>
        [NameInMap("DurationInMillis")]
        [Validation(Required=false)]
        public long? DurationInMillis { get; set; }

        /// <summary>
        /// <para>The amount of time consumed by the Java virtual machine to perform garbage collection operations. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81055</para>
        /// </summary>
        [NameInMap("JVMGcCostInMillis")]
        [Validation(Required=false)]
        public long? JVMGcCostInMillis { get; set; }

        /// <summary>
        /// <para>The peak memory usage. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096000</para>
        /// </summary>
        [NameInMap("PeakMemoryInByte")]
        [Validation(Required=false)]
        public long? PeakMemoryInByte { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FB5AC339-91F6-5000-8E5A-F47065B01B87</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The amount of data used for shuffle reads. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096000</para>
        /// </summary>
        [NameInMap("ShuffleReadInByte")]
        [Validation(Required=false)]
        public long? ShuffleReadInByte { get; set; }

        /// <summary>
        /// <para>The amount of data used for shuffle writes. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096000</para>
        /// </summary>
        [NameInMap("ShuffleWriteInByte")]
        [Validation(Required=false)]
        public long? ShuffleWriteInByte { get; set; }

        /// <summary>
        /// <para>The amount of data spilled to disks when the memory is insufficient. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SpillInByte")]
        [Validation(Required=false)]
        public long? SpillInByte { get; set; }

        /// <summary>
        /// <para>The time when the application started to be executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1718329831000</para>
        /// </summary>
        [NameInMap("StartedTime")]
        [Validation(Required=false)]
        public long? StartedTime { get; set; }

        /// <summary>
        /// <para>The status of the asynchronous import or export job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RUNNING</b></description></item>
        /// <item><description><b>FINISHED</b></description></item>
        /// <item><description><b>FAILED</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FINISHED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
