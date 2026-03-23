// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ValidateEmailRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to check the graylist. The default value is false. The result is sent through an asynchronous notification message from EventBridge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CheckGraylist")]
        [Validation(Required=false)]
        public bool? CheckGraylist { get; set; }

        /// <summary>
        /// <para>The email address to validate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxx@yyy.com">xxx@yyy.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The timeout period. The default value is 60 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
