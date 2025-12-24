// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class CopyPlaybookRequest : TeaModel {
        /// <summary>
        /// <para>The description of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>playbook description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>playbook_xxx</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default).</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The release version of the playbook that you want to copy. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>\-1: The version that is being edited.</description></item>
        /// <item><description>0: The latest online version of the current playbook.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReleaseVersion")]
        [Validation(Required=false)]
        public string ReleaseVersion { get; set; }

        /// <summary>
        /// <para>The ID of the user who switches from the current view to the destination view by using the management account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137602*****718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b> (default): the view of the current account.</description></item>
        /// <item><description><b>1</b>: the view of the global account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook that you want to copy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to query the UUIDs of playbooks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94bc318c-<b><b>-4cba-</b></b>-801ccb0d739f</para>
        /// </summary>
        [NameInMap("SourcePlaybookUuid")]
        [Validation(Required=false)]
        public string SourcePlaybookUuid { get; set; }

    }

}
