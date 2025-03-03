// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListControlPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The access control policies.</para>
        /// </summary>
        [NameInMap("ControlPolicies")]
        [Validation(Required=false)]
        public ListControlPoliciesResponseBodyControlPolicies ControlPolicies { get; set; }
        public class ListControlPoliciesResponseBodyControlPolicies : TeaModel {
            [NameInMap("ControlPolicy")]
            [Validation(Required=false)]
            public List<ListControlPoliciesResponseBodyControlPoliciesControlPolicy> ControlPolicy { get; set; }
            public class ListControlPoliciesResponseBodyControlPoliciesControlPolicy : TeaModel {
                /// <summary>
                /// <para>The number of times that the access control policy is referenced.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44</para>
                /// </summary>
                [NameInMap("AttachmentCount")]
                [Validation(Required=false)]
                public string AttachmentCount { get; set; }

                /// <summary>
                /// <para>The time when the access control policy was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-05T06:32:24Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The description of the access control policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>System access control policy available for all operations on the cloud</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The effective scope of the access control policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>All: The access control policy is in effect for Alibaba Cloud accounts, RAM users, and RAM roles.</description></item>
                /// <item><description>RAM: The access control policy is in effect only for RAM users and RAM roles.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>All</para>
                /// </summary>
                [NameInMap("EffectScope")]
                [Validation(Required=false)]
                public string EffectScope { get; set; }

                /// <summary>
                /// <para>The ID of the access control policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cp-FullAliyunAccess</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <para>The name of the access control policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FullAliyunAccess</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

                /// <summary>
                /// <para>The type of the access control policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>System: system access control policy</description></item>
                /// <item><description>Custom: custom access control policy</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>The time when the access control policy was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-05T06:32:24Z</para>
                /// </summary>
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
