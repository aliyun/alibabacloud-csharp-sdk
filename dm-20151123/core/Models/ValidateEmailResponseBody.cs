// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ValidateEmailResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain part of the email address parsed from syntax validation (lowercased)</para>
        /// 
        /// <b>Example:</b>
        /// <para>yyy.com</para>
        /// </summary>
        [NameInMap("DomainPart")]
        [Validation(Required=false)]
        public string DomainPart { get; set; }

        /// <summary>
        /// <para>Indicates whether the address is a free email</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFreeMail")]
        [Validation(Required=false)]
        public bool? IsFreeMail { get; set; }

        /// <summary>
        /// <para>The local part of the email address parsed from syntax validation (lowercased with the plus sign portion removed)</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("LocalPart")]
        [Validation(Required=false)]
        public string LocalPart { get; set; }

        /// <summary>
        /// <para>Email provider classification of the address</para>
        /// 
        /// <b>Example:</b>
        /// <para>Gmail</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The email address status obtained from validation</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The email address sub-status obtained from validation, which provides a detailed description of the status</para>
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
