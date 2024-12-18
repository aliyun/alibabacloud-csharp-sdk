// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregatorRequest : TeaModel {
        /// <summary>
        /// <para>The information about the member accounts in the account group. Example:</para>
        /// <pre><c>[{
        ///     &quot;accountId&quot;: 171322098523****,
        ///     &quot;accountType&quot;:&quot;ResourceDirectory&quot;,
        ///                 &quot;accountName&quot;:&quot;Alice&quot;
        /// }, {
        ///     &quot;accountId&quot;: 100532098349****,
        ///     &quot;accountType&quot;:&quot;ResourceDirectory&quot;,
        ///                 &quot;accountName&quot;:&quot;Tom&quot;
        /// }]
        /// </c></pre>
        /// <remarks>
        /// <para> If <c>AggregatorType</c> is set to <c>RD</c> or <c>FOLDER</c>, this parameter can be left empty, which indicates that all accounts in the resource directory are added to the global account group.</para>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AggregatorAccounts")]
        [Validation(Required=false)]
        public List<CreateAggregatorRequestAggregatorAccounts> AggregatorAccounts { get; set; }
        public class CreateAggregatorRequestAggregatorAccounts : TeaModel {
            /// <summary>
            /// <para>The member account ID. For more information about how to obtain the ID of a member account, see <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>171322098523****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The name of the member account. For more information about how to obtain the name of a member account, see <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The type of the member account. Set this parameter to ResourceDirectory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceDirectory</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

        }

        /// <summary>
        /// <para>The name of the account group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test_Group</para>
        /// </summary>
        [NameInMap("AggregatorName")]
        [Validation(Required=false)]
        public string AggregatorName { get; set; }

        /// <summary>
        /// <para>The type of the account group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RD: global account group.</description></item>
        /// <item><description>FOLDER: account group of the folder.</description></item>
        /// <item><description>CUSTOM (default): custom account group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("AggregatorType")]
        [Validation(Required=false)]
        public string AggregatorType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <c>token</c> can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the account group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aggregator description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the folder to which the account group is attached. You must specify this parameter if <c>AggregatorType</c> is set to <c>FOLDER</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-brHdgv****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

    }

}
