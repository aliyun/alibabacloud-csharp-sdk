// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class CreateSlotRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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

        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<CreateSlotRequestEndpoints> Endpoints { get; set; }
        public class CreateSlotRequestEndpoints : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>endpoint-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc-j6co2fcdsl1q0gnuc3ym3</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-j6cmr00qjyrft6jo2mg7g</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

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
        public List<CreateSlotRequestTags> Tags { get; set; }
        public class CreateSlotRequestTags : TeaModel {
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
