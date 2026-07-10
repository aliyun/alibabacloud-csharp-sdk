// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyCustomizeFlowStrategyListRequest : TeaModel {
        /// <summary>
        /// <para>The product type. Currently, only <b>ANT_CLOUD_AUTH</b> (financial-grade ID Verification) is supported. All other types have been discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANT_CLOUD_AUTH</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The policy list.</para>
        /// </summary>
        [NameInMap("StrategyObject")]
        [Validation(Required=false)]
        public List<ModifyCustomizeFlowStrategyListRequestStrategyObject> StrategyObject { get; set; }
        public class ModifyCustomizeFlowStrategyListRequestStrategyObject : TeaModel {
            /// <summary>
            /// <para>AccumulateKey</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("AccumulateKey")]
            [Validation(Required=false)]
            public string AccumulateKey { get; set; }

            /// <summary>
            /// <para>The size of the rate limiting statistical window, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("AccumulateWindow")]
            [Validation(Required=false)]
            public long? AccumulateWindow { get; set; }

            /// <summary>
            /// <para>The API name, which is the same as <b>ProductCode</b>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID_PRO</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>The flow type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ACCUMULATE</b>: repeated occurrence of an ID card.</description></item>
            /// <item><description><b>PASSED_RATE</b>: pass rate is less than.</description></item>
            /// <item><description><b>SUB_CODE_205</b>: authentication failed and the proportion of liveness attack 205 is greater than.</description></item>
            /// <item><description><b>SUB_CODE_206</b>: authentication failed and the proportion of liveness attack 206 is greater than.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACCUMULATE</para>
            /// </summary>
            [NameInMap("FlowType")]
            [Validation(Required=false)]
            public string FlowType { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The operation.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: disabled.</description></item>
            /// <item><description><b>normal</b>: enabled.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The rate limiting threshold.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>126005125163xxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
