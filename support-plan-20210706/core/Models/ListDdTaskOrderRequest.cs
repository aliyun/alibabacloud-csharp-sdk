// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class ListDdTaskOrderRequest : TeaModel {
        /// <summary>
        /// <para>createRealName</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tom</para>
        /// </summary>
        [NameInMap("CreateRealName")]
        [Validation(Required=false)]
        public string CreateRealName { get; set; }

        /// <summary>
        /// <para>endTime</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-20 14:09:16</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("IsUrgent")]
        [Validation(Required=false)]
        public bool? IsUrgent { get; set; }

        /// <summary>
        /// <para>openGroupId</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAWNN14N</para>
        /// </summary>
        [NameInMap("OpenGroupId")]
        [Validation(Required=false)]
        public string OpenGroupId { get; set; }

        /// <summary>
        /// <para>pageNo</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>pageSize</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>startTime</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-01 14:09:11</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>taskStatus</para>
        /// 
        /// <b>Example:</b>
        /// <para>dealingNode</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

    }

}
