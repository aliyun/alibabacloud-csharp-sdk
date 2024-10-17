// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AckConfig : TeaModel {
        /// <summary>
        /// <para>ack集群id</para>
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
        /// <para>Pod的CPU限制值。</para>
        /// </summary>
        [NameInMap("LimitCpu")]
        [Validation(Required=false)]
        public float? LimitCpu { get; set; }

        /// <summary>
        /// <para>Pod的内存限制值。</para>
        /// </summary>
        [NameInMap("LimitMemory")]
        [Validation(Required=false)]
        public float? LimitMemory { get; set; }

        [NameInMap("MountHostCgroup")]
        [Validation(Required=false)]
        public bool? MountHostCgroup { get; set; }

        /// <summary>
        /// <para>ack 命名空间</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("NodeAffinity")]
        [Validation(Required=false)]
        public string NodeAffinity { get; set; }

        /// <summary>
        /// <para>ack的节点标签限制</para>
        /// </summary>
        [NameInMap("NodeSelectors")]
        [Validation(Required=false)]
        public List<Tag> NodeSelectors { get; set; }

        [NameInMap("PodAffinity")]
        [Validation(Required=false)]
        public string PodAffinity { get; set; }

        [NameInMap("PodAntiAffinity")]
        [Validation(Required=false)]
        public string PodAntiAffinity { get; set; }

        [NameInMap("PreStartCommand")]
        [Validation(Required=false)]
        public List<string> PreStartCommand { get; set; }

        [NameInMap("Pvcs")]
        [Validation(Required=false)]
        public List<AckConfigPvcs> Pvcs { get; set; }
        public class AckConfigPvcs : TeaModel {
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public long? DataDiskSize { get; set; }

            [NameInMap("DataDiskStorageClass")]
            [Validation(Required=false)]
            public string DataDiskStorageClass { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        /// <summary>
        /// <para>Pod的CPU请求值</para>
        /// </summary>
        [NameInMap("RequestCpu")]
        [Validation(Required=false)]
        public float? RequestCpu { get; set; }

        /// <summary>
        /// <para>Pod的内存请求值。</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public float? RequestMemory { get; set; }

        /// <summary>
        /// <para>ack的节点污点容忍</para>
        /// </summary>
        [NameInMap("Tolerations")]
        [Validation(Required=false)]
        public List<Toleration> Tolerations { get; set; }

        [NameInMap("VolumeMounts")]
        [Validation(Required=false)]
        public List<AckConfigVolumeMounts> VolumeMounts { get; set; }
        public class AckConfigVolumeMounts : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        [NameInMap("Volumes")]
        [Validation(Required=false)]
        public List<AckConfigVolumes> Volumes { get; set; }
        public class AckConfigVolumes : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
