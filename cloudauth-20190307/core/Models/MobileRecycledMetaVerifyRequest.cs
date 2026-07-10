// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class MobileRecycledMetaVerifyRequest : TeaModel {
        /// <summary>
        /// <para>The phone number. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If ParamType is set to normal, pass in the phone number in plaintext.</description></item>
        /// <item><description>If ParamType is set to md5, pass in the MD5-encrypted phone number.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>明文：186****2055</para>
        /// <para>密文：</para>
        /// <para>849169cd3b20621c1c78bd61a11a4fc2</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: plaintext without encryption</description></item>
        /// <item><description>md5: MD5 encryption.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>The registration date in the format YYYYMMDD. For example, 19800101 indicates January 1, 1980.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20200505</para>
        /// </summary>
        [NameInMap("RegisterDate")]
        [Validation(Required=false)]
        public string RegisterDate { get; set; }

    }

}
