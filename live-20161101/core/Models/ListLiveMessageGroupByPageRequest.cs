// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveMessageGroupByPageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the interactive messaging application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

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
        /// <para>The status of the groups to query. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: all groups</description></item>
        /// <item><description>1: existing groups</description></item>
        /// <item><description>2: deleted groups</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GroupStatus")]
        [Validation(Required=false)]
        public int? GroupStatus { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: [1,10000].</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:[1,50].</para>
        /// <para>Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sort order based on the time when the groups were created. Valid values:</para>
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
