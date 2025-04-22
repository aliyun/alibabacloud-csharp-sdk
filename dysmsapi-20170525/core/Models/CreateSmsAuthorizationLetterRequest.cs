// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateSmsAuthorizationLetterRequest : TeaModel {
        /// <summary>
        /// <para>授权方，授权方命名长度不超过1000个字符，暂不支持包含除中点（·）、空格、中文括号【】、英文括号()外的任何符号或纯数字输入</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云有限公司</para>
        /// </summary>
        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

        /// <summary>
        /// <para>委托授权书有效期</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-01~2026-01-01</para>
        /// </summary>
        [NameInMap("AuthorizationLetterExpDate")]
        [Validation(Required=false)]
        public string AuthorizationLetterExpDate { get; set; }

        /// <summary>
        /// <para>委托授权书命名非空，不超过100个字符，支持中文、英文或与数字组合进行命名，暂不支持任何符号或纯数字输入</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx公司授权书</para>
        /// </summary>
        [NameInMap("AuthorizationLetterName")]
        [Validation(Required=false)]
        public string AuthorizationLetterName { get; set; }

        /// <summary>
        /// <para>上传oss的委托授权书图片标识</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AuthorizationLetterPic")]
        [Validation(Required=false)]
        public string AuthorizationLetterPic { get; set; }

        /// <summary>
        /// <para>授权方社会统一信用代码，长度不超过150个字符</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9****************A</para>
        /// </summary>
        [NameInMap("OrganizationCode")]
        [Validation(Required=false)]
        public string OrganizationCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>被授权方，被授权方命名长度不超过1000个字符，暂不支持包含除中点（·）、空格、中文括号【】、英文括号()外的任何符号或纯数字输入</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx公司</para>
        /// </summary>
        [NameInMap("ProxyAuthorization")]
        [Validation(Required=false)]
        public string ProxyAuthorization { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>委托授权签名列表，签名数量限制100个以内</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SignList")]
        [Validation(Required=false)]
        public List<string> SignList { get; set; }

    }

}
