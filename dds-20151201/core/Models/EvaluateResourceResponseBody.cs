// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class EvaluateResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the resources are sufficient in the region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: The resources are sufficient.</description></item>
        /// <item><description><b>0</b>: The resources are insufficient.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBInstanceAvailable")]
        [Validation(Required=false)]
        public string DBInstanceAvailable { get; set; }

        /// <summary>
        /// <para>The database engine of the instance. Only MongoDB is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The version of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE2DE465-E45F-481F-ABD8-37D64173****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
