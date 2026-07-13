// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainInfoRequest : TeaModel {
        /// <summary>
        /// <para>The domain name. Call <a href="https://help.aliyun.com/document_detail/2357286.html">DescribeDomains</a> to obtain the domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese</para>
        /// </description></item>
        /// <item><description><para>en: English</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to return detailed attributes of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is false.</para>
        /// <para>If you set this parameter to <b>true</b>, the response includes the following parameters: lineType, minTtl, recordLineTreeJson, recordLines, lineCode, lineDisplayName, lineName, regionLines, and slaveDns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedDetailAttributes")]
        [Validation(Required=false)]
        public bool? NeedDetailAttributes { get; set; }

    }

}
