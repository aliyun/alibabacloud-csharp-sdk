// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class QueryTaskListRequest : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page size. Maximum value: 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task statuses.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<long?> Result { get; set; }

        /// <summary>
        /// <para>The tag ID. You can call the <a href="~~QueryTagListPage~~">QueryTagListPage</a> operation to query tag IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public long? TagId { get; set; }

        /// <summary>
        /// <para>The task ID. You can call the DescribeTasks operation to query the list of task IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>An array of task types.</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public List<long?> TaskType { get; set; }

    }

}
