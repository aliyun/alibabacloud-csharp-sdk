// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InitializeEHPCRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region where the service-linked role is created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188593.html">ListRegions</a> operation to obtain the IDs of regions supported by E-HPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the service for which you must create a service-linked role. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>E-HPC: You must create the AliyunServiceRoleForEHPC service-linked role.</description></item>
        /// <item><description>E-HPC Instant: You must create the AliyunServiceRoleForEHPCManagedNetwork service-linked role.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>E-HPC</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
