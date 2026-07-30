// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CostCenterModifyRequest : TeaModel {
        /// <summary>
        /// <para>The bound Alipay account.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:a@alipay.com">a@alipay.com</a></para>
        /// </summary>
        [NameInMap("alipay_no")]
        [Validation(Required=false)]
        public string AlipayNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the cost center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not disabled.</description></item>
        /// <item><description><b>1</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("disable")]
        [Validation(Required=false)]
        public long? Disable { get; set; }

        /// <summary>
        /// <para>The number of the cost center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>The scope of the cost center. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: all employees.</description></item>
        /// <item><description>2: partial employees.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public long? Scope { get; set; }

        /// <summary>
        /// <para>The third-party cost center ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>340049</para>
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

        /// <summary>
        /// <para>The name of the cost center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试成本中心</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
