// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateAggregatorRequest : TeaModel {
        /// <summary>
        /// <para>The members in the account group.</para>
        /// <remarks>
        /// <para> When you modify the configurations of an account group, this parameter can be left empty. In this case, the member list is not updated. If you want to update the member list, you must configure both the <c>AccountId</c> and <c>AccountType</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AggregatorAccounts")]
        [Validation(Required=false)]
        public List<UpdateAggregatorRequestAggregatorAccounts> AggregatorAccounts { get; set; }
        public class UpdateAggregatorRequestAggregatorAccounts : TeaModel {
            /// <summary>
            /// <para>The ID of the member.</para>
            /// <para>For more information about how to obtain the ID of a member, see <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>.</para>
            /// <remarks>
            /// <para> If you want to update the member list, you must configure both the <c>AccountId</c> and <c>AccountType</c> parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>173808452267****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The display name of the member.</para>
            /// <para>For more information about how to obtain the name of a member, see <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>.</para>
            /// <remarks>
            /// <para> If you want to update the member list, you must configure both the <c>AccountId</c> and <c>AccountType</c> parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Tony</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The resource directory to which the member belongs. Valid value: ResourceDirectory. ResourceDirectory indicates that the member belongs to a resource directory.</para>
            /// <remarks>
            /// <para> If you want to update the member list, you must configure both the <c>AccountId</c> and <c>AccountType</c> parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceDirectory</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-dacf86d8314e00eb****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The name of the account group.</para>
        /// <para>For more information about how to obtain the name of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test_Group</para>
        /// </summary>
        [NameInMap("AggregatorName")]
        [Validation(Required=false)]
        public string AggregatorName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the account group.</para>
        /// <para>For more information about how to obtain the description of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test_Aggregator_Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// <para>You can add up to 20 tags to a resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateAggregatorRequestTag> Tag { get; set; }
        public class UpdateAggregatorRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys.</para>
            /// <para>The tag key cannot be an empty string. The tag key must be 1 to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs</c>:. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag values.</para>
            /// <para>The tag values can be an empty string or up to 128 characters in length. The tag values cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each key-value must be unique. You can specify at most 20 tag values in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
