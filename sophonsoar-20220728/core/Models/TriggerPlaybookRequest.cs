// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerPlaybookRequest : TeaModel {
        /// <summary>
        /// <para>The input parameters for the playbook.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;input1&quot;: &quot;xx.xx.xx.xx&quot;,
        ///     &quot;input2&quot;: &quot;7d&quot;
        /// }</para>
        /// </summary>
        [NameInMap("InputParam")]
        [Validation(Required=false)]
        public string InputParam { get; set; }

        /// <summary>
        /// <para>The UUID of the playbook.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribePlaybooks~~">DescribePlaybooks</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2a687089-d4dd-47d4-9709-xxxxxxxx</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
