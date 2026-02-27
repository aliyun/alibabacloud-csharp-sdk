// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPoliciesResponseBody : TeaModel {
        [NameInMap("ControlPolicies")]
        [Validation(Required=false)]
        public ListControlPoliciesResponseBodyControlPolicies ControlPolicies { get; set; }
        public class ListControlPoliciesResponseBodyControlPolicies : TeaModel {
            [NameInMap("ControlPolicy")]
            [Validation(Required=false)]
            public List<ListControlPoliciesResponseBodyControlPoliciesControlPolicy> ControlPolicy { get; set; }
            public class ListControlPoliciesResponseBodyControlPoliciesControlPolicy : TeaModel {
                [NameInMap("AttachmentCount")]
                [Validation(Required=false)]
                public string AttachmentCount { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EffectScope")]
                [Validation(Required=false)]
                public string EffectScope { get; set; }

                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                [NameInMap("UpdateDate")]
                [Validation(Required=false)]
                public string UpdateDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the returned page.</para>
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
        /// <para>9424A34C-3471-45AD-B6AB-924BBDFE42F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of access control policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
