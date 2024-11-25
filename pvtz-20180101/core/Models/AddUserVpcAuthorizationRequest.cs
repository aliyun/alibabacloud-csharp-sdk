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
        /// <item><description>AUTH_CODE: A verification code is used for authorization.</description></item>
        /// <item><description>RESOURCE_DIRECTORY: A resource directory is used for authorization.</description></item>
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
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The specified authentication code is used if the value of AuthChannel is left empty or is set to AUTH_CODE.</para>
        /// </description></item>
        /// <item><description><para>In other cases, a random 6-digit number is used. Example: 123456.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AuthCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>The authorization scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: general authorization</description></item>
        /// <item><description>CLOUD_PRODUCT: cloud service-related authorization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the permissions on the resources are granted.</para>
        /// <remarks>
        /// <para> You can set an effective scope across accounts only by using an Alibaba Cloud account instead of a RAM user. You can set an effective scope across accounts registered on the same site. For example, you can perform the operation across accounts that are both registered on the Alibaba Cloud China site or Alibaba Cloud international site. You cannot set an effective scope across accounts registered on different sites. For example, you cannot perform the operation across accounts that are separately registered on the Alibaba Cloud China site and Alibaba Cloud international site.</para>
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
