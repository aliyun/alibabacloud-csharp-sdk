// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryRecognizeRuleDetailRequest : TeaModel {
        /// <summary>
        /// <para>The name of the sensitive field. To obtain the name of the sensitive field, call the <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> operation or log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Data Category and Sensitivity Level page.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

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
