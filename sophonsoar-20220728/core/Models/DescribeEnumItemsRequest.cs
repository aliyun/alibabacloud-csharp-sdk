// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeEnumItemsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the enumeration. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>process</b>: The enumeration for response scenarios.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>process</para>
        /// </summary>
        [NameInMap("EnumType")]
        [Validation(Required=false)]
        public string EnumType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: The default value. Simplified Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: American English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
