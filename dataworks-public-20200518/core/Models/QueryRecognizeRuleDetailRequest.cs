// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryRecognizeRuleDetailRequest : TeaModel {
        /// <summary>
        /// The name of the sensitive field. To obtain the name of the sensitive field, call the [QuerySensNodeInfo](https://help.aliyun.com/document_detail/2747189.html) operation or log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Data Category and Sensitivity Level page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

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
