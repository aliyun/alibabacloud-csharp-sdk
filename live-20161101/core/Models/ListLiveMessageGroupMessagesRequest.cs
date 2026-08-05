// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveMessageGroupMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive message application to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The query start time, expressed as a UNIX timestamp. Unit: seconds. If this parameter is left empty, the earliest time is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1697783235</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The data center. This value must be consistent with the data center specified in <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a>. Currently supported data centers are Shanghai (cn-shanghai) and Singapore (ap-southeast-1).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The query end time, expressed as a UNIX timestamp. Unit: seconds. If this parameter is left empty, the latest time is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698301635</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The group ID of the group to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The message type to query. If this parameter is left empty, all message types are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MsgType")]
        [Validation(Required=false)]
        public long? MsgType { get; set; }

        /// <summary>
        /// <para>The start position of the query page. If this parameter is left empty, the first page is returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public long? NextPageToken { get; set; }

        /// <summary>
        /// <para>The number of messages to display at a time. Valid values: <b>[10,50]</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort type. Messages are sorted by the time they were sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1: ascending order</para>
        /// </description></item>
        /// <item><description><para>2: descending order</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public int? SortType { get; set; }

    }

}
