// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookRequest : TeaModel {
        /// <summary>
        /// <para>A flag that indicates whether the version is a published version or a debug version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: retrieves the debug version.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: retrieves the published version.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DebugFlag")]
        [Validation(Required=false)]
        public int? DebugFlag { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
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
        /// <para>Call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to obtain this parameter.</para>
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
        /// <para>The MD5 value of the playbook configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7a8f608dc64c242632aa578xxxxx</para>
        /// </summary>
        [NameInMap("TaskflowMd5")]
        [Validation(Required=false)]
        public string TaskflowMd5 { get; set; }

    }

}
