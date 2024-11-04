// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class AddSecretBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>The numbers in the blacklist. A point-to-point blacklist has a pair of numbers separated by a colon (:). A number pool blacklist has only one single number.</para>
        /// <remarks>
        /// <para> The asterisks (\*) in the sample value are not wildcards.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1825638****:1825248****</para>
        /// </summary>
        [NameInMap("BlackNo")]
        [Validation(Required=false)]
        public string BlackNo { get; set; }

        /// <summary>
        /// <para>The blacklist type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>POINT_TO_POINT_BLACK</b>: point-to-point blacklist.</description></item>
        /// <item><description><b>PARTNER_GLOBAL_NUMBER_BLACK</b>: number pool blacklist.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POINT_TO_POINT_BLACK</para>
        /// </summary>
        [NameInMap("BlackType")]
        [Validation(Required=false)]
        public string BlackType { get; set; }

        /// <summary>
        /// <para>The key of the phone number pool.</para>
        /// <para>Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the Number Pool Management page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2235****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The blacklist remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer service feedback</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The control on the call direction.</para>
        /// <list type="bullet">
        /// <item><description><b>PHONEA_REJECT</b>: The first number in the blacklist can be used to call the second number, but the second number cannot be used to call the first number.</description></item>
        /// <item><description><b>PHONEB_REJECT</b>: The first number in the blacklist cannot be used to call the second number, but the second number can be used to call the first number.</description></item>
        /// <item><description>If this parameter is left empty, the two numbers in the blacklist cannot be used to call each other.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only for a point-to-point blacklist.</para>
        /// </remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DUPLEX_REJECT</description></item>
        /// <item><description>PHONEA_REJECT</description></item>
        /// <item><description>PHONEB_REJECT</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PHONEA_REJECT</para>
        /// </summary>
        [NameInMap("WayControl")]
        [Validation(Required=false)]
        public string WayControl { get; set; }

    }

}
