// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySubscriptionDetailRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The privacy number in the binding relationship, which is the X number.</para>
        /// <para>Logon to the privacy protection console and go to the <a href="https://dyplsnext.console.aliyun.com/number/list">Number Management</a> page to obtain the X number. Alternatively, check the <b>SecretNo</b> in the response parameters when you invoke number binding API operations such as <a href="https://www.alibabacloud.com/help/en/pnp/developer-reference/api-dyplsapi-2017-05-25-bindaxb">BindAxb</a>.</para>
        /// <remarks>
        /// <para>When specifying the X number, make sure it is associated with the <b>SubsId</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>139****1111</para>
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        /// <summary>
        /// <para>The key of the number pool.</para>
        /// <para>Log on to the privacy protection console and go to the <a href="https://dyplsnext.console.aliyun.com/number-pool?spm=a2c4g.11186623.0.0.7e6449bbtiHP8m">Number Pool Management</a> page to obtain the <b>Number Pool Key</b>.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>ProductType</b> is left empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FC10000012345****</para>
        /// </summary>
        [NameInMap("PoolKey")]
        [Validation(Required=false)]
        public string PoolKey { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AXB_170</b></description></item>
        /// <item><description><b>AXN_170</b></description></item>
        /// <item><description><b>AXN_95</b></description></item>
        /// <item><description><b>AXN_EXTENSION_REUSE</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is applicable to former Alibaba Dayu users. Alibaba Cloud users can ignore this parameter.</description></item>
        /// <item><description>This parameter is required when <b>PoolKey</b> is left empty.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AXB_170</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The binding relationship ID.</para>
        /// <para>Logon to the privacy protection console, go to the <a href="https://dyplsnext.console.aliyun.com/number/list">Number Management</a> page, filter the numbers, and click <b>Details</b> to view the binding relationship ID. Alternatively, check the <b>SubsId</b> in the response parameters when you invoke number binding API operations such as <a href="https://www.alibabacloud.com/help/en/pnp/developer-reference/api-dyplsapi-2017-05-25-bindaxb">BindAxb</a>.</para>
        /// <remarks>
        /// <para>When specifying the binding relationship ID, make sure it is associated with the <b>PhoneNoX</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000076879****</para>
        /// </summary>
        [NameInMap("SubsId")]
        [Validation(Required=false)]
        public string SubsId { get; set; }

    }

}
