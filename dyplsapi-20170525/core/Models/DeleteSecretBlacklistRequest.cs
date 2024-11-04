// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class DeleteSecretBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>The phone numbers in the blacklist. A point-to-point blacklist has a pair of numbers separated by a colon (&quot;:&quot;). A number pool blacklist or a platform blacklist has only one single number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18252<em><b>383:18252</b></em>483</para>
        /// </summary>
        [NameInMap("BlackNo")]
        [Validation(Required=false)]
        public string BlackNo { get; set; }

        /// <summary>
        /// <para>The blacklist type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>POINT_TO_POINT_BLACK</b>: point-to-point blacklist</description></item>
        /// <item><description><b>PARTNER_GLOBAL_NUMBER_BLACK</b>: number pool blacklist</description></item>
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
        /// <para>The key of the phone number pool. Log on to the <a href="https://dypls.console.aliyun.com/dypls.htm#/account">Phone Number Protection console</a> and view the key of the phone number pool on the <b>Number Pool Management</b> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC1232****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The remarks for the blacklist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fragile</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The control on the call direction.</para>
        /// <list type="bullet">
        /// <item><description><b>PHONEA_REJECT</b>: The first phone number in the blacklist can be used to call the second phone number, but the second phone number in the blacklist cannot be used to call the first phone number.</description></item>
        /// <item><description><b>PHONEB_REJECT</b>: The first phone number in the blacklist cannot be used to call the second phone number, but the second phone number in the blacklist can be used to call the first phone number.</description></item>
        /// <item><description>If this parameter is not specified, the two phone numbers in the blacklist cannot be used to call each other.</description></item>
        /// </list>
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
