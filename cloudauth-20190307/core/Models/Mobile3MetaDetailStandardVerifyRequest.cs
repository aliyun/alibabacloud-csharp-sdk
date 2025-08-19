// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Mobile3MetaDetailStandardVerifyRequest : TeaModel {
        /// <summary>
        /// <para>ID number:</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is <c>normal</c>: Input the plain text of the ID number.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>: Input the encrypted text of the ID number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>429001********8211</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>Phone number:</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is <c>normal</c>: Input the plain text of the phone number.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>: Input the encrypted text of the phone number.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>138********</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>Parameter type:</para>
        /// <list type="bullet">
        /// <item><description>normal: Unencrypted.</description></item>
        /// <item><description>md5: Encrypted with MD5.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>Name:</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is <c>normal</c>: Input the plain text of the name.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>: Input the encrypted text of the name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
