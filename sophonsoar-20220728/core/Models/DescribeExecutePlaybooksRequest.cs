// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeExecutePlaybooksRequest : TeaModel {
        /// <summary>
        /// <para>The entity type of the script input parameter. When you want to query multiple entity types, separate them with commas.</para>
        /// <list type="bullet">
        /// <item><description><b>ip</b>: IP entity.</description></item>
        /// <item><description><b>file</b>: file entity.</description></item>
        /// <item><description><b>process</b>: process entity.</description></item>
        /// <item><description><b>incident</b>: incident entity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip,file,process,host</para>
        /// </summary>
        [NameInMap("InputMode")]
        [Validation(Required=false)]
        public string InputMode { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
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
        /// <para>The input parameter type of the playbook.</para>
        /// <list type="bullet">
        /// <item><description><b>template-ip</b></description></item>
        /// <item><description><b>template-file</b></description></item>
        /// <item><description><b>template-process</b></description></item>
        /// <item><description><b>custom</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The playbook name. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_test</para>
        /// </summary>
        [NameInMap("PlaybookName")]
        [Validation(Required=false)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// <para>The playbook UUID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to query the playbook UUID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>f916b93e-e814-459f-9662-xxxxxx</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
