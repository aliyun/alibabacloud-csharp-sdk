// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DetachPolicy2ApprovalProcessRequest : TeaModel {
        /// <summary>
        /// <para>Business policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ladp-27a4fedf5e73****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>Policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DomainBlacklist</b>: Domain blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>DomainWhitelist</b>: Domain whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>SoftwareBlock</b>: Software disable.</para>
        /// </description></item>
        /// <item><description><para><b>AppUninstall</b>: Terminal uninstall.</para>
        /// </description></item>
        /// <item><description><para><b>DlpSend</b>: File outbound transfer.</para>
        /// </description></item>
        /// <item><description><para><b>PeripheralBlock</b>: Peripheral control.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PeripheralBlock</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>Approval process ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval-process-2677fcf063f5****</para>
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

    }

}
