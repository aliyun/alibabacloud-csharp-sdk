// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateHostGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("aliyunRegion")]
        [Validation(Required=false)]
        public string AliyunRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ecsLabelKey")]
        [Validation(Required=false)]
        public string EcsLabelKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ecsLabelValue")]
        [Validation(Required=false)]
        public string EcsLabelValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECS_ALIYUN</para>
        /// </summary>
        [NameInMap("ecsType")]
        [Validation(Required=false)]
        public string EcsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("envId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;aliyunRegionId&quot;:&quot;cn-beijing&quot;,&quot;machineSn&quot;:&quot;i-sssssss&quot;,&quot;instanceName&quot;:&quot;ceshi&quot;,&quot;ip&quot;:&quot;120.0.0.0&quot;}]</para>
        /// </summary>
        [NameInMap("machineInfos")]
        [Validation(Required=false)]
        public string MachineInfos { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("serviceConnectionId")]
        [Validation(Required=false)]
        public long? ServiceConnectionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12,23</para>
        /// </summary>
        [NameInMap("tagIds")]
        [Validation(Required=false)]
        public string TagIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
