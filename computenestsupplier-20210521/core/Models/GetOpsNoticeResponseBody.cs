// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetOpsNoticeResponseBody : TeaModel {
        /// <summary>
        /// <para>The non-public properties of the O\&amp;M item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;cveId\&quot;:\&quot;CVE-2021-4034\&quot;}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        /// <summary>
        /// <para>The category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Availability</para>
        /// </description></item>
        /// <item><description><para>Cost</para>
        /// </description></item>
        /// <item><description><para>Performance</para>
        /// </description></item>
        /// <item><description><para>Recovery: backup and recovery</para>
        /// </description></item>
        /// <item><description><para>Security</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Availability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The message content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the notice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>notice-2338d3835bxxxxx</para>
        /// </summary>
        [NameInMap("NoticeId")]
        [Validation(Required=false)]
        public string NoticeId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B3AD3CC-E938-5042-A771-7FD9A2FE03F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-c2d118c9193e49xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The number of service instances involved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ServiceInstanceCount")]
        [Validation(Required=false)]
        public string ServiceInstanceCount { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WordPress Community Edition</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The list of published service versions.</para>
        /// </summary>
        [NameInMap("ServiceVersions")]
        [Validation(Required=false)]
        public List<string> ServiceVersions { get; set; }

        /// <summary>
        /// <para>The severity of the O\&amp;M item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Critical</para>
        /// </description></item>
        /// <item><description><para>High</para>
        /// </description></item>
        /// <item><description><para>Medium</para>
        /// </description></item>
        /// <item><description><para>Low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Critical</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The solutions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Solutions</para>
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public string Solutions { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-18T02:05:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. A value of <b>true</b> indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The type of the notice. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ServiceInstanceUpgrade: upgrade</para>
        /// </description></item>
        /// <item><description><para>VulnerabilityFix: vulnerability</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ServiceInstanceUpgrade</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The number of users who received the notice.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserCount")]
        [Validation(Required=false)]
        public string UserCount { get; set; }

    }

}
