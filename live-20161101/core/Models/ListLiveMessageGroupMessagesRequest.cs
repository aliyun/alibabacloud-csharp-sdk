// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveMessageGroupMessagesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: seconds. If you leave this parameter empty, the earliest available time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1697783235</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The data center. It must be the same as the data center that was specified when you called the <a href="https://help.aliyun.com/document_detail/2848162.html">CreateLiveMessageApp</a> operation to create the interactive messaging application. Valid values: cn-shanghai and ap-southeast-1 (Singapore).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds. If you leave this parameter empty, the latest available time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698301635</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the group to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grouptest</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The type of messages that you want to query. If you leave this parameter empty, all types of messages are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MsgType")]
        [Validation(Required=false)]
        public long? MsgType { get; set; }

        /// <summary>
        /// <para>The starting page number for the query. If you leave this parameter empty, the query starts from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public long? NextPageToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>10 to 50</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort order based on the time when the messages were sent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: ascending order</description></item>
        /// <item><description>2: descending order</description></item>
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
