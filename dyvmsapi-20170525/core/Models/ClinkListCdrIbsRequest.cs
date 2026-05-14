// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkListCdrIbsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>177xxxx7750</para>
        /// </summary>
        [NameInMap("ClientNumber")]
        [Validation(Required=false)]
        public string ClientNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0032</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("CustomerNumber")]
        [Validation(Required=false)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8004970</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HiddenType")]
        [Validation(Required=false)]
        public long? HiddenType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>uniq_1-162046xxxx.12</para>
        /// </summary>
        [NameInMap("MainUniqueId")]
        [Validation(Required=false)]
        public string MainUniqueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2233</para>
        /// </summary>
        [NameInMap("Qno")]
        [Validation(Required=false)]
        public string Qno { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("QueueAnswerInTime")]
        [Validation(Required=false)]
        public long? QueueAnswerInTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1775024775</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
