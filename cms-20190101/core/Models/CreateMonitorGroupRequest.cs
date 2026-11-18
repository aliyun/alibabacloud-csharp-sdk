// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMonitorGroupRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. You can generate a parameter value from your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters and can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6868E9A1-56E6-5FD7-9684-E2963BBAFB5F</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The alert contact group. Alert notifications for the application group are sent to the alert contacts in this alert contact group.</para>
        /// <remarks>
        /// <para>An alert contact group is a collection of alert contacts and can contain one or more alert contacts. For more information about how to create alert contacts and alert contact groups, see <a href="~~PutContact~~">PutContact</a> and <a href="~~PutContactGroup~~">PutContactGroup</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Alert_Group</para>
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request, including permission and instance status checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Sends a normal request. If the request passes the check, the name and description of the route table are modified.</description></item>
        /// <item><description><b>true</b>: Sends a dry run request. Only validation is performed, and the name and description of the route table are not modified. Check items include whether required parameters are specified and the request format. If the check fails, the corresponding error is returned. If the check passes, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The name of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS_Group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
