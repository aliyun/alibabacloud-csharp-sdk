// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryRecognizeDataByRuleTypeRequest : TeaModel {
        /// <summary>
        /// <para>The recognition rule type. You can call the <a href="https://help.aliyun.com/document_detail/2746905.html">QueryRecognizeRulesType</a> operation to obtain the rule types.</para>
        /// <list type="bullet">
        /// <item><description>1: regular expression</description></item>
        /// <item><description>2: built-in model</description></item>
        /// <item><description>3: sample library</description></item>
        /// <item><description>4: auto-generated model</description></item>
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
        /// <para>The tenant ID. Log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the DataStudio page, click the username in the upper-right corner, and choose Menu &gt; User Info to obtain the tenant ID.</para>
        /// <para>You can also obtain the tenant ID from Data.TenantId in the response of the GetProject operation.</para>
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
