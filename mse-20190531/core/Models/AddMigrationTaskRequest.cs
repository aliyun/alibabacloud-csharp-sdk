// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddMigrationTaskRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Nacos-Ans</description></item>
        /// <item><description>ZooKeeper</description></item>
        /// <item><description>Eureka</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Nacos-Ans</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The address of the source instance node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.1:8848</para>
        /// </summary>
        [NameInMap("OriginInstanceAddress")]
        [Validation(Required=false)]
        public string OriginInstanceAddress { get; set; }

        /// <summary>
        /// <para>The name of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Source cluster</para>
        /// </summary>
        [NameInMap("OriginInstanceName")]
        [Validation(Required=false)]
        public string OriginInstanceName { get; set; }

        /// <summary>
        /// <para>The list of namespaces. This parameter is optional when the source cluster is Nacos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namesapceId1,namesapceId2</para>
        /// </summary>
        [NameInMap("OriginInstanceNamespace")]
        [Validation(Required=false)]
        public string OriginInstanceNamespace { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description.</para>
        /// </summary>
        [NameInMap("ProjectDesc")]
        [Validation(Required=false)]
        public string ProjectDesc { get; set; }

        /// <summary>
        /// <para>The extended request parameters in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>The synchronization type. Valid values: configuration synchronization, service synchronization, or full synchronization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Service</para>
        /// </summary>
        [NameInMap("SyncType")]
        [Validation(Required=false)]
        public string SyncType { get; set; }

        /// <summary>
        /// <para>The name of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Target cluster</para>
        /// </summary>
        [NameInMap("TargetClusterName")]
        [Validation(Required=false)]
        public string TargetClusterName { get; set; }

        /// <summary>
        /// <para>The URL of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-66*****-nacos-ans.mse.aliyuncs.com:8848</para>
        /// </summary>
        [NameInMap("TargetClusterUrl")]
        [Validation(Required=false)]
        public string TargetClusterUrl { get; set; }

        /// <summary>
        /// <para>The instance ID of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-ud82*****</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

    }

}
