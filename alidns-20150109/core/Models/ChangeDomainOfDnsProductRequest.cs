// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ChangeDomainOfDnsProductRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcefully attach the domain name.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: No</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Yes</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// <para>The ID of the Cloud DNS product.
        /// You can obtain the ID by calling <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-listcloudgtminstances?spm=a2c63.p38356.help-menu-search-29697.d_0">ListCloudGtmInstances</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-7XX</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is <b>zh</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The domain name that you want to attach. If you leave this parameter empty, the currently attached domain name is detached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("NewDomain")]
        [Validation(Required=false)]
        public string NewDomain { get; set; }

        /// <summary>
        /// <para>The client IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

    }

}
