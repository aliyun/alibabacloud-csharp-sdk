// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>333526247</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The end time for the query. Specify the time in UTC, using the ISO-8601 format <c>YYYY-MM-DDThh:mm:ssZ</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-29T06:24:58Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The keyword used for the query. The search covers the <c>MessageId</c>, <c>Title</c>, and <c>Body</c> fields. For <c>Title</c> and <c>Body</c>, the system applies Chinese word segmentation and matches whole tokens instead of substrings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>统计数据测试通知805</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFPpkmhCPm*****************xjk=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number to query. Default: 1. Maximum: 10,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default: 20. Maximum: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The push type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MESSAGE</b>: A message.</para>
        /// </description></item>
        /// <item><description><para><b>NOTICE</b>: A notification.</para>
        /// </description></item>
        /// <item><description><para><b>LIVE_ACTIVITY</b>: A Live Activity.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NOTICE</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

        /// <summary>
        /// <para>The push source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>API</b>: Pushes initiated via an OpenAPI call.</para>
        /// </description></item>
        /// <item><description><para><b>CONSOLE</b>: Pushes initiated from the Mobile Push console.</para>
        /// </description></item>
        /// <item><description><para><b>OpenAPIExplorer</b>: Pushes initiated from Alibaba Cloud OpenAPI Explorer.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The start time for the query. Specify the time in UTC, using the ISO-8601 format <c>YYYY-MM-DDThh:mm:ssZ</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-15T02:05:24Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The push target. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DEVICE</b>: Push to devices.</para>
        /// </description></item>
        /// <item><description><para><b>ACCOUNT</b>: Push to accounts.</para>
        /// </description></item>
        /// <item><description><para><b>ALIAS</b>: Push to aliases.</para>
        /// </description></item>
        /// <item><description><para><b>TAG</b>: Push to tags.</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: Push to all devices.</para>
        /// </description></item>
        /// <item><description><para><b>TBD</b>: Initializes a continuous push. The push target is specified in a subsequent call to the <c>ContinuouslyPush</c> API operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DEVICE</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

    }

}
