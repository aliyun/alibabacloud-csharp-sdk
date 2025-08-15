// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetTrailStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether logging is enabled for the trail. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsLogging")]
        [Validation(Required=false)]
        public bool? IsLogging { get; set; }

        /// <summary>
        /// <para>The log of the last failed delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>write sls failed, exception: the parent of sub user must be project owner, itemscount: 1</para>
        /// </summary>
        [NameInMap("LatestDeliveryError")]
        [Validation(Required=false)]
        public string LatestDeliveryError { get; set; }

        /// <summary>
        /// <para>The log of the last failed delivery to Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>write sls failed, exception: the parent of sub user must be project owner, itemscount: 1</para>
        /// </summary>
        [NameInMap("LatestDeliveryLogServiceError")]
        [Validation(Required=false)]
        public string LatestDeliveryLogServiceError { get; set; }

        /// <summary>
        /// <para>The most recent time when an event was delivered to Log Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-26T09:19:44Z</para>
        /// </summary>
        [NameInMap("LatestDeliveryLogServiceTime")]
        [Validation(Required=false)]
        public string LatestDeliveryLogServiceTime { get; set; }

        /// <summary>
        /// <para>The most recent time when an event was delivered by the trail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-26T09:19:44Z</para>
        /// </summary>
        [NameInMap("LatestDeliveryTime")]
        [Validation(Required=false)]
        public string LatestDeliveryTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the destination Object Storage Service (OSS) bucket is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OssBucketStatus")]
        [Validation(Required=false)]
        public bool? OssBucketStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8067369B-B923-4D26-85BC-61BF33922505</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the destination Log Service Logstore is available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SlsLogStoreStatus")]
        [Validation(Required=false)]
        public bool? SlsLogStoreStatus { get; set; }

        /// <summary>
        /// <para>The time when logging was last enabled for the trail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-24T09:19:44Z</para>
        /// </summary>
        [NameInMap("StartLoggingTime")]
        [Validation(Required=false)]
        public string StartLoggingTime { get; set; }

        /// <summary>
        /// <para>The time when logging was last disabled for the trail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-02-25T09:19:44Z</para>
        /// </summary>
        [NameInMap("StopLoggingTime")]
        [Validation(Required=false)]
        public string StopLoggingTime { get; set; }

    }

}
