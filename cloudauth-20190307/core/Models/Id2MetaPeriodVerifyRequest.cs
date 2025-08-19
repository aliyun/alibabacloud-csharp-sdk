// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class Id2MetaPeriodVerifyRequest : TeaModel {
        /// <summary>
        /// <para>ID number:</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> is <c>normal</c>: Enter the plain text of the ID number.</description></item>
        /// <item><description>When <c>paramType</c> is <c>md5</c>:
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
        /// <item><description>normal: Unencrypted.</description></item>
        /// <item><description>md5: MD5 encrypted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("ParamType")]
        [Validation(Required=false)]
        public string ParamType { get; set; }

        /// <summary>
        /// <para>Name.</para>
        /// <list type="bullet">
        /// <item><description>When <c>paramType</c> = <c>normal</c>: Enter the plain text of the name.</description></item>
        /// <item><description>When <c>paramType</c> = <c>md5</c>: The first character of the name MD5 encrypted (32 lowercase MD5) + the rest of the name in plain text.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>张*</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>End date of ID validity, format: YYYYMMDD</para>
        /// 
        /// <b>Example:</b>
        /// <para>20301001</para>
        /// </summary>
        [NameInMap("ValidityEndDate")]
        [Validation(Required=false)]
        public string ValidityEndDate { get; set; }

        /// <summary>
        /// <para>Start date of ID validity, format: YYYYMMDD</para>
        /// 
        /// <b>Example:</b>
        /// <para>20201001</para>
        /// </summary>
        [NameInMap("ValidityStartDate")]
        [Validation(Required=false)]
        public string ValidityStartDate { get; set; }

    }

}
