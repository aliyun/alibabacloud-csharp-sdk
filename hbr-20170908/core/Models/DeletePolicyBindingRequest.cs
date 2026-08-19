// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DeletePolicyBindingRequest : TeaModel {
        /// <summary>
        /// <para>The list of data source IDs to dissociate from the policy.</para>
        /// </summary>
        [NameInMap("DataSourceIds")]
        [Validation(Required=false)]
        public List<string> DataSourceIds { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>po-000************hgp</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UDM_ECS</b>: ECS instance backup.</description></item>
        /// <item><description><b>OSS</b>: OSS backup.</description></item>
        /// <item><description><b>NAS</b>: Alibaba Cloud NAS backup.</description></item>
        /// <item><description><b>COMMON_NAS</b>: On-premises NAS backup.</description></item>
        /// <item><description><b>ECS_FILE</b>: ECS File Backup Essential Edition.</description></item>
        /// <item><description><b>File</b>: On-premises file backup.</description></item>
        /// <item><description><b>COMMON_FILE_SYSTEM</b>: CPFS backup.</description></item>
        /// <item><description><b>OTS</b>: Tablestore backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UDM_ECS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
