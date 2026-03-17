// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DissociateSmartAGFromApplicationBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the bandwidth plan for application acceleration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abwp-7963l7iqnquyj3****</para>
        /// </summary>
        [NameInMap("ApplicationBandwidthPackageId")]
        [Validation(Required=false)]
        public string ApplicationBandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must make sure that it is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, ClientToken is set to the value of RequestId. The value of RequestId for each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to precheck the request. Check items include permissions and the status of the specified cloud resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends the request. After the request passes the check, the SAG instance is disassociated from the bandwidth plan for application acceleration.</description></item>
        /// <item><description><b>true</b>: prechecks the request but does not disassociate the SAG instance from the bandwidth plan for application acceleration. If you use this value, the system checks the required parameters and the request syntax. If the request fails the precheck, an error message is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The region ID of the bandwidth plan for application acceleration.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-w11hk4bqxpakem****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The list of the SAG instance id.</para>
        /// </summary>
        [NameInMap("SmartAGIdList")]
        [Validation(Required=false)]
        public List<string> SmartAGIdList { get; set; }

    }

}
