// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyBlackListStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The blacklist rule.</para>
        /// </summary>
        [NameInMap("BlackListStrategy")]
        [Validation(Required=false)]
        public ModifyBlackListStrategyRequestBlackListStrategy BlackListStrategy { get; set; }
        public class ModifyBlackListStrategyRequestBlackListStrategy : TeaModel {
            /// <summary>
            /// <para>The blacklist string. Separate multiple entries with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1,127.0.0.2</para>
            /// </summary>
            [NameInMap("BizContent")]
            [Validation(Required=false)]
            public string BizContent { get; set; }

            /// <summary>
            /// <para>The blacklist type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mobile</b>: mobile number blacklist.</description></item>
            /// <item><description><b>ip</b>: IP blacklist.</description></item>
            /// <item><description><b>identifyNum</b>: ID card blacklist.</description></item>
            /// <item><description><b>bankCard</b>: bank card blacklist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("BizKey")]
            [Validation(Required=false)]
            public string BizKey { get; set; }

            /// <summary>
            /// <para>The rule ID. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Empty</b>: creates a rule.</description></item>
            /// <item><description><b>Not empty</b>: modifies a rule.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The product name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>id2meta</b>: ID card two-element verification.</description></item>
            /// <item><description><b>mobile3Meta</b>: mobile number element verification.</description></item>
            /// <item><description><b>bankcardMeta</b>: bank card element verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>id2meta</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The authentication status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Authentication passed.</description></item>
            /// <item><description><b>2</b>: Authentication failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
