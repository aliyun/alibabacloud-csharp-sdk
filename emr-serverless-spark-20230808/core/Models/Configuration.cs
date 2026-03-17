// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Configuration : TeaModel {
        /// <summary>
        /// <para>The name of the configuration file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>common.conf</para>
        /// </summary>
        [NameInMap("configFileName")]
        [Validation(Required=false)]
        public string ConfigFileName { get; set; }

        /// <summary>
        /// <para>The name of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive.metastore.type</para>
        /// </summary>
        [NameInMap("configItemKey")]
        [Validation(Required=false)]
        public string ConfigItemKey { get; set; }

        /// <summary>
        /// <para>The value of the configuration item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER_RDS</para>
        /// </summary>
        [NameInMap("configItemValue")]
        [Validation(Required=false)]
        public string ConfigItemValue { get; set; }

    }

}
