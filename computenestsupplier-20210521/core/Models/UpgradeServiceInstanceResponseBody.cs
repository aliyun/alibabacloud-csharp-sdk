// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpgradeServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F224E002-AB0E-5FD9-A87E-54AEE56F6CAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-5cbae874da0e47xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The deployment state of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Created</description></item>
        /// <item><description>Deploying</description></item>
        /// <item><description>DeployedFailed</description></item>
        /// <item><description>Deployed</description></item>
        /// <item><description>Upgrading</description></item>
        /// <item><description>Deleting</description></item>
        /// <item><description>Deleted</description></item>
        /// <item><description>DeletedFailed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The parameters required for the upgrade.</para>
        /// </summary>
        [NameInMap("UpgradeRequiredParameters")]
        [Validation(Required=false)]
        public List<string> UpgradeRequiredParameters { get; set; }

    }

}
