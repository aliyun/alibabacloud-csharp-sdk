// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class DeleteSecretBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>The blacklisted number. The value type is determined by the <b>BlackType</b> parameter:</para>
        /// <list type="bullet">
        /// <item><description><b>Point-to-point blacklist</b>: a pair of numbers separated by a colon (:)</description></item>
        /// <item><description><b>Number pool blacklist</b>: a single number</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1825<b><b>383:1825</b></b>483</para>
        /// </summary>
        [NameInMap("BlackNo")]
        [Validation(Required=false)]
        public string BlackNo { get; set; }

        /// <summary>
        /// <para>The type of the blacklist. Valid values:</para>
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
        /// <para>The key of the number pool.</para>
        /// <para>You can obtain the <b>number pool key</b> on the <a href="https://dyplsnext.console.aliyun.com/number-pool">Number Pool Management</a> page in the Phone Number Privacy Protection console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC1232****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The remark for the blacklist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Blacklist remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The call direction control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PHONEA_REJECT</b>: The first number in BlackNo can call the second number, but the second number cannot call the first number.</para>
        /// </description></item>
        /// <item><description><para><b>PHONEB_REJECT</b>: The first number in BlackNo cannot call the second number, but the second number can call the first number.</para>
        /// </description></item>
        /// <item><description><para><b>Leave empty</b>: The two numbers in BlackNo cannot call each other.</para>
        /// </description></item>
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
