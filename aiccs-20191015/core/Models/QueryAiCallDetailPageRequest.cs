// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryAiCallDetailPageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1212131231****</para>
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ANSWERED</para>
        /// </summary>
        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>053714454****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        [NameInMap("DetailIds")]
        [Validation(Required=false)]
        public List<long?> DetailIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>73</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public long? EncryptionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("EndCallingTime")]
        [Validation(Required=false)]
        public long? EndCallingTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("EndImportedTime")]
        [Validation(Required=false)]
        public long? EndImportedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A</para>
        /// </summary>
        [NameInMap("MajorIntent")]
        [Validation(Required=false)]
        public string MajorIntent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxConversationDuration")]
        [Validation(Required=false)]
        public long? MaxConversationDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinConversationDuration")]
        [Validation(Required=false)]
        public long? MinConversationDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("StartCallingTime")]
        [Validation(Required=false)]
        public long? StartCallingTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1748948749000</para>
        /// </summary>
        [NameInMap("StartImportedTime")]
        [Validation(Required=false)]
        public long? StartImportedTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1212131231****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
