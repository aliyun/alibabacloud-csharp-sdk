// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class UpdateApplicationConfig : TeaModel {
        /// <summary>
        /// <para>修改描述。</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfs.namenode.checkpoint.period</para>
        /// </summary>
        [NameInMap("ConfigDescription")]
        [Validation(Required=false)]
        public string ConfigDescription { get; set; }

        /// <summary>
        /// <para>应用配置文件名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs-site.xml</para>
        /// </summary>
        [NameInMap("ConfigFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        /// <summary>
        /// <para>配置项键。</para>
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

    }

}
