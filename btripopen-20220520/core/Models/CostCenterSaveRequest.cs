// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CostCenterSaveRequest : TeaModel {
        /// <summary>
        /// <para>The bound Alipay account.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:example_1234@alipay.com">example_1234@alipay.com</a></para>
        /// </summary>
        [NameInMap("alipay_no")]
        [Validation(Required=false)]
        public string AlipayNo { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the cost center. If this parameter is not specified, the cost center is enabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("disable")]
        [Validation(Required=false)]
        public long? Disable { get; set; }

        /// <summary>
        /// <para>The third-party cost center number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cost_10001</para>
        /// </summary>
        [NameInMap("number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>The applicable scope.</para>
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
        /// <para>100001</para>
        /// </summary>
        [NameInMap("thirdpart_id")]
        [Validation(Required=false)]
        public string ThirdpartId { get; set; }

        /// <summary>
        /// <para>The name of the cost center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>华北项目成本中心</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
