// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalProcessesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page for paging in a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The Settings for the number of entries per page for paging in a paged query. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the associated business policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pid-6d6ad77d5b52****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The type of the adapted policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DomainBlacklist</b>: domain name blacklist</description></item>
        /// <item><description><b>DomainWhitelist</b>: domain name whitelist</description></item>
        /// <item><description><b>SoftwareBlock</b>: software blocking</description></item>
        /// <item><description><b>AppUninstall</b>: endpoint uninstallation</description></item>
        /// <item><description><b>DlpSend</b>: file sending</description></item>
        /// <item><description><b>PeripheralBlock</b>: peripheral control</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DlpSend</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The IDs of the approval processes.</para>
        /// </summary>
        [NameInMap("ProcessIds")]
        [Validation(Required=false)]
        public List<string> ProcessIds { get; set; }

        /// <summary>
        /// <para>The name of the template. The name must be 1 to 128 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The ID of the associated approver. You can call the following operation to obtain the value:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUsers~~">ListUsers</a>: List users.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>su_e8f218fb171edd167c2ad917d21f53148bdefc510ca1f3c3cc0249d3643d****</para>
        /// </summary>
        [NameInMap("SaseUserId")]
        [Validation(Required=false)]
        public string SaseUserId { get; set; }

        /// <summary>
        /// <para>The username of the associated approver.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mr. Wang</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
