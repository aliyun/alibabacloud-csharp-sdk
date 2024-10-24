// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetSmsTemplateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>SMS template code.</para>
        /// <list type="bullet">
        /// <item><description>Obtain the SMS template code from the return parameters of the <a href="https://help.aliyun.com/zh/sms/developer-reference/api-dysmsapi-2017-05-25-createsmstemplate?spm">CreateSmsTemplate</a> API.</description></item>
        /// <item><description>View the SMS template code on the <a href="https://dysms.console.aliyun.com/domestic/text/template">Template Management</a> page.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SMS_20375****</para>
        /// </summary>
        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

    }

}
