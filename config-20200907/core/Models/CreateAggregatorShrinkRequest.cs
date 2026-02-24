// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregatorShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The member accounts of the account group.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>AggregatorType</c> to \`RD, you can leave this parameter empty. This indicates that all members in the resource directory are added to the global account group.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>AggregatorType</c> to <c>FOLDER</c>, you can leave this parameter empty. This indicates that all members in a specific folder in the resource directory are added to the folder account group.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AggregatorAccounts")]
        [Validation(Required=false)]
        public string AggregatorAccountsShrink { get; set; }

        /// <summary>
        /// <para>The name of the account group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example_Aggregator</para>
        /// </summary>
        [NameInMap("AggregatorName")]
        [Validation(Required=false)]
        public string AggregatorName { get; set; }

        /// <summary>
        /// <para>The type of the account group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RD: global account group.</para>
        /// </description></item>
        /// <item><description><para>FOLDER: folder account group. You must also set the <c>FolderId</c> parameter. For more information about how to obtain a folder ID, see <a href="https://help.aliyun.com/document_detail/160016.html">ListAccounts</a>.</para>
        /// </description></item>
        /// <item><description><para>CUSTOM (default): custom account group. You must also set the <c>AccountId</c> and <c>AccountType</c> parameters for <c>AggregatorAccounts</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CUSTOM</para>
        /// </summary>
        [NameInMap("AggregatorType")]
        [Validation(Required=false)]
        public string AggregatorType { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You must make sure that the token is unique for different requests. The <c>ClientToken</c> parameter can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594295238-f9361358-5843-4294-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the account group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example aggregator used to demonstrate how to create an aggregator.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the attached folder. You can specify multiple folder IDs. Separate the IDs with commas (,).</para>
        /// <para>This parameter is required if you set <c>AggregatorType</c> to <c>FOLDER</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fd-brHdgv****,fd-brHdgk****</para>
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// <para>You can attach a maximum of 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
