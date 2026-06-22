// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ApplicationConfig : TeaModel {
        /// <summary>
        /// <para>The name of the application. You can view the application names of each EMR version on the cluster creation page in the EMR console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HDFS</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The name of the configuration file.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs-site.xml</para>
        /// </summary>
        [NameInMap("ConfigFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        /// <summary>
        /// <para>The key of the configuration item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfs.namenode.checkpoint.period</para>
        /// </summary>
        [NameInMap("ConfigItemKey")]
        [Validation(Required=false)]
        public string ConfigItemKey { get; set; }

        /// <summary>
        /// <para>The value of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600s</para>
        /// </summary>
        [NameInMap("ConfigItemValue")]
        [Validation(Required=false)]
        public string ConfigItemValue { get; set; }

        /// <summary>
        /// <para>The level at which you want to apply the configurations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CLUSTER</description></item>
        /// <item><description>NODE_GROUP</description></item>
        /// </list>
        /// <para>Default value: CLUSTER.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NODE_GROUP</para>
        /// </summary>
        [NameInMap("ConfigScope")]
        [Validation(Required=false)]
        public string ConfigScope { get; set; }

        /// <summary>
        /// <para>The node group ID. This parameter takes effect only when the ConfigScope parameter is set to NODE_GROUP. The NodeGroupId parameter has a higher priority than the NodeGroupName parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-869471354ecd****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The name of the node group. This parameter takes effect only when the ConfigScope parameter is set to NODE_GROUP and the NodeGroupId parameter is not configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>core-1</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

    }

}
