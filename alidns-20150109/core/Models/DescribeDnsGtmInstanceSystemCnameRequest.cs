// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceSystemCnameRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. &lt;props=&quot;china&quot;&gt;Call <a href="https://help.aliyun.com/zh/dns/api-alidns-2015-01-09-describednsgtminstances?spm=a2c4g.11186623.help-menu-29697.d_0_5_1_3_8_8.2aea3618RlSR9K">DescribeDnsGtmInstances</a> to obtain the ID.
        /// &lt;props=&quot;intl&quot;&gt;Call <a href="https://www.alibabacloud.com/help/zh/dns/api-alidns-2015-01-09-describednsgtminstances?spm=a2c63.p38356.help-menu-search-29697.d_0">DescribeDnsGtmInstances</a> to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the response. The default value is en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
