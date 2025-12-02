// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20250903.Models
{
    public class GetPlaybookRequest : TeaModel {
        /// <summary>
        /// <para>The language type for requests and received messages.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e99dab31-499b-4307-9248-xxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The version ID of the playbook, which is only effective when <b>PlaybookVersionType</b> is <b>History</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36c9dcd6-<b><b>-4262-</b></b>-d508464ebd21</para>
        /// </summary>
        [NameInMap("PlaybookVersion")]
        [Validation(Required=false)]
        public string PlaybookVersion { get; set; }

        /// <summary>
        /// <para>The version type of the playbook, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>Draft</b>: Editing state.</description></item>
        /// <item><description><b>Online</b>: Online version.</description></item>
        /// <item><description><b>History</b>: Historical version.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>History</para>
        /// </summary>
        [NameInMap("PlaybookVersionType")]
        [Validation(Required=false)]
        public string PlaybookVersionType { get; set; }

        /// <summary>
        /// <para>The user ID for the administrator to switch to another member\&quot;s perspective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13760*****718726</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
