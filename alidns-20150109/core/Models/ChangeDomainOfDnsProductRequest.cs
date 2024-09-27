// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ChangeDomainOfDnsProductRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to force bind a domain name to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud DNS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-7sb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language in which you want the values of some response parameters to be returned. These response parameters support multiple languages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The domain name that you want to bind to the instance. If you leave this parameter empty, the domain name that is bound to the instance is unbound from the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newdomain.com</para>
        /// </summary>
        [NameInMap("NewDomain")]
        [Validation(Required=false)]
        public string NewDomain { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
