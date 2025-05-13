// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class TaskCallListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>导入号码时返回的批次号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <para>开始外呼时间</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-25 00:00:00</para>
        /// </summary>
        [NameInMap("CallDate")]
        [Validation(Required=false)]
        public string CallDate { get; set; }

        /// <summary>
        /// <para>结束外呼时间</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-25 00:00:00</para>
        /// </summary>
        [NameInMap("EndCallDate")]
        [Validation(Required=false)]
        public string EndCallDate { get; set; }

        /// <summary>
        /// <para>意向标签</para>
        /// </summary>
        [NameInMap("IntentTags")]
        [Validation(Required=false)]
        public string IntentTagsShrink { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>每页外呼记录数,正整数，默认10000</para>
        /// 
        /// <b>Example:</b>
        /// <para>97</para>
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
