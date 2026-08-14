// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVpconnFromVbrRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without transforming the shared Express Connect circuits mode. The system checks the required parameters, request format, and instance status. If the check fails, the corresponding error is returned. If the check succeeds, the corresponding request ID is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a Normal request. After the request passes the check, the shared Express Connect circuits mode is transformed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The payer of the shared Express Connect circuits. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByPhysicalConnectionOwner</b>: The owner of the Express Connect circuit associated with the shared Express Connect circuits pays the fee.</description></item>
        /// <item><description><b>PayByVirtualPhysicalConnectionOwner</b>: The owner of the shared Express Connect circuits pays the fee.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByVirtualPhysicalConnectionOwner</para>
        /// </summary>
        [NameInMap("OrderMode")]
        [Validation(Required=false)]
        public string OrderMode { get; set; }

        /// <summary>
        /// <para>The region ID of the shared Express Connect circuits.</para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>The instance ID of the cross-account VBR.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vbr-bp136flp1mf8mlq6r****</para>
        /// </summary>
        [NameInMap("VbrId")]
        [Validation(Required=false)]
        public string VbrId { get; set; }

    }

}
