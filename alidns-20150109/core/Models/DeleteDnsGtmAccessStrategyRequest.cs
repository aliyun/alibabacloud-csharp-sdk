// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DeleteDnsGtmAccessStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Default value: en. Valid values: en, zh, and ja.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the access policy. Call <a href="https://help.aliyun.com/document_detail/2357191.html">DescribeDnsGtmAccessStrategies</a> to obtain the policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testSt******</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
