// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInvadeEventListRequest : TeaModel {
        /// <summary>
        /// <para>The IP address of the affected asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.XX.XX</para>
        /// </summary>
        [NameInMap("AssetsIP")]
        [Validation(Required=false)]
        public string AssetsIP { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ins_1321_asedb_****</para>
        /// </summary>
        [NameInMap("AssetsInstanceId")]
        [Validation(Required=false)]
        public string AssetsInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_test</para>
        /// </summary>
        [NameInMap("AssetsInstanceName")]
        [Validation(Required=false)]
        public string AssetsInstanceName { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds. If you do not specify this parameter, the query ends at the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656837360</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the breach awareness event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69d189e2-ec17-4676-a2fe-02969234****</para>
        /// </summary>
        [NameInMap("EventKey")]
        [Validation(Required=false)]
        public string EventKey { get; set; }

        /// <summary>
        /// <para>The name of the breach awareness event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>event_test</para>
        /// </summary>
        [NameInMap("EventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        /// <summary>
        /// <para>The UUID of the breach awareness event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fadd-dfdd-****</para>
        /// </summary>
        [NameInMap("EventUuid")]
        [Validation(Required=false)]
        public string EventUuid { get; set; }

        /// <summary>
        /// <para>Specifies whether the breach awareness event is ignored. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The breach awareness event is ignored.</description></item>
        /// <item><description><b>false</b>: The breach awareness event is not ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsIgnore")]
        [Validation(Required=false)]
        public string IsIgnore { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135809047715****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: 6. Maximum value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The handling status of breach awareness events.</para>
        /// </summary>
        [NameInMap("ProcessStatusList")]
        [Validation(Required=false)]
        public List<int?> ProcessStatusList { get; set; }

        /// <summary>
        /// <para>The risk levels.</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public List<int?> RiskLevel { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds. If you do not specify this parameter, the query starts from 30 days before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656750960</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
