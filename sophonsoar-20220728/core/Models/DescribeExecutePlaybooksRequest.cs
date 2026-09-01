// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeExecutePlaybooksRequest : TeaModel {
        /// <summary>
        /// <para>The entity type of the input parameter for the playbook. To query multiple entity types, separate them with commas.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ip</b>: IP entity.</para>
        /// </description></item>
        /// <item><description><para><b>file</b>: file entity.</para>
        /// </description></item>
        /// <item><description><para><b>process</b>: process entity.</para>
        /// </description></item>
        /// <item><description><para><b>incident</b>: event entity.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip,file,process,host</para>
        /// </summary>
        [NameInMap("InputMode")]
        [Validation(Required=false)]
        public string InputMode { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
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
        /// <para>The type of the input parameter for the playbook.</para>
        /// <list type="bullet">
        /// <item><description><para><b>template-ip</b>: IP request template.</para>
        /// </description></item>
        /// <item><description><para><b>template-file</b>: file request template.</para>
        /// </description></item>
        /// <item><description><para><b>template-process</b>: process request template.</para>
        /// </description></item>
        /// <item><description><para><b>custom</b>: custom parameter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The name of the playbook. Fuzzy search is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_test</para>
        /// </summary>
        [NameInMap("PlaybookName")]
        [Validation(Required=false)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to obtain this parameter.</para>
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
