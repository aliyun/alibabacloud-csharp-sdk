// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ApplicationConfigParam : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DELETE</para>
        /// </summary>
        [NameInMap("ConfigAction")]
        [Validation(Required=false)]
        public string ConfigAction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>hdfs-site.xml</para>
        /// </summary>
        [NameInMap("ConfigFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>namenode checkpoint period</para>
        /// </summary>
        [NameInMap("ConfigItemDescription")]
        [Validation(Required=false)]
        public string ConfigItemDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dfs.namenode.checkpoint.period</para>
        /// </summary>
        [NameInMap("ConfigItemKey")]
        [Validation(Required=false)]
        public string ConfigItemKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600s</para>
        /// </summary>
        [NameInMap("ConfigItemValue")]
        [Validation(Required=false)]
        public string ConfigItemValue { get; set; }

        [NameInMap("ConfigScope")]
        [Validation(Required=false)]
        public string ConfigScope { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RESTART</para>
        /// </summary>
        [NameInMap("EffectiveActions")]
        [Validation(Required=false)]
        public string EffectiveActions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MANUAL</para>
        /// </summary>
        [NameInMap("EffectiveType")]
        [Validation(Required=false)]
        public string EffectiveType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>G-DE1CF4661E09****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>i-bp10h9rezawz1i4o****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
