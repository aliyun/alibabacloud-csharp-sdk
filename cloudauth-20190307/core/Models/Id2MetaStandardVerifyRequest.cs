// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id2MetaStandardVerifyRequest : TeaModel {
        /// <summary>
        /// <para>ID number:</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is normal: enter the plain text of the ID number.</description></item>
        /// <item><description>When <c>paramType</c> is md5:
        /// The first 6 digits (plain text) + date of birth (encrypted) + last 4 digits (plain text).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4****************1</para>
        /// </summary>
        [NameInMap("IdentifyNum")]
        [Validation(Required=false)]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// <para>Parameter type:</para>
        /// <list type="bullet">
        /// <item><description>normal: unencrypted.</description></item>
        /// <item><description>md5: md5 encrypted.</description></item>
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
        /// <item><description>When <c>paramType</c> is normal: enter the plain text of the name.</description></item>
        /// <item><description>When <c>paramType</c> is md5: the first character of the name (encrypted) + the rest of the name (plain text).</description></item>
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
