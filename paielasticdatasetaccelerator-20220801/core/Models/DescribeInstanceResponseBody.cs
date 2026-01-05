// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>30.0G</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public string Capacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xgboost数据集加速实例</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2014-10-02T15:01:23Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2014-10-02T15:01:23Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>readonly</para>
        /// </summary>
        [NameInMap("IoType")]
        [Validation(Required=false)]
        public string IoType { get; set; }

        /// <summary>
        /// <para>数据集加速实例的最大挂载点个数。</para>
        /// </summary>
        [NameInMap("MaxEndpoint")]
        [Validation(Required=false)]
        public int? MaxEndpoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxSlot")]
        [Validation(Required=false)]
        public int? MaxSlot { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acc_instance_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1557702098194904</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PayAsYouGo</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>数据集加速实例的资源提供者类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A731A84D-55C9-44F7-99BB-E1CF0CF19197</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public InstanceStatus Status { get; set; }

        /// <summary>
        /// <para>数据集加速实例的存储类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<DescribeInstanceResponseBodyTags> Tags { get; set; }
        public class DescribeInstanceResponseBodyTags : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>276065346797410278</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>inst-my1tk3jggooi5uwks5</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
