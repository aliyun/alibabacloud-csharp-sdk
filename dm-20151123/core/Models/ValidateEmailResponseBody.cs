// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ValidateEmailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>yyy.com</para>
        /// </summary>
        [NameInMap("DomainPart")]
        [Validation(Required=false)]
        public string DomainPart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsFreeMail")]
        [Validation(Required=false)]
        public bool? IsFreeMail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("LocalPart")]
        [Validation(Required=false)]
        public string LocalPart { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Gmail</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
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
