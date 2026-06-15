// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ValidateEmailResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain part of the email address parsed from the syntax check. The domain part is converted to lowercase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyy.com</para>
        /// </summary>
        [NameInMap("DomainPart")]
        [Validation(Required=false)]
        public string DomainPart { get; set; }

        /// <summary>
        /// <para>Indicates whether the address is from a free email service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFreeMail")]
        [Validation(Required=false)]
        public bool? IsFreeMail { get; set; }

        /// <summary>
        /// <para>The local part of the email address parsed from the syntax check. The local part is converted to lowercase and the content after the plus sign (+) is removed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("LocalPart")]
        [Validation(Required=false)]
        public string LocalPart { get; set; }

        /// <summary>
        /// <para>The email service provider of the address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Gmail</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The validation status of the email address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The detailed validation status of the email address. This provides more information about the Status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNSPECIFIED</para>
        /// </summary>
        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

    }

}
