// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class ListEmailVerificationRequest : TeaModel {
        /// <summary>
        /// <para>The start time for querying email verification creation, represented as the number of milliseconds since 00:00 on January 1, 1970, UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("BeginCreateTime")]
        [Validation(Required=false)]
        public long? BeginCreateTime { get; set; }

        /// <summary>
        /// <para>The email address to query. You can upload only one email address at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The end time for querying the creation of email verification, calculated as the number of milliseconds since 00:00 UTC on January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1522080000000</para>
        /// </summary>
        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        /// <summary>
        /// <para>Language of error messages returned by the API. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.  </description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Default value is <b>en</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number for paging through the domain list. Default value is <b>1</b>. You can set this parameter based on your needs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The page size for paging through the domain list. Default value is <b>500</b>, and the maximum value is <b>5000</b>. You can set this parameter based on your needs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>User IP address. You can set it to <b>127.0.0.1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>Email verification status. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Waiting for verification.  </description></item>
        /// <item><description><b>1</b>: Verification succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("VerificationStatus")]
        [Validation(Required=false)]
        public int? VerificationStatus { get; set; }

    }

}
