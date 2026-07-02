// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKmsInstanceQuotaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the KMS instance to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kst-bjj62f5ba3dnpb6v8****</para>
        /// </summary>
        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>key</c>: key quota</para>
        /// </description></item>
        /// <item><description><para><c>secret</c>: secret quota</para>
        /// </description></item>
        /// <item><description><para><c>qps</c>: queries per second (QPS) quota</para>
        /// </description></item>
        /// <item><description><para><c>vpc</c>: Virtual Private Cloud (VPC) quota</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
