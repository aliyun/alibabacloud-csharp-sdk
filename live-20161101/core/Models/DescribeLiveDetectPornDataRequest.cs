// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectPornDataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the stream belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The streaming domain to query.</para>
        /// <list type="bullet">
        /// <item><description><para>You can query one or more domain names. To query multiple domain names, separate them with commas (,).</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the service returns the merged data for all streaming domains.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T09:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>You have a daily free quota for image scans. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>free</b></para>
        /// </description></item>
        /// <item><description><para><b>charge</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("Fee")]
        [Validation(Required=false)]
        public string Fee { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region where the domain name is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The detection scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>porn</b> (default): pornography detection.</para>
        /// </description></item>
        /// <item><description><para><b>terrorism</b>: terrorism and political content detection.</para>
        /// </description></item>
        /// <item><description><para><b>ad</b>: ad and text violation detection.</para>
        /// </description></item>
        /// <item><description><para><b>live</b>: undesirable live streaming scenario detection.</para>
        /// </description></item>
        /// <item><description><para><b>logo</b>: logo detection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>porn</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The list of grouping fields. Separate multiple fields with commas (,).</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, the service returns only TimeStamp and Count.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****,liveStream****</para>
        /// </summary>
        [NameInMap("SplitBy")]
        [Validation(Required=false)]
        public string SplitBy { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can query data from the last 90 days.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The minimum data granularity is 5 minutes. If you leave this parameter empty, the service queries data from the last 24 hours by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T08:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The stream name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveStream****</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public string Stream { get; set; }

    }

}
