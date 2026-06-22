// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class RefreshWebofficeTokenShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Weboffice access token. You can obtain the token by calling the <a href="https://help.aliyun.com/document_detail/478226.html">GenerateWebofficeToken</a> or <a href="https://help.aliyun.com/document_detail/478227.html">RefreshWebofficeToken</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99d1b8b478b641c1b3372f5bd6********</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para><b>Leave this parameter empty unless you have special requirements.</b></para>
        /// <para>The China authorization configuration. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The Weboffice refresh token. You can obtain the token by calling the <a href="https://help.aliyun.com/document_detail/478226.html">GenerateWebofficeToken</a> or <a href="https://help.aliyun.com/document_detail/478227.html">RefreshWebofficeToken</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a730ae0d7c6a487d87c661d199********</para>
        /// </summary>
        [NameInMap("RefreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

    }

}
