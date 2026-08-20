// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddUserVpcAuthorizationRequest : TeaModel {
        /// <summary>
        /// <para>The authorization channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AUTH_CODE: verification code authorization.</description></item>
        /// <item><description>RESOURCE_DIRECTORY: resource directory authorization.</description></item>
        /// </list>
        /// <para>Default value: AUTH_CODE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTH_CODE</para>
        /// </summary>
        [NameInMap("AuthChannel")]
        [Validation(Required=false)]
        public string AuthChannel { get; set; }

        /// <summary>
        /// <para>The verification code.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If AuthChannel is empty or set to AUTH_CODE, specify the verification code.  </description></item>
        /// <item><description>In other cases, specify a random 6-digit number, such as 123456.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The authorization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: normal authorization.</description></item>
        /// <item><description>CLOUD_PRODUCT: cloud product authorization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that owns the authorized resource.</para>
        /// <remarks>
        /// <para>Cross-account authorization only supports Alibaba Cloud accounts (primary accounts) and does not support RAM users. Only accounts within the same site can be associated, such as between Alibaba Cloud China Website (<a href="http://www.aliyun.com">www.aliyun.com</a>) accounts or between Alibaba Cloud International Website (<a href="http://www.alibabacloud.com">www.alibabacloud.com</a>) accounts. Cross-site association is not supported, such as between a China Website account and an International Website account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141339776561****</para>
        /// </summary>
        [NameInMap("AuthorizedUserId")]
        [Validation(Required=false)]
        public long? AuthorizedUserId { get; set; }

    }

}
