// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApprovalSchemasRequest : TeaModel {
        /// <summary>
        /// <para>The current page number for paged queries. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paged queries. Valid values: 1 to 500.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DomainBlacklist</b>: Domain blacklist.</para>
        /// </description></item>
        /// <item><description><para><b>DomainWhitelist</b>: Domain whitelist.</para>
        /// </description></item>
        /// <item><description><para><b>SoftwareBlock</b>: Software disable.</para>
        /// </description></item>
        /// <item><description><para><b>AppUninstall</b>: Terminal uninstall.</para>
        /// </description></item>
        /// <item><description><para><b>DlpSend</b>: File outbound.</para>
        /// </description></item>
        /// <item><description><para><b>PeripheralBlock</b>: Peripheral control.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DlpSend</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>Collection of approval template IDs.</para>
        /// </summary>
        [NameInMap("SchemaIds")]
        [Validation(Required=false)]
        public List<string> SchemaIds { get; set; }

        /// <summary>
        /// <para>The template name. It can be 1 to 128 characters long. It supports Chinese characters, uppercase and lowercase English letters, numbers, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SchemaName")]
        [Validation(Required=false)]
        public string SchemaName { get; set; }

    }

}
