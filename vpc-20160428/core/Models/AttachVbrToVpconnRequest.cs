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
        /// <item><description><b>true</b>: performs a dry run without associating the VBR instance with the shared Express Connect circuits. The system checks the required parameters, request format, and instance status. If the check fails, the corresponding error is returned. If the check succeeds, the request ID is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. After the check succeeds, the VBR instance is directly associated with the shared Express Connect circuits.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The client token must be unique among different requests and cannot exceed 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBCE910E-D396-4944-8****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The instance ID of the VBR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp133sn3nwjvu7twc****</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

        /// <summary>
        /// <para>The instance ID of the shared Express Connect circuits.</para>
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
