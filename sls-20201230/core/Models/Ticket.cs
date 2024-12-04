// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Ticket : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000000000</para>
        /// </summary>
        [NameInMap("callerUid")]
        [Validation(Required=false)]
        public long? CallerUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-09-06 14:57:07</para>
        /// </summary>
        [NameInMap("createDate")]
        [Validation(Required=false)]
        public string CreateDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("expirationTime")]
        [Validation(Required=false)]
        public long? ExpirationTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-09-06 14:58:07</para>
        /// </summary>
        [NameInMap("expireDate")]
        [Validation(Required=false)]
        public string ExpireDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;xx&quot;:&quot;yy&quot;}</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;:&quot;aliyun&quot;,&quot;ids&quot;:[1,2]}</para>
        /// </summary>
        [NameInMap("sharingTo")]
        [Validation(Required=false)]
        public string SharingTo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("ticket")]
        [Validation(Required=false)]
        public string Ticket_ { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("ticketId")]
        [Validation(Required=false)]
        public string TicketId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("usedNumber")]
        [Validation(Required=false)]
        public int? UsedNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("valid")]
        [Validation(Required=false)]
        public bool? Valid { get; set; }

    }

}
