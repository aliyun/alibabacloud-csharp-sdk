// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductExtendProperty : TeaModel {
        /// <summary>
        /// <para>The property key.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><list type="bullet">
        /// <item><description><c>ss_picture_scene</c> (scene picture)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>ss_picture_white_background</c> (white background picture)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>extraPeriod</c> (shelf life)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>itemBoundaryInventoryZeroTag</c> (Reserved. Ignore this parameter.)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>shoppingShowTitle</c> (shopping guide title)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>itemCCStatus</c> (Reserved. Ignore this parameter.)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>brandLogo</c> (brand logo)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>multipleBuyLimit</c> (purchase multiple)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>eticket_type</c> (electronic coupon type)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>eticket_upper_buy_limit</c> (maximum purchase quantity of electronic coupons per order)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>validity_type</c> (validity period type of electronic coupon)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>etc_expiry_date</c> (Validity period of the electronic coupon. Valid only when <c>validity_type</c> is <c>1</c>.)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>etc_duration_date</c> (Validity period of the electronic coupon. Valid only when <c>validity_type</c> is <c>2</c>, <c>3</c>, or <c>5</c>.)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>f_refund</c> (Automatic refund ratio for valid electronic coupons)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>refund</c> (automatic refund ratio for expired electronic coupons)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><list type="bullet">
        /// <item><description><c>writeoff</c> (Reserved. Ignore this parameter.)</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ss_picture_scene</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The property value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>场景图</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
