// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class QueryRecognizeRuleDetailRequest : TeaModel {
        /// <summary>
        /// <para>The name of the sensitive field. You can call the <a href="https://help.aliyun.com/document_detail/2747189.html">QuerySensNodeInfo</a> operation or go to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and navigate to the data classification page of Data Security Guard to obtain the name of the sensitive field.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("SensitiveName")]
        [Validation(Required=false)]
        public string SensitiveName { get; set; }

        /// <summary>
        /// <para>The tenant ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>, go to the Data Studio page, click the username of the current user in the upper-right corner, and choose Menu &gt; User Information to obtain the tenant ID.</para>
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
