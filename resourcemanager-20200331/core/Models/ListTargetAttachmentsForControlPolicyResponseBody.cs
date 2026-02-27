// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTargetAttachmentsForControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B32BD3D6-1089-41F3-8E70-E0079BC7D760</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TargetAttachments")]
        [Validation(Required=false)]
        public ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachments TargetAttachments { get; set; }
        public class ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachments : TeaModel {
            [NameInMap("TargetAttachment")]
            [Validation(Required=false)]
            public List<ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachmentsTargetAttachment> TargetAttachment { get; set; }
            public class ListTargetAttachmentsForControlPolicyResponseBodyTargetAttachmentsTargetAttachment : TeaModel {
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                [NameInMap("TargetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

                [NameInMap("TargetName")]
                [Validation(Required=false)]
                public string TargetName { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of objects to which the control policy is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
