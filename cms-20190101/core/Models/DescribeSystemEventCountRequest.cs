// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventCountRequest : TeaModel {
        /// <summary>
        /// <para>The timestamp of the end time for the event query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1635993921000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The event type.</para>
        /// <para>Call the DescribeSystemEventMetaList operation to obtain the value of the <c>EventType</c> response parameter, which provides the event types for all Alibaba Cloud services under the current Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StatusNotification</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The application group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17285****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The event level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Critical: critical.</para>
        /// </description></item>
        /// <item><description><para>Warn: warning.</para>
        /// </description></item>
        /// <item><description><para>Info: information.</para>
        /// </description></item>
        /// </list>
        /// <para>Call the DescribeSystemEventMetaList operation to obtain the value of the <c>Level</c> response parameter, which provides the event levels for all Alibaba Cloud services under the current Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Info</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The event name.</para>
        /// <para>Call the DescribeSystemEventMetaList operation to obtain the value of the <c>Name</c> response parameter, which provides the event names for all Alibaba Cloud services under the current Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance:StateChange</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud service.</para>
        /// <para>Call the DescribeSystemEventMetaList operation to obtain the value of the <c>Product</c> response parameter, which provides the Alibaba Cloud service names for all events under the current Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The keywords contained in the event content for searching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>To search for event content that contains both a and b, search for <c>a and b</c>.</para>
        /// </description></item>
        /// <item><description><para>To search for event content that contains either a or b, search for <c>a or b</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("SearchKeywords")]
        [Validation(Required=false)]
        public string SearchKeywords { get; set; }

        /// <summary>
        /// <para>The timestamp of the start time for the event query. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1635993541000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The event status.</para>
        /// <para>Call the DescribeSystemEventMetaList operation to obtain the value of the <c>Status</c> response parameter, which provides the event statuses for all Alibaba Cloud services under the current Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/114972.html">DescribeSystemEventMetaList</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
