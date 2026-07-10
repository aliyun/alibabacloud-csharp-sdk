// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QueryBlackListStrategyResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code. <b>200</b> indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FC3D6AC-9FED-4311-8DA7-C4BF47D9F260</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<QueryBlackListStrategyResponseBodyResultObject> ResultObject { get; set; }
        public class QueryBlackListStrategyResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The blacklist string. Multiple blacklist entries are separated by <b>commas</b>.</para>
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
            /// <item><description>mobile: phone number blacklist</description></item>
            /// <item><description>ip: IP blacklist</description></item>
            /// <item><description>identifyNum: ID card blacklist</description></item>
            /// <item><description>bankCard: bank card blacklist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>identifyNum</para>
            /// </summary>
            [NameInMap("BizKey")]
            [Validation(Required=false)]
            public string BizKey { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1711533786000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234822</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The product name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>id2meta: ID card two-factor verification.</description></item>
            /// <item><description>mobile3Meta: Phone number factor verification.</description></item>
            /// <item><description>bankcardMeta: Bank card factor verification.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>id2meta</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            /// <summary>
            /// <para>The status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>disabled</b>: Disabled.</description></item>
            /// <item><description><b>normal</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12600512xxxxxxxx</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
