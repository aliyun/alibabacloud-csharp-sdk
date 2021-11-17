/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20210226.Models
{
    public class Cluster : TeaModel {
        /// <summary>
        /// 集群id
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// 集群配置
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// nas文件id
        /// </summary>
        [NameInMap("Nas")]
        [Validation(Required=false)]
        public string Nas { get; set; }

        /// <summary>
        /// 集群owner
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// 个人nas挂载到容器路径
        /// </summary>
        [NameInMap("PrivateContainerPath")]
        [Validation(Required=false)]
        public string PrivateContainerPath { get; set; }

        /// <summary>
        /// 个人nas挂载路径
        /// </summary>
        [NameInMap("PrivateNasPath")]
        [Validation(Required=false)]
        public string PrivateNasPath { get; set; }

        /// <summary>
        /// 公共nas挂载到容器的路径
        /// </summary>
        [NameInMap("PublicContainerPath")]
        [Validation(Required=false)]
        public string PublicContainerPath { get; set; }

        /// <summary>
        /// 公共nas挂载路径
        /// </summary>
        [NameInMap("PublicNasPath")]
        [Validation(Required=false)]
        public string PublicNasPath { get; set; }

        /// <summary>
        /// 集群状态
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// 集群vSwitch
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// 集群vpc
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
