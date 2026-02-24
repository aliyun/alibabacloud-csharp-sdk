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
        /// <para>You can leave this parameter empty to skip updating the member list. To update the member list, you must specify both <c>AccountId</c> and <c>AccountType</c>.</para>
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
            /// <para>To update the member list, you must specify both <c>AccountId</c> and <c>AccountType</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>173808452267****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The name of the member.</para>
            /// <para>For more information about how to obtain the name of a member, see <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>.</para>
            /// <remarks>
            /// <para>To update the member list, you must specify both <c>AccountId</c> and <c>AccountType</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Tony</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The affiliation of the member. Only ResourceDirectory is supported.</para>
            /// <remarks>
            /// <para>To update the member list, you must specify both <c>AccountId</c> and <c>AccountType</c>.</para>
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
        /// <para>A client token that ensures the idempotence of the request. Generate a unique token for each request. The token can contain only ASCII characters and must be no more than 64 characters in length.</para>
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
        /// <para>测试组</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the folder. You can enter multiple folder IDs. Separate the IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-brHdgv****,fd-brHdgk****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The tags of the resource. This parameter is deprecated and no longer takes effect. Ignore this parameter.</para>
        /// <para>You can attach up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        [Obsolete]
        public List<UpdateAggregatorRequestTag> Tag { get; set; }
        public class UpdateAggregatorRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. A tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key-1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value can be up to 128 characters in length. It cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
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
