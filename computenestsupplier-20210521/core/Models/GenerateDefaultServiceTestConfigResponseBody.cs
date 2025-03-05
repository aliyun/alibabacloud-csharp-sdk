// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GenerateDefaultServiceTestConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>51945B04-6AA6-410D-93BA-236E0248B104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service test config</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// <para>parameters:
        ///   PayType: &quot;PostPaid&quot;
        ///   EcsInstanceType: &quot;$[iact3-auto]&quot;
        ///   InstancePassword: &quot;$[iact3-auto]&quot;</para>
        /// </summary>
        [NameInMap("TestConfig")]
        [Validation(Required=false)]
        public string TestConfig { get; set; }

    }

}
