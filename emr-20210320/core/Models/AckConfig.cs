/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckConfig : TeaModel {
        /// <summary>
        /// ack集群id
        /// </summary>
        [NameInMap("AckInstanceId")]
        [Validation(Required=false)]
        public string AckInstanceId { get; set; }

        [NameInMap("CustomAnnotations")]
        [Validation(Required=false)]
        public List<Tag> CustomAnnotations { get; set; }

        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public List<Tag> CustomLabels { get; set; }

        [NameInMap("DataDiskSize")]
        [Validation(Required=false)]
        public int? DataDiskSize { get; set; }

        [NameInMap("DataDiskStorageClass")]
        [Validation(Required=false)]
        public string DataDiskStorageClass { get; set; }

        /// <summary>
        /// Pod的CPU限制值。
        /// </summary>
        [NameInMap("LimitCpu")]
        [Validation(Required=false)]
        public float? LimitCpu { get; set; }

        /// <summary>
        /// Pod的内存限制值。
        /// </summary>
        [NameInMap("LimitMemory")]
        [Validation(Required=false)]
        public string LimitMemory { get; set; }

        [NameInMap("MountHostCgroup")]
        [Validation(Required=false)]
        public bool? MountHostCgroup { get; set; }

        /// <summary>
        /// ack 命名空间
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// ack的节点标签限制
        /// </summary>
        [NameInMap("NodeSelectors")]
        [Validation(Required=false)]
        public List<Tag> NodeSelectors { get; set; }

        /// <summary>
        /// Pod的CPU请求值
        /// </summary>
        [NameInMap("RequestCpu")]
        [Validation(Required=false)]
        public float? RequestCpu { get; set; }

        /// <summary>
        /// Pod的内存请求值。
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        /// <summary>
        /// ack的节点污点容忍
        /// </summary>
        [NameInMap("Tolerations")]
        [Validation(Required=false)]
        public List<Toleration> Tolerations { get; set; }

    }

}
