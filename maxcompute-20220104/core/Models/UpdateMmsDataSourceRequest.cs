// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateMmsDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The type of the update operation:</para>
        /// <ol>
        /// <item><description>UPDATE_CONFIG: updates the data source configuration.</description></item>
        /// <item><description>START: starts the data source instance.</description></item>
        /// <item><description>STOP: shuts down the data source instance.</description></item>
        /// <item><description>RENAME: renames the data source.</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>UPDATE_CONFIG</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The data source configuration. The configuration items vary based on the data source.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>The new name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dept1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Tests the data source configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("test")]
        [Validation(Required=false)]
        public bool? Test { get; set; }

    }

}
