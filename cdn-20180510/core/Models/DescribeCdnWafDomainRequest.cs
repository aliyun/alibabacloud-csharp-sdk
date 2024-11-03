// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnWafDomainRequest : TeaModel {
        /// <summary>
        /// <para>The domain name that you want to query.</para>
        /// <para>You can specify only one domain name in each request. You have three options to configure this parameter:</para>
        /// <list type="bullet">
        /// <item><description>Specify an exact domain name. For example, if you set this parameter to example.com, configuration information of example.com is queried.</description></item>
        /// <item><description>Specify a keyword. For example, if you set this parameter to example, configuration information about all domain names that contain example is queried.</description></item>
        /// <item><description>Leave this parameter empty. If this parameter is left empty, all accelerated domain names for which WAF is configured are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The region where WAF is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: inside the Chinese mainland</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland</description></item>
        /// </list>
        /// <remarks>
        /// <para>ap-southeast-1 includes Hong Kong (China), Macao (China), Taiwan (China), and other countries and regions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
