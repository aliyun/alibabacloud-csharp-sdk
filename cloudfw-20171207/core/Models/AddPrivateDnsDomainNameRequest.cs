// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddPrivateDnsDomainNameRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the private DNS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw-xxx</para>
        /// </summary>
        [NameInMap("AccessInstanceId")]
        [Validation(Required=false)]
        public string AccessInstanceId { get; set; }

        /// <summary>
        /// <para>The list of private domain names to add.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DomainNameList")]
        [Validation(Required=false)]
        public List<string> DomainNameList { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located.</para>
        /// <remarks>
        /// <para>For more information about the regions that Cloud Firewall supports, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

    }

}
