// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class AddSecretBlacklistRequest : TeaModel {
        /// <summary>
        /// <para>The blacklisted phone number. The value type depends on the <b>BlackType</b> parameter:</para>
        /// <list type="bullet">
        /// <item><description><b>Point-to-point blacklist</b>: A pair of numbers (A and B numbers) separated by a colon (:).</description></item>
        /// <item><description><b>Number pool blacklist</b>: A single number.</description></item>
        /// </list>
        /// <remarks>
        /// <para>(\*) is not a wildcard.</para>
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
        /// <para>The key of the number pool.</para>
        /// <para>You can obtain the <b>number pool key</b> on the <a href="https://dyplsnext.console.aliyun.com/number-pool">Number Pool Management</a> page in the privacy protection console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2235****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The remarks for the blacklist entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Blacklist remarks</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The call direction control. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PHONEA_REJECT</b>: The first number in BlackNo can call the second number, but the second number cannot call the first number.</description></item>
        /// <item><description><b>PHONEB_REJECT</b>: The first number in BlackNo cannot call the second number, but the second number can call the first number.</description></item>
        /// <item><description><b>Not specified</b>: The two numbers in BlackNo cannot call each other.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only for point-to-point blacklists.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PHONEA_REJECT</para>
        /// </summary>
        [NameInMap("WayControl")]
        [Validation(Required=false)]
        public string WayControl { get; set; }

    }

}
