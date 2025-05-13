// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class DetailsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>批次id</para>
        /// 
        /// <b>Example:</b>
        /// <para>75</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public long? BatchId { get; set; }

        /// <summary>
        /// <para>结束导入时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-25 15:19:02</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>号码状态</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NumberStatus")]
        [Validation(Required=false)]
        public long? NumberStatus { get; set; }

        /// <summary>
        /// <para>号码列表</para>
        /// </summary>
        [NameInMap("Numbers")]
        [Validation(Required=false)]
        public string NumbersShrink { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>页数</para>
        /// 
        /// <b>Example:</b>
        /// <para>77</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>每页条数</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
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
        /// <para>开始导入时间</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-25 15:19:02</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>任务id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
