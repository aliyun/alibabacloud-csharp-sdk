// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAccountsByLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccountsByLogResponseBodyData> Data { get; set; }
        public class ListAccountsByLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The name of the cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sas_account_xxx</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>Indicates whether the account is connected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Connected.</description></item>
            /// <item><description>0: Not connected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxxxx</para>
            /// </summary>
            [NameInMap("Imported")]
            [Validation(Required=false)]
            public int? Imported { get; set; }

            /// <summary>
            /// <para>The log code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_siem_waf_xxxxx</para>
            /// </summary>
            [NameInMap("LogCode")]
            [Validation(Required=false)]
            public string LogCode { get; set; }

            /// <summary>
            /// <para>The ID of the cloud account that purchased CTDR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXXX</para>
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// <para>The product code corresponding to the log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qcloud_waf</para>
            /// </summary>
            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }

            /// <summary>
            /// <para>The ID of the CTDR cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123XXXXXXXX</para>
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
