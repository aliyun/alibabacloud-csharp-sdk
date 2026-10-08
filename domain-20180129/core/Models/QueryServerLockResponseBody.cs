// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryServerLockResponseBody : TeaModel {
        /// <summary>
        /// <para>Domain instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S20190N1DAI4****</para>
        /// </summary>
        [NameInMap("DomainInstanceId")]
        [Validation(Required=false)]
        public string DomainInstanceId { get; set; }

        /// <summary>
        /// <para>The queried domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>Expiration Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2030-07-10 17:37:36</para>
        /// </summary>
        [NameInMap("ExpireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// <para>Creation Time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10 17:37:36</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>Updated At.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10 17:37:36</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Registry lock instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S2021591IQ28****</para>
        /// </summary>
        [NameInMap("LockInstanceId")]
        [Validation(Required=false)]
        public string LockInstanceId { get; set; }

        /// <summary>
        /// <para>Lock product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1807**</para>
        /// </summary>
        [NameInMap("LockProductId")]
        [Validation(Required=false)]
        public string LockProductId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9DFCF6F8-243C-****-8035-4B12FEFD7D48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Registry lock status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Disabled</description></item>
        /// <item><description>2: Enabled</description></item>
        /// <item><description>3: Shutdown</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ServerLockStatus")]
        [Validation(Required=false)]
        public int? ServerLockStatus { get; set; }

        /// <summary>
        /// <para>The time when the lock takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-10 17:37:36</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>User UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121000000****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
