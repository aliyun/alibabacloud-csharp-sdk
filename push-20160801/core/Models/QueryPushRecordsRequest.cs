// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryPushRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>333526247</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public long? AppKey { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is in UTC and follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-29T06:24:58Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The query keyword. The query is performed based on the MessageId, Title, and Body fields. The system performs Chinese word segmentation on the title and body of the push, and uses the segmented words for the query instead of substring matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Statistics data test notification 805</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and no longer used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFPpkmhCPm*****************xjk=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The current page number of the push records. Default value: 1. Maximum value: 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
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
        /// <item><description><para><b>MESSAGE</b>: message</para>
        /// </description></item>
        /// <item><description><para><b>NOTICE</b>: notification</para>
        /// </description></item>
        /// <item><description><para><b>LIVE_ACTIVITY</b>: live activity</para>
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
        /// <item><description><b>API</b>: push initiated by OpenAPI, including pushes initiated from the OpenAPI platform console</description></item>
        /// <item><description><b>CONSOLE</b>: push initiated from the Mobile Push console</description></item>
        /// <item><description><b>OpenAPIExplorer</b>: push initiated from the Alibaba Cloud OpenAPI Explorer platform</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The start time of the query. The time is in UTC and follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.</para>
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
        /// <item><description><para><b>DEVICE</b>: push by device</para>
        /// </description></item>
        /// <item><description><para><b>ACCOUNT</b>: push by account</para>
        /// </description></item>
        /// <item><description><para><b>ALIAS</b>: push by alias</para>
        /// </description></item>
        /// <item><description><para><b>TAG</b>: push by tag</para>
        /// </description></item>
        /// <item><description><para><b>ALL</b>: push to all devices</para>
        /// </description></item>
        /// <item><description><para><b>TBD</b>: initialize continuous push, where the push target is specified by the subsequent ContinuouslyPush operation</para>
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
