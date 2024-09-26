// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryRecognizeDataByRuleTypeRequest : TeaModel {
        /// <summary>
        /// <para>The type of a sensitive data identification rule. You can call the <a href="https://help.aliyun.com/document_detail/2746905.html">QueryRecognizeRulesType</a> operation to obtain the type of the rule.</para>
        /// <list type="bullet">
        /// <item><description>1: regular expression</description></item>
        /// <item><description>2: built-in rule</description></item>
        /// <item><description>3: sample library</description></item>
        /// <item><description>4: self-generated data identification model</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecognizeRulesType")]
        [Validation(Required=false)]
        public string RecognizeRulesType { get; set; }

        /// <summary>
        /// <para>The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>. Find your workspace and go to the DataStudio page. On the DataStudio page, click the logon username in the upper-right corner and click User Info in the Menu section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10241024</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
