// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class RefreshWebofficeTokenRequest : TeaModel {
        /// <summary>
        /// <para>Weboffice access token. Obtain it through the <a href="https://help.aliyun.com/document_detail/478226.html">GenerateWebofficeToken</a> or <a href="https://help.aliyun.com/document_detail/478227.html">RefreshWebofficeToken</a> interfaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99d1b8b478b641c1b3372f5bd6********</para>
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para><b>If there are no special requirements, leave it blank.</b></para>
        /// <para>Chained authorization configuration, optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Access Other Entity Resources Using Chained Authorization</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>Project name. For more information on how to obtain it, see <a href="https://help.aliyun.com/document_detail/478153.html">Create Project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>Weboffice refresh token. Obtain it through the <a href="https://help.aliyun.com/document_detail/478226.html">GenerateWebofficeToken</a> or <a href="https://help.aliyun.com/document_detail/478227.html">RefreshWebofficeToken</a> interfaces.</para>
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
