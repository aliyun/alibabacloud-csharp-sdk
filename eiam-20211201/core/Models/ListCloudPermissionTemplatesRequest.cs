// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudPermissionTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The cloud account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca_01kmegjc11qa1txxxxx</para>
        /// </summary>
        [NameInMap("CloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>Filters the results by template name prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AdminAccess</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateNamePrefix")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateNamePrefix { get; set; }

        /// <summary>
        /// <para>Filters the results by permission template sharing mode. Valid values: shared and exclusive. If this parameter is not specified, no filtering is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>shared</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateSharingMode")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateSharingMode { get; set; }

        /// <summary>
        /// <para>Filters the results by permission template usage type. Valid values: user (privilege escalation for human users) and application (privilege escalation for M2M applications).</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("CloudPermissionTemplateUsageType")]
        [Validation(Required=false)]
        public string CloudPermissionTemplateUsageType { get; set; }

        /// <summary>
        /// <para>Filters the results by creator type. Valid values: idaas_admin and idaas_user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_user</para>
        /// </summary>
        [NameInMap("CreatorType")]
        [Validation(Required=false)]
        public string CreatorType { get; set; }

        /// <summary>
        /// <para>The ID of the IDaaS EIAM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned from the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
