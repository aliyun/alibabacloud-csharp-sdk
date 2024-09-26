// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgPlatformQueryProjectsAndSchemaFromMetaRequest : TeaModel {
        /// <summary>
        /// <para>The type of the compute engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ODPS.ODPS</description></item>
        /// <item><description>EMR</description></item>
        /// <item><description>HOLO.POSTGRES</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EMR</para>
        /// </summary>
        [NameInMap("EngineName")]
        [Validation(Required=false)]
        public string EngineName { get; set; }

    }

}
