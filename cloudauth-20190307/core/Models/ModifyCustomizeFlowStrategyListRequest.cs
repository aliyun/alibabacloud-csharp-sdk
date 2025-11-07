// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyCustomizeFlowStrategyListRequest : TeaModel {
        /// <summary>
        /// <para>Product type, currently only supports <b>ANT_CLOUD_AUTH</b> (Financial-grade real person), all others have been phased out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ANT_CLOUD_AUTH</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>Strategy list.</para>
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
            /// <para>Flow control statistical window size, in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("AccumulateWindow")]
            [Validation(Required=false)]
            public long? AccumulateWindow { get; set; }

            /// <summary>
            /// <para>API name, same as <b>ProductCode</b>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ID_PRO</para>
            /// </summary>
            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            /// <summary>
            /// <para>Flow type:</para>
            /// <list type="bullet">
            /// <item><description><b>ACCUMULATE</b>: Repeated appearance of ID card</description></item>
            /// <item><description><b>PASSED_RATE</b>: Pass rate less than</description></item>
            /// <item><description><b>SUB_CODE_205</b>: Authentication failed and liveness attack 205 ratio greater than</description></item>
            /// <item><description><b>SUB_CODE_206</b>: Authentication failed and liveness attack 206 ratio greater than</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACCUMULATE</para>
            /// </summary>
            [NameInMap("FlowType")]
            [Validation(Required=false)]
            public string FlowType { get; set; }

            /// <summary>
            /// <para>Rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Operation.</para>
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
            /// <para>Status:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: Disabled</description></item>
            /// <item><description><b>normal</b>: Enabled</description></item>
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
            /// <para>Flow control threshold.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

            /// <summary>
            /// <para>User ID.</para>
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
