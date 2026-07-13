// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the GTM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Specifies whether to return additional information. The default value is <b>false</b>. If you set this parameter to <b>true</b>, the response includes AccessStrategyNum (the number of access policies) and AddressPoolNum (the number of address pools).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedDetailAttributes")]
        [Validation(Required=false)]
        public bool? NeedDetailAttributes { get; set; }

    }

}
