// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskRecoverCallShrinkRequest : TeaModel {
        /// <summary>
        /// <para>查询开始导入时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;2023-01-09 18:58:19&quot;</para>
        /// </summary>
        [NameInMap("BeginImportTime")]
        [Validation(Required=false)]
        public string BeginImportTime { get; set; }

        /// <summary>
        /// <para>查询结束导入时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;2023-01-09 18:58:19&quot;</para>
        /// </summary>
        [NameInMap("EndImportTime")]
        [Validation(Required=false)]
        public string EndImportTime { get; set; }

        /// <summary>
        /// <para>号码列表</para>
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public string NumbersShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>用户自定义标签列表</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>任务ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
