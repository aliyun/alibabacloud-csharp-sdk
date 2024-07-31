// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryRecognizeDataByRuleTypeRequest : TeaModel {
        /// <summary>
        /// The type of a sensitive data identification rule. You can call the [QueryRecognizeRulesType](https://help.aliyun.com/document_detail/2746905.html) operation to obtain the type of the rule.
        /// 
        /// *   1: regular expression
        /// *   2: built-in rule
        /// *   3: sample library
        /// *   4: self-generated data identification model
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RecognizeRulesType")]
        [Validation(Required=false)]
        public string RecognizeRulesType { get; set; }

        /// <summary>
        /// The tenant ID. To obtain the tenant ID, perform the following steps: Log on to the [DataWorks console](https://workbench.data.aliyun.com/console). Find your workspace and go to the DataStudio page. On the DataStudio page, click the logon username in the upper-right corner and click User Info in the Menu section.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
