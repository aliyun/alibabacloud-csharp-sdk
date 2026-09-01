// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class CreatePlaybookRequest : TeaModel {
        /// <summary>
        /// <para>The description of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a new version</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test09</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The input configuration of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;key1\&quot;: \&quot;value1\&quot;, \&quot;key2\&quot;: \&quot;value2\&quot;}</para>
        /// </summary>
        [NameInMap("InputParams")]
        [Validation(Required=false)]
        public string InputParams { get; set; }

        /// <summary>
        /// <para>The language of the messages to receive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
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
        /// <para>The output configuration of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;result\&quot;: \&quot;success\&quot;}</para>
        /// </summary>
        [NameInMap("OutputParams")]
        [Validation(Required=false)]
        public string OutputParams { get; set; }

        /// <summary>
        /// <para>The configuration format of the playbook.</para>
        /// <list type="bullet">
        /// <item><description><para><b>xml</b>: XML format.</para>
        /// </description></item>
        /// <item><description><para><b>x6</b>: JSON format.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>x6</para>
        /// </summary>
        [NameInMap("TaskflowType")]
        [Validation(Required=false)]
        public string TaskflowType { get; set; }

    }

}
