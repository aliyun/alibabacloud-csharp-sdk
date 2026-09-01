// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AttachVbrToVpconnRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without associating the VBR instance with shared Express Connect circuits. The system checks whether the required parameters are specified, the request format is valid, and the instance status is correct. If the check fails, the corresponding error is returned. If the check passes, the request ID is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. After the check passes, the VBR instance is directly associated with shared Express Connect circuits.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The region ID of the shared Express Connect circuits.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>The client token must be unique among different requests. The maximum length is 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBCE910E-D396-4944-8****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The VBR instance ID.</para>
        /// <remarks>
        /// <para>The ID of the VBR instance to be migrated. The VBR must currently be directly attached to an Express Connect circuit owned by the caller, and must be the same VBR specified in CreateVpconnFromVbr.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp133sn3nwjvu7twc****</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// <para>The ID of the shared Express Connect circuits (VirtualPhysicalConnection) instance.</para>
        /// <remarks>
        /// <para>The shared Express Connect circuits instance ID returned by CreateVpconnFromVbr. The instance must have been confirmed and accepted by the tenant (Confirmed) and be in the Enabled state.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1mrgfbtmc9brre7****</para>
        /// </summary>
        [NameInMap("VpconnId")]
        [Validation(Required=false)]
        public string VpconnId { get; set; }

    }

}
