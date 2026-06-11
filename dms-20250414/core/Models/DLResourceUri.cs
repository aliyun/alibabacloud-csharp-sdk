// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class DLResourceUri : TeaModel {
        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ARCHIVE</para>
        /// </description></item>
        /// <item><description><para>JAR</para>
        /// </description></item>
        /// <item><description><para>FILE</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JAR</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The URL used to access the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hdfs://name****.example.com:8020/user/hive/udfs/my_***.jar</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

    }

}
