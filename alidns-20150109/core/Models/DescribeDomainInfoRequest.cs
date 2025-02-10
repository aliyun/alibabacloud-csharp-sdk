// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainInfoRequest : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dns-example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The language type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether detailed attributes are required. Default value: <b>false</b>, which indicates that detailed attributes are not returned.</para>
        /// <para>If you set this parameter to <b>true</b>, the values of the following parameters are returned: LineType, MinTtl, RecordLineTreeJson, RecordLines, LineCode, LineDisplayName, LineName, RegionLines, and SlaveDns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedDetailAttributes")]
        [Validation(Required=false)]
        public bool? NeedDetailAttributes { get; set; }

    }

}
