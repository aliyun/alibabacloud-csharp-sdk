// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetRemediationTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the automatic remediation template.</para>
        /// <para>For more information about how to obtain the ID of a remediation template, see <a href="https://help.aliyun.com/document_detail/2337741.html">Compliance library</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS-ALB-BulkyEnableDeletionProtection</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("TemplateIdentifier")]
        [Validation(Required=false)]
        public string TemplateIdentifier { get; set; }

    }

}
