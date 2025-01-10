// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListUserSuppressionRequest : TeaModel {
        /// <summary>
        /// <para>Email address or domain name</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.net">test@example.net</a></para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>End time of the last bounce hit, timestamp, accurate to the second. The span between start and end times cannot exceed 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715669077</para>
        /// </summary>
        [NameInMap("EndBounceTime")]
        [Validation(Required=false)]
        public int? EndBounceTime { get; set; }

        /// <summary>
        /// <para>End creation time, timestamp, accurate to the second. The span between start and end times cannot exceed 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715669077</para>
        /// </summary>
        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public int? EndCreateTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Current page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Start time of the last bounce hit, timestamp, accurate to the second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715668852</para>
        /// </summary>
        [NameInMap("StartBounceTime")]
        [Validation(Required=false)]
        public int? StartBounceTime { get; set; }

        /// <summary>
        /// <para>Start creation time, timestamp, accurate to the second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1715668852</para>
        /// </summary>
        [NameInMap("StartCreateTime")]
        [Validation(Required=false)]
        public int? StartCreateTime { get; set; }

    }

}
