// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDeploymentSetSupportedInstanceTypeFamilyResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance families that support the deployment strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.i2g,ecs.i1,ecs.i2ne,ecs.i2gne</para>
        /// </summary>
        [NameInMap("InstanceTypeFamilies")]
        [Validation(Required=false)]
        public string InstanceTypeFamilies { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B7DB-A3DC7DE1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
