// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVbrHaRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure uniqueness across different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CBCE910E-D396-4944-8****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without starting the instance. The system checks whether required parameters are specified, whether the request format is valid, and whether the instance status is valid. If the check fails, the corresponding error is returned. If the check succeeds, <c>DRYRUN.SUCCESS</c> is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. After the request passes the check, the instance is directly started.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the VBR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The VBR failover group instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbrha-sa1sxheuxtd98****</para>
        /// </summary>
        [NameInMap("VbrHaId")]
        [Validation(Required=false)]
        public string VbrHaId { get; set; }

        /// <summary>
        /// <para>The VBR instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp1jcg5cmxjbl9xgc****</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

    }

}
