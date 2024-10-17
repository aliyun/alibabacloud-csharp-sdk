// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ApplicationConfig : TeaModel {
        /// <summary>
        /// <para>应用名称。从EMR控制台集群创建页面可查看到指定发行版的应用名称列表。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HDFS</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>应用配置文件名。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs-site.xml</para>
        /// </summary>
        [NameInMap("ConfigFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        /// <summary>
        /// <para>配置项键。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfs.namenode.checkpoint.period</para>
        /// </summary>
        [NameInMap("ConfigItemKey")]
        [Validation(Required=false)]
        public string ConfigItemKey { get; set; }

        /// <summary>
        /// <para>配置项值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600s</para>
        /// </summary>
        [NameInMap("ConfigItemValue")]
        [Validation(Required=false)]
        public string ConfigItemValue { get; set; }

        /// <summary>
        /// <para>配置范围。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>CLUSTER：集群级别。</description></item>
        /// <item><description>NODE_GROUP：节点组级别。</description></item>
        /// </list>
        /// <para>默认值：CLUSTER。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NODE_GROUP</para>
        /// </summary>
        [NameInMap("ConfigScope")]
        [Validation(Required=false)]
        public string ConfigScope { get; set; }

        /// <summary>
        /// <para>节点组ID。ConfigScope取值NODE_GROUP时，该参数生效。NodeGroupId参数优先级高于NodeGroupName。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>节点组名称。ConfigScope取值NODE_GROUP时，且参数NodeGroupId为空时生效，该参数生效。</para>
        /// 
        /// <b>Example:</b>
        /// <para>core-1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

    }

}
