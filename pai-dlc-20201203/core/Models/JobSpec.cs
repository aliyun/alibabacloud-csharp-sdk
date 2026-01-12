// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobSpec : TeaModel {
        [NameInMap("AssignNodeSpec")]
        [Validation(Required=false)]
        public AssignNodeSpec AssignNodeSpec { get; set; }

        [NameInMap("AutoScalingSpec")]
        [Validation(Required=false)]
        public AutoScalingSpec AutoScalingSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.c6.large</para>
        /// </summary>
        [NameInMap("EcsSpec")]
        [Validation(Required=false)]
        public string EcsSpec { get; set; }

        [NameInMap("ExtraPodSpec")]
        [Validation(Required=false)]
        public ExtraPodSpec ExtraPodSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/pai-dlc/tensorflow-training:1.12.2PAI-cpu-py27-ubuntu16.04</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("ImageConfig")]
        [Validation(Required=false)]
        public ImageConfig ImageConfig { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("IsCheif")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? IsCheif { get; set; }

        [NameInMap("IsChief")]
        [Validation(Required=false)]
        public bool? IsChief { get; set; }

        [NameInMap("LocalMountSpecs")]
        [Validation(Required=false)]
        public List<LocalMountSpec> LocalMountSpecs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PodCount")]
        [Validation(Required=false)]
        public long? PodCount { get; set; }

        [NameInMap("ResourceConfig")]
        [Validation(Required=false)]
        public ResourceConfig ResourceConfig { get; set; }

        [NameInMap("RestartPolicy")]
        [Validation(Required=false)]
        public string RestartPolicy { get; set; }

        [NameInMap("ServiceSpec")]
        [Validation(Required=false)]
        public ServiceSpec ServiceSpec { get; set; }

        [NameInMap("SpotSpec")]
        [Validation(Required=false)]
        public SpotSpec SpotSpec { get; set; }

        [NameInMap("StartupDependencies")]
        [Validation(Required=false)]
        public List<StartupDependency> StartupDependencies { get; set; }

        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public SystemDisk SystemDisk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Worker</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseSpotInstance")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? UseSpotInstance { get; set; }

    }

}
