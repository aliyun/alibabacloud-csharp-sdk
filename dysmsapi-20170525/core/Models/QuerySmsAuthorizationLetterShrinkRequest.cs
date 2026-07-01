// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySmsAuthorizationLetterShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of letter of authorization IDs.</para>
        /// </summary>
        [NameInMap("AuthorizationLetterIdList")]
        [Validation(Required=false)]
        public string AuthorizationLetterIdListShrink { get; set; }

        /// <summary>
        /// <para>The unified social credit code of the authorizing party. The length cannot exceed 150 characters.</para>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The signature name. If the authorization scope includes multiple signatures when you create the letter of authorization, the letters of authorization that contain the signature are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>菜鸟网络</para>
        /// </summary>
        [NameInMap("SignName")]
        [Validation(Required=false)]
        public string SignName { get; set; }

        /// <summary>
        /// <para>The review status of the letter of authorization, which is related to the review status of the signature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INT</b>: Pending review. The letter of authorization has been created. After you submit a signature application, it enters the review process.</description></item>
        /// <item><description><b>PASSED</b>: Review passed. When a signature in the authorized signature scope of the letter of authorization passes the review, the status of the letter of authorization changes to PASSED.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PASSED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The availability status of the letter of authorization, which is related to the validity period of the letter of authorization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VALID</b>: Available. The letter of authorization is within the validity period.</description></item>
        /// <item><description><b>INVALID</b>: Unavailable. The letter of authorization has expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VALID</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
