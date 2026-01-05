// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class CreateSlotsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("Slots")]
        [Validation(Required=false)]
        public List<CreateSlotsRequestSlots> Slots { get; set; }
        public class CreateSlotsRequestSlots : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>30.0G</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public string Capacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xgboost数据集加速槽</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>end-my1tk3jggooi5uwks5,end-n69468yvjz8d12as7d,end-tga4omjrepklkg1onn</para>
            /// </summary>
            [NameInMap("EndpointIds")]
            [Validation(Required=false)]
            public string EndpointIds { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inst-my1tk3jggooi5uwks5</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IoType")]
            [Validation(Required=false)]
            public string IoType { get; set; }

            [NameInMap("LifeCycle")]
            [Validation(Required=false)]
            public SlotLifeCycle LifeCycle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>slot_1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://pai-vision-data-hz2.oss-cn-hangzhou-internal.aliyuncs.com/data/VOCdevkit/VOC2007/ImageSets/Main/val.txt</para>
            /// </summary>
            [NameInMap("StorageUri")]
            [Validation(Required=false)]
            public string StorageUri { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<CreateSlotsRequestSlotsTags> Tags { get; set; }
            public class CreateSlotsRequestSlotsTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dataset_version</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v0.1.0</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
