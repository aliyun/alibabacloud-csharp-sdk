// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class ModifyBlackListStrategyRequest : TeaModel {
        /// <summary>
        /// <para>Blacklist rule.</para>
        /// </summary>
        [NameInMap("BlackListStrategy")]
        [Validation(Required=false)]
        public ModifyBlackListStrategyRequestBlackListStrategy BlackListStrategy { get; set; }
        public class ModifyBlackListStrategyRequestBlackListStrategy : TeaModel {
            /// <summary>
            /// <para>Blacklist string, with each blacklist entry separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1,127.0.0.2</para>
            /// </summary>
            [NameInMap("BizContent")]
            [Validation(Required=false)]
            public string BizContent { get; set; }

            /// <summary>
            /// <para>List Type:</para>
            /// <list type="bullet">
            /// <item><description><b>mobile</b>: Mobile number blacklist</description></item>
            /// <item><description><b>ip</b>: IP blacklist</description></item>
            /// <item><description><b>identifyNum</b>: ID number blacklist</description></item>
            /// <item><description><b>bankCard</b>: Bank card blacklist</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("BizKey")]
            [Validation(Required=false)]
            public string BizKey { get; set; }

            /// <summary>
            /// <para>Rule ID:</para>
            /// <list type="bullet">
            /// <item><description><b>Empty</b>: Add a new rule</description></item>
            /// <item><description><b>Non-empty</b>: Modify an existing rule</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Product Name:</para>
            /// <list type="bullet">
            /// <item><description><b>id2meta</b>: ID card two-factor verification</description></item>
            /// <item><description><b>mobile3Meta</b>: Mobile number factor verification</description></item>
            /// <item><description><b>bankcardMeta</b>: Bank card factor verification</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>id2meta</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>Verification Status:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Verification passed</description></item>
            /// <item><description><b>2</b>: Verification failed</description></item>
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
        /// <para>Region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
