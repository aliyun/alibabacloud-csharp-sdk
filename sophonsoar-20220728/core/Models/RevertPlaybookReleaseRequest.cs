// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class RevertPlaybookReleaseRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to directly publish the new playbook after the rollback.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsPublish")]
        [Validation(Required=false)]
        public bool? IsPublish { get; set; }

        /// <summary>
        /// <para>The version of the playbook that you want to publish.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybookReleases~~">DescribePlaybookReleases</a> operation to query the playbook version.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3f97b56e-064e-47e7-a309-xxxxxxx</para>
        /// </summary>
        [NameInMap("PlayReleaseId")]
        [Validation(Required=false)]
        public int? PlayReleaseId { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a>operation to query the playbook UUID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>185295a1-c987-4b64-8796-xxxxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
