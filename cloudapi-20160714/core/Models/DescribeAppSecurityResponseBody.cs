// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeAppSecurityResponseBody : TeaModel {
        /// <summary>
        /// <para>The AppCode of the app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3aaf905a0a1f4f0eabc6d891dfa08afc</para>
        /// </summary>
        [NameInMap("AppCode")]
        [Validation(Required=false)]
        public string AppCode { get; set; }

        /// <summary>
        /// <para>The key of the app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60030986</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The password of the app.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1ae97aaa7e45f21d10824bc44678fee</para>
        /// </summary>
        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        /// <summary>
        /// <para>The creation time (UTC) of the key, which is the same as the app creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-07-31T04:10:19Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The modification time (UTC) of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2016-07-31T04:10:19Z</para>
        /// </summary>
        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ015</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
