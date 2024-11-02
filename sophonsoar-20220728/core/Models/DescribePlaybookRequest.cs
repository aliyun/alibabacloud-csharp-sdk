// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookRequest : TeaModel {
        /// <summary>
        /// <para>The flag that indicates whether the playbook is of the debugging or published version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: playbook of the debugging version</description></item>
        /// <item><description><b>0</b>: playbook of the published version</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DebugFlag")]
        [Validation(Required=false)]
        public int? DebugFlag { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
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
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a>operation to query the UUIDs of playbooks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9030076b-6733-4842-b05a-xxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The MD5 hash value of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7a8f608dc64c242632aa578xxxxx</para>
        /// </summary>
        [NameInMap("TaskflowMd5")]
        [Validation(Required=false)]
        public string TaskflowMd5 { get; set; }

    }

}
