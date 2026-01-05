// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class ListSlotsRequest : TeaModel {
        /// <summary>
        /// <para>加速槽所对应的数据集加速挂载点的唯一标识符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>endp-my1tk3jggooi5uwks5</para>
        /// </summary>
        [NameInMap("EndpointIds")]
        [Validation(Required=false)]
        public string EndpointIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>inst-my1tk3jggooi5uwks5</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acc_instance_slot_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>slot-my1tk3jggooi5uwks5,slot-n69468yvjz8d12as7d,slot-tga4omjrepklkg1onn</para>
        /// </summary>
        [NameInMap("SlotIds")]
        [Validation(Required=false)]
        public string SlotIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GmtCreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>数据集加速槽的数据存储路径（URI）。</para>
        /// </summary>
        [NameInMap("StorageUri")]
        [Validation(Required=false)]
        public string StorageUri { get; set; }

    }

}
